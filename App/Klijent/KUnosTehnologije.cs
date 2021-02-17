using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KUnosTehnologije
    {
        internal bool dodajTehnologiju(TextBox txtNaziv, TextBox txtVrsta, TextBox txtvlasnik, TextBox txtVerzija)
        {
            try
            {
                Tehnologija tehnologija = new Tehnologija
                {
                    NazivTehnologije = txtNaziv.Text,
                    VrstaTehnologije = txtVrsta.Text,
                    KompanijaVlasnik = txtvlasnik.Text,
                    AktuelnaVerzija = txtVerzija.Text
                };
                if (String.IsNullOrEmpty(txtNaziv.Text))
                {
                    MessageBox.Show("Niste uneli naziv tehnologije!");
                    return false;
                }
                if (String.IsNullOrEmpty(txtVrsta.Text))
                {
                    MessageBox.Show("Niste uneli vrstu tehnologije!");
                    return false;
                }
                bool uspesno = false;
                try
                {
                    uspesno = Komunikacija.Instance.DodajTehnologiju(tehnologija);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                if (uspesno)
                {
                    MessageBox.Show("Dodata je nova tehnologija po imenu " + tehnologija.NazivTehnologije + " !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti tehnologiju");
                    return true;
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
