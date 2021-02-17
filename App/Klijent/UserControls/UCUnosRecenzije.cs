using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Klijent.UserControls
{
    public partial class UCUnosRecenzije : UserControl
    {
        KUnosRecenzije kontroler;
        Panel panel;
        public UCUnosRecenzije(Panel panel)
        {
            InitializeComponent();
            kontroler = new KUnosRecenzije(this);
            this.panel = panel;
        }

        private void UCUnosRecenzije_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbUloge, groupBox1, groupBox2, btnPotvrdiKurs, cmbKursevi, lblKorisnik, dataGridView1);
        }



        private void btnKurs_Click_1(object sender, EventArgs e)
        {
            kontroler.srediFormu2(groupBox2, cmbUloge, cmbKursevi, groupBox1, btnPotvrdiKurs);
        }

        private void btnPotvrdiUlogu_Click_1(object sender, EventArgs e)
        {
            kontroler.UbaciRecenzijuUloge(cmbUloge, txtRecenzijaUloge, cmbKursevi);
        }

        private void btnObrisiRecenzijuUloge_Click_1(object sender, EventArgs e)
        {
            kontroler.obrisiRecenzijuUloge(dataGridView1);
        }

        private void btnPotvrdiKurs_Click_1(object sender, EventArgs e)
        {
            bool uspelo = kontroler.dodajRecenziju(txtRecenzijaKursa, cmbKursevi);
            if (uspelo)
            {
                panel.Controls.Clear();
            }
        }
    }
}
