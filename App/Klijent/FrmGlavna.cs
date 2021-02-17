using Domen;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmGlavna : Form
    {
        public static Korisnik k;
        KGlavnaForma kontoler;

        public FrmGlavna()
        {
            InitializeComponent();
            kontoler = new KGlavnaForma() ;
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            pnlSubmn.Visible = false;
            pnlSub2.Visible = false;

            SetPanel(new DashboardScreen());
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if(pnlSub2.Visible == false)
            {
                pnlSub2.Visible = true;
            }
            else
            {
                pnlSub2.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pnlSubmn.Visible == false)
            {
                pnlSubmn.Visible = true;
            }
            else
            {
                pnlSubmn.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //kontoler.OdjaviSe();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaRecenziju(mainPnl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        internal void SetPanel(UserControl userControl)
        {
            mainPnl.Controls.Clear();
            userControl.Parent = mainPnl;
            userControl.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaUnosKursa(mainPnl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaIzmenuBrisanjeKursa(mainPnl);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaUnos(mainPnl);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            kontoler.OtvoriZaIzmenuiBrisnaje(mainPnl);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           SetPanel(new DashboardScreen());
        }

        private void mainPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
