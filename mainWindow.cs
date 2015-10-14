using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace qRcon
{
    public partial class mainWindow : Form
    {
        RCON currentRcon;
        Server currentServer;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            foreach(RCON R in Serialize.loadSavedServers())
                this.savedServers.Items.Add(R);
            
            UpdateInformation versionInfo = Updating.getUpdateInformation();
            if (!versionInfo.successfulCheck || versionInfo.latestVersion == 0)
                updateConsoleOutput("Failed to get update information. Current version is " + versionInfo.currentVersion);
            else if (versionInfo.currentVersion < versionInfo.latestVersion)
                updateConsoleOutput("qRCON is outdated! Latest version is v{0}. You are using v{1}\nDownload at {2}\nChangelog: {3}", versionInfo.latestVersion, versionInfo.currentVersion,versionInfo.updateLink, versionInfo.changeLog);
            else
                updateConsoleOutput("Your version of qRCON is up to date.");

            this.rconCommandResponse.Select(0, rconCommandResponse.Text.Length - 1);
            this.rconCommandResponse.SelectionColor = Color.Red;
            this.Text = (this.Text + " v" + versionInfo.currentVersion);
        }

        private void deleteSavedServer_Click(object sender, EventArgs e)
        {
            Serialize.Delete(savedServers.SelectedItem);
            savedServers.Items.Remove(savedServers.SelectedItem);
        }

        private void addSavedServer_Click(object sender, EventArgs e)
        {
            addServerDialog addServer = new addServerDialog();
            addServer.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            addServer.ShowDialog();
     
            if (addServer.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                RCON newServer = new IW4Rcon(addServer.serverIPBox.Text, ushort.Parse(addServer.serverPortBox.Text), addServer.serverPasswordBox.Text);
                savedServers.Items.Add(newServer);
                Serialize.Save(newServer);
            }

            addServer.Close();
            addServer.Dispose();
        }

        private void loadSavedServer_Click(object sender, EventArgs e)
        {
            if(savedServers.SelectedItem != null)
            {
                RCON test = (RCON)(savedServers.SelectedItem);
                currentRcon = test;
                getServerInfo(test);
                populateGametypeList();
                populateMapList();
            }
        }
        
        private void refreshServerInfo(Server S)
        {
            this.hostnameLabel.Text = S.Hostname;
            this.gametypeLabel.Text = S.getGametype();
            this.modLabel.Text = S.Mod;
            this.playersLabel.Text = S.currentPlayers + "/" + S.maxPlayers;
            this.serverMapLabel.Text = S.getMapName();
            this.playerListBox.Items.Clear();
            foreach (Player P in S.Players)
            {
                if (P.Name != null)
                    this.playerListBox.Items.Add(P);
            }
        }

        private void getServerInfo(RCON R)
        {
            Dictionary<String, String> getStatus = R.getStatus();
            Thread.Sleep(100);
            RCON_Response maxPlayers = R.rconQuery("sv_maxclients");
            Thread.Sleep(100);
            RCON_Response fs_game = R.rconQuery("fs_game");

            if (getStatus.Count > 0 && maxPlayers.Success && fs_game.Success)
            {
                Player[] playerList = new Player[Int32.Parse(maxPlayers.Response.Value)];

                int count = 0;
                foreach (String S in getStatus["Players"].Split(','))
                {
                    if (S.Length > 0)
                    {
                        String[] eachPlayers = S.Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
                        String[] eachPlayerScore = eachPlayers[0].Split(' ');
                        Player newPlayer = new Player(eachPlayers[1], Int32.Parse(eachPlayerScore[1]), Int32.Parse(eachPlayerScore[0]), count);
                        playerList[count] = newPlayer;
                        count++;
                    }
                }

                Server newServer = new Server(getStatus["sv_hostname"], count, Int32.Parse(maxPlayers.Response.Value), getStatus["g_gametype"], fs_game.Response.Value, playerList, new IW4Localization(), getStatus["mapname"]);
                refreshServerInfo(newServer);
                updateConsoleOutput("[" + maxPlayers.responseTime + "ms] Successfully updated server: " + newServer.Hostname);
                currentServer = newServer;
            }

            else if (currentServer == null)
            {
                if (maxPlayers.Error == RCON_Error.REQUEST_TIMED_OUT)
                {
                    MessageBox.Show("Timed out trying to connect to the server.\nPerhaps it is offline or no RCON password is set.");
                }
            }

            else
            {
                queryUserFeedback(maxPlayers);
            }
        }

        private void rconCommandSubmit_Click(object sender, EventArgs e)
        {
            if(rconCommandBox.Text.Length > 0 && currentRcon != null)
            {
                RCON_Response Request = currentRcon.rconQuery(rconCommandBox.Text.Trim());
                queryUserFeedback(Request);
                rconCommandBox.Text = String.Empty;
            }
        }

        private void playerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (playerListBox.SelectedItem != null)
                playerListContext.Show(Cursor.Position);
        }

        private void contextKick_Click(object sender, EventArgs e)
        {
            Player P = (Player)(playerListBox.SelectedItem);
            RCON_Response Request = currentRcon.rconQuery("kick \"" + P.Name + "\" \"You have been kicked by qRcon\".");
            queryUserFeedback(Request);
        }

        private void updateConsoleOutput(String Text, params object [] args)
        {
            rconCommandResponse.AppendText(String.Format(Text, args) + "\r\n");
            rconCommandResponse.SelectionStart = rconCommandResponse.Text.Length - 2;
            rconCommandResponse.ScrollToCaret();
        }

        private void queryUserFeedback(RCON_Response Request)
        {
            if (Request.Success)
            {
                if (Request.Response.Description != "")
                    updateConsoleOutput("=== {0} ===\r\nCurrent: {1}\r\nDefault: {2}\r\n{3}", Request.Response.valueName, Request.Response.Value, Request.Response.defaultValue, Request.Response.Description);
                else
                    updateConsoleOutput(Request.Response.Value);
            }
            else
                updateConsoleOutput("Unable to complete rcon request: " + Request.Error);
        }

        private void populateMapList()
        {
            if (currentServer != null)
            {
                this.mapSelectionBox.Items.Clear();
                foreach (Map M in currentServer.MapList)
                    this.mapSelectionBox.Items.Add(M);
            }

        }

        private void populateGametypeList()
        {
            if (currentServer != null)
            {
                this.gametypeSelectionBox.Items.Clear();
                foreach (Gametype G in currentServer.gametypeList)
                    this.gametypeSelectionBox.Items.Add(G);
            }
        }

        private void rconCommandBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextKick_MouseEnter(object sender, EventArgs e)
        {
            contextKick.ForeColor = Color.Black;
        }

        private void contextKick_MouseLeave(object sender, EventArgs e)
        {
            contextKick.ForeColor = Color.LightGray;
        }

        private void contextTempBan_MouseEnter(object sender, EventArgs e)
        {
            contextTempBan.ForeColor = Color.Black;
        }

        private void contextTempBan_MouseLeave(object sender, EventArgs e)
        {
            contextTempBan.ForeColor = Color.LightGray;
        }

        private void rconCommandBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.rconCommandSubmit_Click(sender, e);
        }

        private void mapRotateButton_Click(object sender, EventArgs e)
        {
            if (currentRcon != null)
                queryUserFeedback(currentRcon.rconQuery("map_rotate"));
        }

        private void fastRestartButton_Click(object sender, EventArgs e)
        {
            if (currentRcon != null)
                queryUserFeedback(currentRcon.rconQuery("fast_restart"));
        }

        private void mapRestartButton_Click(object sender, EventArgs e)
        {
            if (currentRcon != null)
                queryUserFeedback(currentRcon.rconQuery("map_restart"));
        }

        private void clientInfoContext_MouseEnter(object sender, EventArgs e)
        {
            clientInfoContext.ForeColor = Color.Black;
        }

        private void clientInfoContext_MouseLeave(object sender, EventArgs e)
        {
            clientInfoContext.ForeColor = Color.LightGray;
        }

        private void clientInfoContext_Click(object sender, EventArgs e)
        {
            Player P = (Player)playerListBox.SelectedItem;
            clientInfoPopup newPopup = new clientInfoPopup(currentRcon.dumpUser(P.Name), P.Name);
            newPopup.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (currentRcon != null)
                getServerInfo(currentRcon);
        }

        private void killServerButton_Click(object sender, EventArgs e)
        {
            if (currentRcon != null)
                queryUserFeedback(currentRcon.rconQuery("quit"));
        }

        private void setSettingsButton_Click(object sender, EventArgs e)
        {
            if (currentRcon == null)
                return;

            List<String> rconCommands = new List<String>();
            String newMap = String.Empty;

            if (timeLimitBox.Text.Length > 0)
            {
                int timeLimit = -1;
                if (Int32.TryParse(timeLimitBox.Text, out timeLimit))
                    rconCommands.Add("scr_" + currentServer.Gametype + "_timelimit " + timeLimit);
                else
                    updateConsoleOutput("Ignoring invalid entry \"{0}\" for timelimit", timeLimitBox.Text);
            }

            if (modBox.Text.Length > 0)
                rconCommands.Add("fs_game \"mods/" + modBox.Text + "\"");

            if (passwordBox.Text.Length > 0)
                rconCommands.Add("g_password \"" + passwordBox.Text + "\"");

            if (gametypeSelectionBox.SelectedItem != null)
            {
                Gametype Selected =  (Gametype)gametypeSelectionBox.SelectedItem;
                rconCommands.Add("g_gametype \"" + Selected.Name + "\"");
            }

            if (mapSelectionBox.SelectedItem != null)
            {
                Map desiredMap = (Map)mapSelectionBox.SelectedItem;
                newMap = desiredMap.Name;
            }

            if (ffCheckBox.Checked)
                rconCommands.Add("scr_team_fftype 2");
            else
                rconCommands.Add("scr_team_fftype 0");

            if (hardcoreCheckBox.Checked)
                rconCommands.Add("g_hardcore 1");
            else
                rconCommands.Add("g_hardcore 0");

            foreach(String Command in rconCommands)
            {
                RCON_Response Request = currentRcon.rconQuery(Command);
                queryUserFeedback(Request);
                Thread.Sleep(100);
            }

            if (newMap == String.Empty)
                currentRcon.rconQuery("fast_restart");
            else
                currentRcon.rconQuery("map \"" + newMap + "\"");

            updateConsoleOutput("Finished applying game settings.");
        }
    }
}
