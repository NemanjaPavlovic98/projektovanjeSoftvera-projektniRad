using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.UserControls
{
    public partial class UCIzmenaBrisanjeKursa : UserControl
    {
        KBrisanjeIzmenaKursa kontroler;
        Panel panel;
        public UCIzmenaBrisanjeKursa(Panel panel)
        {
            InitializeComponent();
            kontroler = new KBrisanjeIzmenaKursa(this);
            this.panel = panel;
        }

        private void UCIzmenaBrisanjeKursa_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbKursevi, groupBox1);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.ObrisiKurs(cmbKursevi);
            if (uspelo)
            {
                panel.Controls.Clear();
            }
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
                panel.Controls.Clear();
            }
        }
    }
}
