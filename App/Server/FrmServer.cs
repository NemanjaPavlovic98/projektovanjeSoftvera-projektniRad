using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            lblStanje.Text = "Server nije pokrenut";
            server = new Server(this);
        }

        private void btnPokreni_Click_2(object sender, EventArgs e)
        {
            if (server.Pokreni())
            {
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                lblStanje.Text = "Server je pokrenut";

            }
            else
            {
                MessageBox.Show("Nuspesno pokretanje servera");
            }
        }

        private void btnZaustavi_Click_2(object sender, EventArgs e)
        {
            if (server.Zaustavi())
            {
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
                lblStanje.Text = "Server nije pokrenut";
            }
            else
            {
                MessageBox.Show("Neuspesno zaustavljanje servera");
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
