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
    public partial class clientInfoPopup : Form
    {
        public clientInfoPopup()
        {
            InitializeComponent();
        }

        public clientInfoPopup(Dictionary<String,String> clientInfo)
        {
            InitializeComponent();

            foreach (KeyValuePair<String, String> field in clientInfo)
            {
                this.clientInfoGrid.Rows.Add(field.Key, field.Value);
            }

        }

        private void clientInfoPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
