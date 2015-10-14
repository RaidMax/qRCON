namespace qRcon
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.savedServers = new System.Windows.Forms.ListBox();
            this.loadSavedServer = new System.Windows.Forms.Button();
            this.deleteSavedServer = new System.Windows.Forms.Button();
            this.addSavedServer = new System.Windows.Forms.Button();
            this.editSavedServer = new System.Windows.Forms.Button();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.playersLabel = new System.Windows.Forms.Label();
            this.gametypeLabel = new System.Windows.Forms.Label();
            this.modLabel = new System.Windows.Forms.Label();
            this.rconCommandBox = new System.Windows.Forms.TextBox();
            this.rconCommandSubmit = new System.Windows.Forms.Button();
            this.rconCommandResponse = new System.Windows.Forms.RichTextBox();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.playerListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextKick = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTempBan = new System.Windows.Forms.ToolStripMenuItem();
            this.clientInfoContext = new System.Windows.Forms.ToolStripMenuItem();
            this.serverMapLabel = new System.Windows.Forms.Label();
            this.mapRotateButton = new System.Windows.Forms.Button();
            this.fastRestartButton = new System.Windows.Forms.Button();
            this.mapRestartButton = new System.Windows.Forms.Button();
            this.timeLimitLabel = new System.Windows.Forms.Label();
            this.timeLimitBox = new System.Windows.Forms.TextBox();
            this.setSettingsButton = new System.Windows.Forms.Button();
            this.friendlyFireLabel = new System.Windows.Forms.Label();
            this.ffCheckBox = new System.Windows.Forms.CheckBox();
            this.modBox = new System.Windows.Forms.TextBox();
            this.modifcationLabel = new System.Windows.Forms.Label();
            this.gametypeChangeLabel = new System.Windows.Forms.Label();
            this.gametypeSelectionBox = new System.Windows.Forms.ComboBox();
            this.mapSelectionBox = new System.Windows.Forms.ComboBox();
            this.mapBoxLabel = new System.Windows.Forms.Label();
            this.hardcoreCheckBox = new System.Windows.Forms.CheckBox();
            this.hardcoreLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.killServerButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.playerListContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // savedServers
            // 
            this.savedServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.savedServers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savedServers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.savedServers.FormattingEnabled = true;
            this.savedServers.ItemHeight = 17;
            this.savedServers.Location = new System.Drawing.Point(12, 9);
            this.savedServers.Name = "savedServers";
            this.savedServers.Size = new System.Drawing.Size(178, 138);
            this.savedServers.TabIndex = 0;
            // 
            // loadSavedServer
            // 
            this.loadSavedServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSavedServer.ForeColor = System.Drawing.Color.Gray;
            this.loadSavedServer.Location = new System.Drawing.Point(11, 206);
            this.loadSavedServer.Name = "loadSavedServer";
            this.loadSavedServer.Size = new System.Drawing.Size(90, 35);
            this.loadSavedServer.TabIndex = 1;
            this.loadSavedServer.Text = "Load";
            this.loadSavedServer.UseVisualStyleBackColor = true;
            this.loadSavedServer.Click += new System.EventHandler(this.loadSavedServer_Click);
            // 
            // deleteSavedServer
            // 
            this.deleteSavedServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSavedServer.ForeColor = System.Drawing.Color.Gray;
            this.deleteSavedServer.Location = new System.Drawing.Point(108, 165);
            this.deleteSavedServer.Name = "deleteSavedServer";
            this.deleteSavedServer.Size = new System.Drawing.Size(82, 35);
            this.deleteSavedServer.TabIndex = 2;
            this.deleteSavedServer.Text = "Remove";
            this.deleteSavedServer.UseVisualStyleBackColor = true;
            this.deleteSavedServer.Click += new System.EventHandler(this.deleteSavedServer_Click);
            // 
            // addSavedServer
            // 
            this.addSavedServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSavedServer.ForeColor = System.Drawing.Color.Gray;
            this.addSavedServer.Location = new System.Drawing.Point(12, 165);
            this.addSavedServer.Name = "addSavedServer";
            this.addSavedServer.Size = new System.Drawing.Size(89, 35);
            this.addSavedServer.TabIndex = 3;
            this.addSavedServer.Text = "Add";
            this.addSavedServer.UseVisualStyleBackColor = true;
            this.addSavedServer.Click += new System.EventHandler(this.addSavedServer_Click);
            // 
            // editSavedServer
            // 
            this.editSavedServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSavedServer.ForeColor = System.Drawing.Color.Gray;
            this.editSavedServer.Location = new System.Drawing.Point(108, 206);
            this.editSavedServer.Name = "editSavedServer";
            this.editSavedServer.Size = new System.Drawing.Size(82, 35);
            this.editSavedServer.TabIndex = 4;
            this.editSavedServer.Text = "Edit";
            this.editSavedServer.UseVisualStyleBackColor = true;
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostnameLabel.Location = new System.Drawing.Point(197, 9);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(775, 86);
            this.hostnameLabel.TabIndex = 5;
            this.hostnameLabel.Text = "HOSTNAME";
            // 
            // playersLabel
            // 
            this.playersLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersLabel.Location = new System.Drawing.Point(203, 191);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(116, 50);
            this.playersLabel.TabIndex = 6;
            this.playersLabel.Text = "0/0";
            // 
            // gametypeLabel
            // 
            this.gametypeLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gametypeLabel.Location = new System.Drawing.Point(203, 95);
            this.gametypeLabel.Name = "gametypeLabel";
            this.gametypeLabel.Size = new System.Drawing.Size(582, 50);
            this.gametypeLabel.TabIndex = 7;
            this.gametypeLabel.Text = "GAMETYPE";
            // 
            // modLabel
            // 
            this.modLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modLabel.Location = new System.Drawing.Point(595, 95);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(377, 50);
            this.modLabel.TabIndex = 8;
            this.modLabel.Text = "MOD";
            // 
            // rconCommandBox
            // 
            this.rconCommandBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rconCommandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rconCommandBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rconCommandBox.Location = new System.Drawing.Point(8, 575);
            this.rconCommandBox.Name = "rconCommandBox";
            this.rconCommandBox.Size = new System.Drawing.Size(700, 25);
            this.rconCommandBox.TabIndex = 9;
            this.rconCommandBox.TextChanged += new System.EventHandler(this.rconCommandBox_TextChanged);
            this.rconCommandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rconCommandBox_KeyDown);
            // 
            // rconCommandSubmit
            // 
            this.rconCommandSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rconCommandSubmit.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rconCommandSubmit.ForeColor = System.Drawing.Color.Gray;
            this.rconCommandSubmit.Location = new System.Drawing.Point(718, 573);
            this.rconCommandSubmit.Name = "rconCommandSubmit";
            this.rconCommandSubmit.Size = new System.Drawing.Size(67, 29);
            this.rconCommandSubmit.TabIndex = 10;
            this.rconCommandSubmit.Text = ">";
            this.rconCommandSubmit.UseVisualStyleBackColor = false;
            this.rconCommandSubmit.Click += new System.EventHandler(this.rconCommandSubmit_Click);
            // 
            // rconCommandResponse
            // 
            this.rconCommandResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rconCommandResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rconCommandResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.rconCommandResponse.Location = new System.Drawing.Point(8, 382);
            this.rconCommandResponse.Name = "rconCommandResponse";
            this.rconCommandResponse.ReadOnly = true;
            this.rconCommandResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rconCommandResponse.Size = new System.Drawing.Size(778, 185);
            this.rconCommandResponse.TabIndex = 11;
            this.rconCommandResponse.Text = "";
            // 
            // playerListBox
            // 
            this.playerListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.playerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 17;
            this.playerListBox.Location = new System.Drawing.Point(794, 382);
            this.playerListBox.Margin = new System.Windows.Forms.Padding(0);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(181, 204);
            this.playerListBox.Sorted = true;
            this.playerListBox.TabIndex = 12;
            this.playerListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playerListBox_MouseDoubleClick);
            // 
            // playerListContext
            // 
            this.playerListContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.playerListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextKick,
            this.contextTempBan,
            this.clientInfoContext});
            this.playerListContext.Name = "playerListContext";
            this.playerListContext.Size = new System.Drawing.Size(130, 70);
            // 
            // contextKick
            // 
            this.contextKick.BackgroundImage = global::qRcon.Properties.Resources.bg;
            this.contextKick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.contextKick.Name = "contextKick";
            this.contextKick.Size = new System.Drawing.Size(129, 22);
            this.contextKick.Text = "Kick";
            this.contextKick.Click += new System.EventHandler(this.contextKick_Click);
            this.contextKick.MouseEnter += new System.EventHandler(this.contextKick_MouseEnter);
            this.contextKick.MouseLeave += new System.EventHandler(this.contextKick_MouseLeave);
            // 
            // contextTempBan
            // 
            this.contextTempBan.BackgroundImage = global::qRcon.Properties.Resources.bg;
            this.contextTempBan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contextTempBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.contextTempBan.Name = "contextTempBan";
            this.contextTempBan.Size = new System.Drawing.Size(129, 22);
            this.contextTempBan.Text = "Temp Ban";
            this.contextTempBan.MouseEnter += new System.EventHandler(this.contextTempBan_MouseEnter);
            this.contextTempBan.MouseLeave += new System.EventHandler(this.contextTempBan_MouseLeave);
            // 
            // clientInfoContext
            // 
            this.clientInfoContext.BackgroundImage = global::qRcon.Properties.Resources.bg;
            this.clientInfoContext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.clientInfoContext.Name = "clientInfoContext";
            this.clientInfoContext.Size = new System.Drawing.Size(129, 22);
            this.clientInfoContext.Text = "Client Info";
            this.clientInfoContext.Click += new System.EventHandler(this.clientInfoContext_Click);
            this.clientInfoContext.MouseEnter += new System.EventHandler(this.clientInfoContext_MouseEnter);
            this.clientInfoContext.MouseLeave += new System.EventHandler(this.clientInfoContext_MouseLeave);
            // 
            // serverMapLabel
            // 
            this.serverMapLabel.AutoSize = true;
            this.serverMapLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverMapLabel.Location = new System.Drawing.Point(203, 145);
            this.serverMapLabel.Name = "serverMapLabel";
            this.serverMapLabel.Size = new System.Drawing.Size(204, 50);
            this.serverMapLabel.TabIndex = 13;
            this.serverMapLabel.Text = "MAPNAME";
            // 
            // mapRotateButton
            // 
            this.mapRotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapRotateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.mapRotateButton.Location = new System.Drawing.Point(863, 185);
            this.mapRotateButton.Name = "mapRotateButton";
            this.mapRotateButton.Size = new System.Drawing.Size(109, 34);
            this.mapRotateButton.TabIndex = 14;
            this.mapRotateButton.Text = "Map Rotate";
            this.mapRotateButton.UseVisualStyleBackColor = true;
            this.mapRotateButton.Click += new System.EventHandler(this.mapRotateButton_Click);
            // 
            // fastRestartButton
            // 
            this.fastRestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastRestartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fastRestartButton.Location = new System.Drawing.Point(863, 267);
            this.fastRestartButton.Name = "fastRestartButton";
            this.fastRestartButton.Size = new System.Drawing.Size(109, 34);
            this.fastRestartButton.TabIndex = 15;
            this.fastRestartButton.Text = "Fast Restart";
            this.fastRestartButton.UseVisualStyleBackColor = true;
            this.fastRestartButton.Click += new System.EventHandler(this.fastRestartButton_Click);
            // 
            // mapRestartButton
            // 
            this.mapRestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapRestartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.mapRestartButton.Location = new System.Drawing.Point(863, 227);
            this.mapRestartButton.Name = "mapRestartButton";
            this.mapRestartButton.Size = new System.Drawing.Size(109, 34);
            this.mapRestartButton.TabIndex = 16;
            this.mapRestartButton.Text = "Map Restart";
            this.mapRestartButton.UseVisualStyleBackColor = true;
            this.mapRestartButton.Click += new System.EventHandler(this.mapRestartButton_Click);
            // 
            // timeLimitLabel
            // 
            this.timeLimitLabel.AutoSize = true;
            this.timeLimitLabel.Location = new System.Drawing.Point(7, 312);
            this.timeLimitLabel.Name = "timeLimitLabel";
            this.timeLimitLabel.Size = new System.Drawing.Size(72, 19);
            this.timeLimitLabel.TabIndex = 17;
            this.timeLimitLabel.Text = "Time Limit";
            // 
            // timeLimitBox
            // 
            this.timeLimitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.timeLimitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLimitBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.timeLimitBox.Location = new System.Drawing.Point(11, 336);
            this.timeLimitBox.MaxLength = 6;
            this.timeLimitBox.Name = "timeLimitBox";
            this.timeLimitBox.Size = new System.Drawing.Size(79, 25);
            this.timeLimitBox.TabIndex = 18;
            // 
            // setSettingsButton
            // 
            this.setSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.setSettingsButton.Location = new System.Drawing.Point(863, 331);
            this.setSettingsButton.Name = "setSettingsButton";
            this.setSettingsButton.Size = new System.Drawing.Size(109, 34);
            this.setSettingsButton.TabIndex = 19;
            this.setSettingsButton.Text = "Set";
            this.setSettingsButton.UseVisualStyleBackColor = true;
            this.setSettingsButton.Click += new System.EventHandler(this.setSettingsButton_Click);
            // 
            // friendlyFireLabel
            // 
            this.friendlyFireLabel.AutoSize = true;
            this.friendlyFireLabel.Location = new System.Drawing.Point(787, 313);
            this.friendlyFireLabel.Name = "friendlyFireLabel";
            this.friendlyFireLabel.Size = new System.Drawing.Size(23, 19);
            this.friendlyFireLabel.TabIndex = 20;
            this.friendlyFireLabel.Text = "FF";
            // 
            // ffCheckBox
            // 
            this.ffCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ffCheckBox.Location = new System.Drawing.Point(791, 338);
            this.ffCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.ffCheckBox.Name = "ffCheckBox";
            this.ffCheckBox.Size = new System.Drawing.Size(22, 29);
            this.ffCheckBox.TabIndex = 21;
            this.ffCheckBox.UseVisualStyleBackColor = true;
            // 
            // modBox
            // 
            this.modBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.modBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.modBox.Location = new System.Drawing.Point(96, 336);
            this.modBox.MaxLength = 6;
            this.modBox.Name = "modBox";
            this.modBox.Size = new System.Drawing.Size(149, 25);
            this.modBox.TabIndex = 23;
            // 
            // modifcationLabel
            // 
            this.modifcationLabel.AutoSize = true;
            this.modifcationLabel.Location = new System.Drawing.Point(148, 312);
            this.modifcationLabel.Name = "modifcationLabel";
            this.modifcationLabel.Size = new System.Drawing.Size(38, 19);
            this.modifcationLabel.TabIndex = 22;
            this.modifcationLabel.Text = "Mod";
            // 
            // gametypeChangeLabel
            // 
            this.gametypeChangeLabel.AutoSize = true;
            this.gametypeChangeLabel.Location = new System.Drawing.Point(462, 314);
            this.gametypeChangeLabel.Name = "gametypeChangeLabel";
            this.gametypeChangeLabel.Size = new System.Drawing.Size(72, 19);
            this.gametypeChangeLabel.TabIndex = 24;
            this.gametypeChangeLabel.Text = "Gametype";
            // 
            // gametypeSelectionBox
            // 
            this.gametypeSelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gametypeSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gametypeSelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gametypeSelectionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gametypeSelectionBox.FormattingEnabled = true;
            this.gametypeSelectionBox.Location = new System.Drawing.Point(406, 337);
            this.gametypeSelectionBox.Name = "gametypeSelectionBox";
            this.gametypeSelectionBox.Size = new System.Drawing.Size(181, 25);
            this.gametypeSelectionBox.TabIndex = 25;
            // 
            // mapSelectionBox
            // 
            this.mapSelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mapSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapSelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapSelectionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.mapSelectionBox.FormattingEnabled = true;
            this.mapSelectionBox.Location = new System.Drawing.Point(593, 337);
            this.mapSelectionBox.Name = "mapSelectionBox";
            this.mapSelectionBox.Size = new System.Drawing.Size(181, 25);
            this.mapSelectionBox.TabIndex = 27;
            // 
            // mapBoxLabel
            // 
            this.mapBoxLabel.AutoSize = true;
            this.mapBoxLabel.Location = new System.Drawing.Point(669, 314);
            this.mapBoxLabel.Name = "mapBoxLabel";
            this.mapBoxLabel.Size = new System.Drawing.Size(37, 19);
            this.mapBoxLabel.TabIndex = 26;
            this.mapBoxLabel.Text = "Map";
            // 
            // hardcoreCheckBox
            // 
            this.hardcoreCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardcoreCheckBox.Location = new System.Drawing.Point(828, 338);
            this.hardcoreCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.hardcoreCheckBox.Name = "hardcoreCheckBox";
            this.hardcoreCheckBox.Size = new System.Drawing.Size(22, 29);
            this.hardcoreCheckBox.TabIndex = 29;
            this.hardcoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // hardcoreLabel
            // 
            this.hardcoreLabel.AutoSize = true;
            this.hardcoreLabel.Location = new System.Drawing.Point(819, 313);
            this.hardcoreLabel.Name = "hardcoreLabel";
            this.hardcoreLabel.Size = new System.Drawing.Size(28, 19);
            this.hardcoreLabel.TabIndex = 28;
            this.hardcoreLabel.Text = "HC";
            // 
            // refreshButton
            // 
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.refreshButton.Location = new System.Drawing.Point(748, 185);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(109, 34);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // killServerButton
            // 
            this.killServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.killServerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.killServerButton.Location = new System.Drawing.Point(748, 267);
            this.killServerButton.Name = "killServerButton";
            this.killServerButton.Size = new System.Drawing.Size(109, 34);
            this.killServerButton.TabIndex = 31;
            this.killServerButton.Text = "Kill Server";
            this.killServerButton.UseVisualStyleBackColor = true;
            this.killServerButton.Click += new System.EventHandler(this.killServerButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordBox.Location = new System.Drawing.Point(251, 337);
            this.passwordBox.MaxLength = 32;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(149, 25);
            this.passwordBox.TabIndex = 33;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(288, 312);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 19);
            this.passwordLabel.TabIndex = 32;
            this.passwordLabel.Text = "Password";
            // 
            // mainWindow
            // 
            this.AcceptButton = this.rconCommandSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.killServerButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.hardcoreCheckBox);
            this.Controls.Add(this.hardcoreLabel);
            this.Controls.Add(this.mapSelectionBox);
            this.Controls.Add(this.mapBoxLabel);
            this.Controls.Add(this.gametypeSelectionBox);
            this.Controls.Add(this.gametypeChangeLabel);
            this.Controls.Add(this.modBox);
            this.Controls.Add(this.modifcationLabel);
            this.Controls.Add(this.ffCheckBox);
            this.Controls.Add(this.friendlyFireLabel);
            this.Controls.Add(this.setSettingsButton);
            this.Controls.Add(this.timeLimitBox);
            this.Controls.Add(this.timeLimitLabel);
            this.Controls.Add(this.mapRestartButton);
            this.Controls.Add(this.fastRestartButton);
            this.Controls.Add(this.mapRotateButton);
            this.Controls.Add(this.serverMapLabel);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.rconCommandResponse);
            this.Controls.Add(this.rconCommandSubmit);
            this.Controls.Add(this.rconCommandBox);
            this.Controls.Add(this.modLabel);
            this.Controls.Add(this.gametypeLabel);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.hostnameLabel);
            this.Controls.Add(this.editSavedServer);
            this.Controls.Add(this.addSavedServer);
            this.Controls.Add(this.deleteSavedServer);
            this.Controls.Add(this.loadSavedServer);
            this.Controls.Add(this.savedServers);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainWindow";
            this.Text = "qRcon";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.playerListContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox savedServers;
        private System.Windows.Forms.Button loadSavedServer;
        private System.Windows.Forms.Button deleteSavedServer;
        private System.Windows.Forms.Button addSavedServer;
        private System.Windows.Forms.Button editSavedServer;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label gametypeLabel;
        private System.Windows.Forms.Label modLabel;
        private System.Windows.Forms.TextBox rconCommandBox;
        private System.Windows.Forms.Button rconCommandSubmit;
        public System.Windows.Forms.RichTextBox rconCommandResponse;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.ContextMenuStrip playerListContext;
        private System.Windows.Forms.ToolStripMenuItem contextKick;
        private System.Windows.Forms.ToolStripMenuItem contextTempBan;
        private System.Windows.Forms.Label serverMapLabel;
        private System.Windows.Forms.Button mapRotateButton;
        private System.Windows.Forms.Button fastRestartButton;
        private System.Windows.Forms.Button mapRestartButton;
        private System.Windows.Forms.Label timeLimitLabel;
        private System.Windows.Forms.TextBox timeLimitBox;
        private System.Windows.Forms.Button setSettingsButton;
        private System.Windows.Forms.Label friendlyFireLabel;
        private System.Windows.Forms.CheckBox ffCheckBox;
        private System.Windows.Forms.TextBox modBox;
        private System.Windows.Forms.Label modifcationLabel;
        private System.Windows.Forms.Label gametypeChangeLabel;
        private System.Windows.Forms.ComboBox gametypeSelectionBox;
        private System.Windows.Forms.ComboBox mapSelectionBox;
        private System.Windows.Forms.Label mapBoxLabel;
        private System.Windows.Forms.CheckBox hardcoreCheckBox;
        private System.Windows.Forms.Label hardcoreLabel;
        private System.Windows.Forms.ToolStripMenuItem clientInfoContext;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button killServerButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;

    }
}

