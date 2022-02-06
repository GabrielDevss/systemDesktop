using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuClient_Click(object sender, EventArgs e)
        {
            FrmSelectedClient frmSelectedClient = new FrmSelectedClient();

            frmSelectedClient.MdiParent = this;
            frmSelectedClient.Show();
        }
    }
}
