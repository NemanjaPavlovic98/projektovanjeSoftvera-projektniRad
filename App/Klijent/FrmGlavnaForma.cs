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
    public partial class FrmGlavnaForma : Form
    {
        
        KGlavnaForma kontoler;
        public FrmGlavnaForma()
        {
            InitializeComponent();
            kontoler = new KGlavnaForma();
        }

        private void FrmGlavnaForma_Load(object sender, EventArgs e)
        {

        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaUnosKursa();
        }

        private void izmenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaIzmenuBrisanjeKursa();
        }

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // kontoler.OtvoriZaUnos();
        }

        private void izmenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaIzmenuiBrisnaje();
        }

        private void novaRecenzijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaRecenziju();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaUnosKursa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaIzmenuBrisanjeKursa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // kontoler.OtvoriZaUnos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaIzmenuiBrisnaje();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //kontoler.OtvoriZaRecenziju();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            //Komunikacija.Instance.Zavrsi();
            this.Close();
            new Login().Show();
        }
    }
}
