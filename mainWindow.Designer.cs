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
            this.serverMapLabel = new System.Windows.Forms.Label();
            this.playerListContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // savedServers
            // 
            this.savedServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.savedServers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savedServers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.savedServers.FormattingEnabled = true;
            this.savedServers.ItemHeight = 21;
            this.savedServers.Location = new System.Drawing.Point(12, 9);
            this.savedServers.Name = "savedServers";
            this.savedServers.Size = new System.Drawing.Size(178, 149);
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
            this.hostnameLabel.Text = "SV_HOSTNAME";
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
            this.rconCommandBox.Location = new System.Drawing.Point(12, 570);
            this.rconCommandBox.Name = "rconCommandBox";
            this.rconCommandBox.Size = new System.Drawing.Size(700, 29);
            this.rconCommandBox.TabIndex = 9;
            this.rconCommandBox.TextChanged += new System.EventHandler(this.rconCommandBox_TextChanged);
            this.rconCommandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rconCommandBox_KeyDown);
            // 
            // rconCommandSubmit
            // 
            this.rconCommandSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rconCommandSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rconCommandSubmit.ForeColor = System.Drawing.Color.Gray;
            this.rconCommandSubmit.Location = new System.Drawing.Point(718, 570);
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
            this.rconCommandResponse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rconCommandResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.rconCommandResponse.Location = new System.Drawing.Point(12, 389);
            this.rconCommandResponse.Name = "rconCommandResponse";
            this.rconCommandResponse.ReadOnly = true;
            this.rconCommandResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rconCommandResponse.Size = new System.Drawing.Size(773, 175);
            this.rconCommandResponse.TabIndex = 11;
            this.rconCommandResponse.Text = "";
            // 
            // playerListBox
            // 
            this.playerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.playerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 21;
            this.playerListBox.Location = new System.Drawing.Point(791, 389);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(181, 210);
            this.playerListBox.Sorted = true;
            this.playerListBox.TabIndex = 12;
            this.playerListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playerListBox_MouseDoubleClick);
            // 
            // playerListContext
            // 
            this.playerListContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.playerListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextKick,
            this.contextTempBan});
            this.playerListContext.Name = "playerListContext";
            this.playerListContext.Size = new System.Drawing.Size(128, 48);
            // 
            // contextKick
            // 
            this.contextKick.BackgroundImage = global::qRcon.Properties.Resources.bg;
            this.contextKick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.contextKick.Name = "contextKick";
            this.contextKick.Size = new System.Drawing.Size(127, 22);
            this.contextKick.Text = "Kick";
            this.contextKick.Click += new System.EventHandler(this.contextKick_Click);
            this.contextKick.MouseEnter += new System.EventHandler(this.contextKick_MouseEnter);
            this.contextKick.MouseLeave += new System.EventHandler(this.contextKick_MouseLeave);
            // 
            // contextTempBan
            // 
            this.contextTempBan.BackgroundImage = global::qRcon.Properties.Resources.bg;
            this.contextTempBan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.contextTempBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.contextTempBan.Name = "contextTempBan";
            this.contextTempBan.Size = new System.Drawing.Size(127, 22);
            this.contextTempBan.Text = "Temp Ban";
            this.contextTempBan.MouseEnter += new System.EventHandler(this.contextTempBan_MouseEnter);
            this.contextTempBan.MouseLeave += new System.EventHandler(this.contextTempBan_MouseLeave);
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
            // mainWindow
            // 
            this.AcceptButton = this.rconCommandSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
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
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

    }
}

