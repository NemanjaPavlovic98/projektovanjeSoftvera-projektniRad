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
    public partial class FrmUnosTehnologije : Form
    {
        KUnosTehnologije kontroler;
        public FrmUnosTehnologije()
        {
            InitializeComponent();
            kontroler = new KUnosTehnologije();
        }

        private void FrmUnosTehnologije_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kontroler.dodajTehnologiju(txtNaziv, txtVrsta, txtKompanija, txtVerzija);
            this.Close();
        }
    }
}
