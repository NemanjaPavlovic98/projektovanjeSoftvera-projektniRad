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
    class KBrisanjeIzmenaTehnologije
    {

        // private FrmBrisanjeIzmenaTehnologije frmBrisanjeIzmenaTehnologije;
        private UCIzmenaBrisanjeTehnologije frmBrisanjeIzmenaTehnologije;

        public KBrisanjeIzmenaTehnologije(UCIzmenaBrisanjeTehnologije frmTeh)
        {
            this.frmBrisanjeIzmenaTehnologije = frmTeh;
        }

        internal void srediFormu(ComboBox cmbTehnologije, GroupBox groupBox1)
        {
            groupBox1.Enabled = false;
            try
            {
                cmbTehnologije.DataSource = Komunikacija.Instance.vratiTehnologije();

            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad i ne moze da pronadje tehnologije!");
                //frmBrisanjeIzmenaTehnologije.Close();
            }
        }

        internal bool ObrisiTehnologiju(ComboBox cmbTehnologije)
        {
            try
            {
                if (cmbTehnologije.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite tehnologiju koju zelite da obrisete!");
                    return false;
                }
                Tehnologija tehZaBrisnaje = (Tehnologija)cmbTehnologije.SelectedItem;
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.ObrisiTehnologiju(tehZaBrisnaje);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Obrisana je tehnologija po imenu: {tehZaBrisnaje.NazivTehnologije}!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise tehnologiju");
                    return false;
                }
            }
            catch (Exception)
            {

                throw new Exception("Greska pri brisanju");
            }
        }

        internal bool IzmeniTehnologije(
            ComboBox cmbTehnologije, TextBox txtNaziv, TextBox txtVrsta, TextBox txtKompanija, TextBox txtVerzija)
        {
            try
            {
                if (cmbTehnologije.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite tehnologiju koga zelite da izmenite!");
                    return false;
                }
                Tehnologija tehZaIzmenu = (Tehnologija)cmbTehnologije.SelectedItem;

                if (!String.IsNullOrEmpty(txtNaziv.Text))
                {
                    tehZaIzmenu.NazivTehnologije = txtNaziv.Text;
                }
                if (!String.IsNullOrEmpty(txtVrsta.Text))
                {
                    tehZaIzmenu.VrstaTehnologije = txtVrsta.Text;
                }
                if (!String.IsNullOrEmpty(txtKompanija.Text))
                {
                    tehZaIzmenu.KompanijaVlasnik = txtKompanija.Text;
                }
                if (!String.IsNullOrEmpty(txtVerzija.Text))
                {
                    tehZaIzmenu.AktuelnaVerzija = txtVerzija.Text;
                }
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.IzmeniTehnologiju(tehZaIzmenu);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show($"Napravljene su izmene nad tehnologijom: {tehZaIzmenu.NazivTehnologije}!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene tehnologije.");
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
