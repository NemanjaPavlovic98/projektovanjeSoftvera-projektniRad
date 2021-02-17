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
    public partial class FrmBrisanjeIzmenaKursa : Form
    {
        KBrisanjeIzmenaKursa kontroler;

        public FrmBrisanjeIzmenaKursa()
        {
            InitializeComponent();
            //kontroler = new KBrisanjeIzmenaKursa(this);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.ObrisiKurs(cmbKursevi);
            if (uspelo)
            {
                this.Close();
            }
        }

        private void FrmBrisanjeIzmenaKursa_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbKursevi, groupBox1);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            MessageBox.Show("Sistem je pronasao kurs");
        }

        private void btnPotvrdiIzmenu_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.IzmeniKurs(cmbKursevi, txtNaziv, txtProvajder, txtMinutaza, txtOpis, txtOcena, txtCena);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
