using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace qRcon
{
    public partial class mainWindow : Form
    {
        RCON currentServer;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            foreach(RCON R in Serialize.loadSavedServers())
            {
                this.savedServers.Items.Add(R);
            }  
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
                currentServer = test;
                getServerInfo(test);
            }
        }
        
        private void refreshServerInfo(Server S)
        {
            this.hostnameLabel.Text = S.Hostname;
            this.gametypeLabel.Text = S.Gametype;
            this.modLabel.Text = S.Mod;
            this.playersLabel.Text = S.currentPlayers + "/" + S.maxPlayers;
            this.serverMapLabel.Text = S.Map;
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
            RCON_Response maxPlayers = R.rconQuery("party_maxplayers");
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
            }

            else
            {
                updateConsoleOutput("[0ms] Could not update server info. Error: " + maxPlayers.Error + " & " + fs_game.Error + ".");
            }
        }

        private void rconCommandSubmit_Click(object sender, EventArgs e)
        {
            if(rconCommandBox.Text.Length > 0 && currentServer != null)
            {
                RCON_Response Request = currentServer.rconQuery(rconCommandBox.Text.Trim());

                if (!Request.Success)
                    updateConsoleOutput("[0ms] Unable to complete rcon request: " + Request.Error);
                else if (Request.Response.Description != "")
                    updateConsoleOutput("=== {0} ===\r\nCurrent: {1}\r\nDefault: {2}\r\n{3}", Request.Response.valueName, Request.Response.Value, Request.Response.defaultValue, Request.Response.Description);
                else
                    updateConsoleOutput("[" + Request.responseTime + "ms] " + Request.Response.Value);
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
            RCON_Response Request = currentServer.rconQuery("kick " + P.Name + " You have been kicked by qRcon.");
            if (Request.Success)
                updateConsoleOutput("[" + Request.responseTime + "ms] " + Request.Response.Value);
            else
                updateConsoleOutput("[0ms] Unable to complete rcon request: " + Request.Error );
        }

        private void updateConsoleOutput(String Text, params object [] args)
        {
            rconCommandResponse.AppendText(String.Format(Text, args) + "\r\n");
            rconCommandResponse.SelectionStart = rconCommandResponse.Text.Length - 2;
            rconCommandResponse.ScrollToCaret();
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
    }
}
