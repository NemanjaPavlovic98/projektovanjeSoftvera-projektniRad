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
    class KBrisanjeIzmenaKursa
    {
        //private FrmBrisanjeIzmenaKursa frmBrisanjeIzmenaKursa;
        private UCIzmenaBrisanjeKursa frmBrisanjeIzmenaKursa;

        public KBrisanjeIzmenaKursa(UCIzmenaBrisanjeKursa frmBrisanjeIzmenaKursa)
        {
            this.frmBrisanjeIzmenaKursa = frmBrisanjeIzmenaKursa;
        }

        internal void srediFormu(ComboBox cmbKursevi, GroupBox groupBox1)
        {
            groupBox1.Enabled = false;
            try
            {
                cmbKursevi.DataSource = Komunikacija.Instance.vratiKurseve();
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad i ne moze da pronadje kurseve ");
                //frmBrisanjeIzmenaKursa.Close();
            }

        }

        internal bool ObrisiKurs(ComboBox cmbKursevi)
        {
            try
            {
                if (cmbKursevi.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite kurs za brisanje!");
                    return false;
                }
                Kurs kursZaBrisanje = (Kurs)cmbKursevi.SelectedItem;
                bool uspelo;
                try
                {
                    uspelo = Komunikacija.Instance.ObrisiKurs(kursZaBrisanje);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspelo)
                {
                    MessageBox.Show($"Obrisan je kurs: {kursZaBrisanje.NazivKursa}");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise kurs!");
                    return false;
                }
            }
            catch (Exception)
            {
                throw new Exception("Greska pri brisanju");
            }
        }

        internal bool IzmeniKurs(ComboBox cmbKursevi, 
            TextBox txtNaziv, TextBox txtProvajder, TextBox txtMinutaza, TextBox txtOpis, 
            TextBox txtOcena, TextBox txtCena)
        {
            try
            {
                if (cmbKursevi.SelectedIndex < 0)
                {
                    MessageBox.Show("Izaberite kurs koji zelite da izmenite");
                    return false;
                }
                Kurs kursZaIzmenu = (Kurs)cmbKursevi.SelectedItem;

                if (!String.IsNullOrEmpty(txtNaziv.Text))
                {
                    kursZaIzmenu.NazivKursa = txtNaziv.Text;
                }
                if (!String.IsNullOrEmpty(txtProvajder.Text))
                {
                    kursZaIzmenu.ProvajderKursa = txtProvajder.Text;
                }
                if (!String.IsNullOrEmpty(txtMinutaza.Text))
                {
                    try
                    {
                        kursZaIzmenu.Minutaza = Convert.ToInt32(txtMinutaza.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Minutaza nije izmenjena jer nije u odgovarajucem formatu");
                        return false;
                    }
                }
                if (!String.IsNullOrEmpty(txtOpis.Text))
                {
                    kursZaIzmenu.OpisKursa = txtOpis.Text;
                }
                if (!String.IsNullOrEmpty(txtOcena.Text))
                {
                    try
                    {
                        kursZaIzmenu.OcenaKursa = double.Parse(txtOcena.Text, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Zarada nije izmenjena jer nije u odgovarajucem formatu");
                        return false;
                    }
                }
                if (!String.IsNullOrEmpty(txtCena.Text))
                {
                    try
                    {
                        kursZaIzmenu.CenaKursa = double.Parse(txtCena.Text, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cena nije izmenjena jer nije u odgovarajucem formatu");
                        return false;
                    }
                }
                bool uspelo;
                try
                {
                    uspelo = Komunikacija.Instance.IzmeniKurs(kursZaIzmenu);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspelo)
                {
                    MessageBox.Show($"Napravljene su izmene nad kursom: {kursZaIzmenu.NazivKursa}");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nije moguce sacuvati izmene nad kursom.");
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
