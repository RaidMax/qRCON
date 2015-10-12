namespace qRcon
{
    partial class addServerDialog
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
            this.serverIPLabel = new System.Windows.Forms.Label();
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.serverPasswordBox = new System.Windows.Forms.TextBox();
            this.serverPasswordLabel = new System.Windows.Forms.Label();
            this.serverAddOk = new System.Windows.Forms.Button();
            this.serverAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.AutoSize = true;
            this.serverIPLabel.Location = new System.Drawing.Point(13, 13);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(51, 13);
            this.serverIPLabel.TabIndex = 0;
            this.serverIPLabel.Text = "Server IP";
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(16, 30);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(204, 20);
            this.serverIPBox.TabIndex = 1;
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(16, 70);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(204, 20);
            this.serverPortBox.TabIndex = 3;
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Location = new System.Drawing.Point(13, 53);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Size = new System.Drawing.Size(60, 13);
            this.serverPortLabel.TabIndex = 2;
            this.serverPortLabel.Text = "Server Port";
            // 
            // serverPasswordBox
            // 
            this.serverPasswordBox.Location = new System.Drawing.Point(16, 110);
            this.serverPasswordBox.Name = "serverPasswordBox";
            this.serverPasswordBox.Size = new System.Drawing.Size(204, 20);
            this.serverPasswordBox.TabIndex = 5;
            // 
            // serverPasswordLabel
            // 
            this.serverPasswordLabel.AutoSize = true;
            this.serverPasswordLabel.Location = new System.Drawing.Point(13, 93);
            this.serverPasswordLabel.Name = "serverPasswordLabel";
            this.serverPasswordLabel.Size = new System.Drawing.Size(87, 13);
            this.serverPasswordLabel.TabIndex = 4;
            this.serverPasswordLabel.Text = "Server Password";
            // 
            // serverAddOk
            // 
            this.serverAddOk.Location = new System.Drawing.Point(16, 138);
            this.serverAddOk.Name = "serverAddOk";
            this.serverAddOk.Size = new System.Drawing.Size(84, 23);
            this.serverAddOk.TabIndex = 6;
            this.serverAddOk.Text = "Add";
            this.serverAddOk.UseVisualStyleBackColor = true;
            this.serverAddOk.Click += new System.EventHandler(this.serverAddOk_Click);
            // 
            // serverAddCancel
            // 
            this.serverAddCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.serverAddCancel.Location = new System.Drawing.Point(136, 138);
            this.serverAddCancel.Name = "serverAddCancel";
            this.serverAddCancel.Size = new System.Drawing.Size(84, 23);
            this.serverAddCancel.TabIndex = 7;
            this.serverAddCancel.Text = "Cancel";
            this.serverAddCancel.UseVisualStyleBackColor = true;
            // 
            // addServerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 173);
            this.Controls.Add(this.serverAddCancel);
            this.Controls.Add(this.serverAddOk);
            this.Controls.Add(this.serverPasswordBox);
            this.Controls.Add(this.serverPasswordLabel);
            this.Controls.Add(this.serverPortBox);
            this.Controls.Add(this.serverPortLabel);
            this.Controls.Add(this.serverIPBox);
            this.Controls.Add(this.serverIPLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addServerDialog";
            this.Text = "Add/Edit Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverIPLabel;
        public System.Windows.Forms.TextBox serverIPBox;
        public System.Windows.Forms.TextBox serverPortBox;
        private System.Windows.Forms.Label serverPortLabel;
        public System.Windows.Forms.TextBox serverPasswordBox;
        private System.Windows.Forms.Label serverPasswordLabel;
        private System.Windows.Forms.Button serverAddOk;
        private System.Windows.Forms.Button serverAddCancel;

    }
}