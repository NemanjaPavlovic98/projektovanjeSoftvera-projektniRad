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
    public partial class UCUnosKursa : UserControl
    {
        KUnosKursa kontroler;
        Panel panel;
        public UCUnosKursa(Panel panel)
        {
            InitializeComponent();
            kontroler = new KUnosKursa(this);
            this.panel = panel;
        }

        private void UCUnosKursa_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbTehnologije, dataGridView1);
        }

        private void btnZapamtiUlogu_Click(object sender, EventArgs e)
        {
            kontroler.UbaciUlogu(txtNazivUloge, txtNivoZnanja, cmbTehnologije);

        }

        private void btnObrisiUlogu_Click(object sender, EventArgs e)
        {
            kontroler.ObrisiUlogu(dataGridView1);

        }

        private void btnZapamtiKurs_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.dodajKurs(txtNaziv, txtProvajder, txtMinutaza, txtOpis, txtOcena, txtCena);
            if (uspelo == true)
            {
                //this.Close();
                panel.Controls.Clear();
            }
        }
    }
}
