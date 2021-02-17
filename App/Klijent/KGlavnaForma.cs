using Domen;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KGlavnaForma
    {
        //public static Korisnik k;
        Panel panel;
        internal void OtvoriZaUnos(Panel panel)
        {
            //FrmUnosTehnologije unos = new FrmUnosTehnologije();
            //unos.ShowDialog();
            SetPanel(panel,new UCUnosTehnologije(panel));
        }

        internal void OtvoriZaIzmenuiBrisnaje(Panel panel)
        {
            //FrmBrisanjeIzmenaTehnologije izmena = new FrmBrisanjeIzmenaTehnologije();
            //izmena.ShowDialog();
            SetPanel(panel, new UCIzmenaBrisanjeTehnologije(panel));
        }



        internal void OtvoriZaUnosKursa(Panel panel)
        {
            //FrmUnosKursa unosKursa = new FrmUnosKursa();
            this.panel = panel;
            //unosKursa.ShowDialog();
            SetPanel(panel, new UCUnosKursa(panel));
        }

        internal void OtvoriZaIzmenuBrisanjeKursa(Panel panel)
        {
            //FrmBrisanjeIzmenaKursa izmena = new FrmBrisanjeIzmenaKursa();
            //izmena.ShowDialog();
            SetPanel(panel, new UCIzmenaBrisanjeKursa(panel));
        }
        internal void OdjaviSe()
        {
            //Komunikacija.Instance.OdjaviSe();
        }
        internal void OtvoriZaRecenziju(Panel panel)
        {
            SetPanel(panel, new UCUnosRecenzije(panel));
            //FrmUnosRecenzije recenzija = new FrmUnosRecenzije();
            //KUnosRecenzije.k = k;
            //recenzija.ShowDialog();
        }
        internal void SetPanel(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            userControl.Parent = panel;
            userControl.Dock = DockStyle.Fill;
        }

    }
}
