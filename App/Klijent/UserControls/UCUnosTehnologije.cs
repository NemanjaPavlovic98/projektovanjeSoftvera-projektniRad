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
    public partial class UCUnosTehnologije : UserControl
    {
        KUnosTehnologije kontroler;
        Panel panel;
        public UCUnosTehnologije(Panel panel)
        {
            InitializeComponent();
            kontroler = new KUnosTehnologije();

            this.panel = panel;
        }

        private void UCUnosTehnologije_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(kontroler.dodajTehnologiju(txtNaziv, txtVrsta, txtKompanija, txtVerzija))
            {
                //this.Close();
                panel.Controls.Clear();
            }
           

        }
    }
}
