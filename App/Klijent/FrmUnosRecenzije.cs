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
    public partial class FrmUnosRecenzije : Form
    {
        KUnosRecenzije kontroler;
        public FrmUnosRecenzije()
        {
            InitializeComponent();
            //kontroler = new KUnosRecenzije(this);
        }

        private void FrmUnosRecenzije_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbUloge, groupBox1, groupBox2, btnPotvrdiKurs, cmbKursevi, lblKorisnik, dataGridView1);
        }

        private void btnKurs_Click(object sender, EventArgs e)
        {
            kontroler.srediFormu2(groupBox2, cmbUloge, cmbKursevi, groupBox1, btnPotvrdiKurs);
        }

        private void btnPotvrdiUlogu_Click(object sender, EventArgs e)
        {
            kontroler.UbaciRecenzijuUloge(cmbUloge, txtRecenzijaUloge, cmbKursevi);
        }

        private void btnObrisiRecenzijuUloge_Click(object sender, EventArgs e)
        {
            kontroler.obrisiRecenzijuUloge(dataGridView1);
        }

        private void btnPotvrdiKurs_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.dodajRecenziju(txtRecenzijaKursa, cmbKursevi );
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
