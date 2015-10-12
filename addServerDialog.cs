using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            if (serverIPBox.Text.Length == 0 || serverPortBox.Text.Length == 0 || serverPasswordBox.Text.Length == 0)
                MessageBox.Show("Please enter all fields.");
            else
            {
                this.serverAddOk.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
