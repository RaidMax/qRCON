using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace qRcon
{
    public partial class addServerDialog : Form
    {
        public addServerDialog()
        {
            InitializeComponent();
        }

        private void serverAddOk_Click(object sender, EventArgs e)
        {
			ushort Port = 0;
            if (serverIPBox.Text.Length == 0 || serverPortBox.Text.Length == 0 || serverPasswordBox.Text.Length == 0)
                MessageBox.Show("Please enter all fields.");
			else if (serverPortBox.Text.Length > 0 && !ushort.TryParse (serverPortBox.Text, out Port))
				MessageBox.Show ("Port must be between 1 and " + ushort.MaxValue + ".");
            else
            {
                this.serverAddOk.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
