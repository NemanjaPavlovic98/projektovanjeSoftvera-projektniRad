using Domen;
using Klijent.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KUnosKursa
    {
        public static Kurs kurs;
        BindingList<Uloga> listaUloga;
        //FrmUnosKursa frmUnosKursa;
        UCUnosKursa frmUnosKursa;
        public KUnosKursa(UCUnosKursa frmUnosKursa)
        {
            kurs = new Kurs();
            this.frmUnosKursa = frmUnosKursa;

        }

        internal void UbaciUlogu(TextBox txtNazivUloge, TextBox txtNivoZnanja, ComboBox cmbTehnologije)
        {
            Uloga uloga = new Uloga();
            Tehnologija teh = (Tehnologija)cmbTehnologije.SelectedItem;
            uloga.IDTehnologija = teh.IDTehnologije;
            uloga.NazivUloge = txtNazivUloge.Text;
            uloga.NivoZnanja = txtNivoZnanja.Text;
            listaUloga.Add(uloga);
            txtNazivUloge.Clear();
            txtNivoZnanja.Clear();
        }

        internal void srediFormu(ComboBox cmbTehnologije, DataGridView dataGridView1)
        {

            try
            {
                cmbTehnologije.DataSource = Komunikacija.Instance.vratiTehnologije();
                listaUloga = new BindingList<Uloga>();
                dataGridView1.DataSource = listaUloga;
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad");
                //frmUnosKursa.Close();
            }
        }

        internal void ObrisiUlogu(DataGridView dataGridView1)
        {
            try
            {
                Uloga u = (Uloga)dataGridView1.CurrentRow.DataBoundItem;

                listaUloga.Remove(u);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal bool dodajKurs(TextBox txtNaziv, TextBox txtProvajder, TextBox txtMinutaza, TextBox txtOpis, TextBox txtOcena, TextBox txtCena)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNaziv.Text))
                {
                    MessageBox.Show("Niste uneli naziv kursa!");
                    return false;
                }
                if (String.IsNullOrEmpty(txtProvajder.Text))
                {
                    MessageBox.Show("Niste uneli provajdera kursa!");
                    return false;
                }
                if (String.IsNullOrEmpty(txtMinutaza.Text))
                {
                    MessageBox.Show("Niste uneli minutazu za kurs!");
                    return false;
                }
                if (String.IsNullOrEmpty(txtCena.Text))
                {
                    MessageBox.Show("Niste uneli cenu za kurs!");
                    return false;
                }
                kurs.NazivKursa = txtNaziv.Text;
                kurs.ProvajderKursa = txtProvajder.Text;
                kurs.OpisKursa = txtOpis.Text;
                try
                {
                    kurs.Minutaza = Convert.ToInt32(txtMinutaza.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Minutaza nije u odgovarajucem formatu!");
                    return false;
                }
                try
                {

                    kurs.OcenaKursa = double.Parse(txtOcena.Text, System.Globalization.CultureInfo.InvariantCulture);

                }
                catch (Exception)
                {

                    MessageBox.Show("Ocena nije u odgovarajucem formatu");
                    return false;
                }
                if(kurs.OcenaKursa < 0 || kurs.OcenaKursa > 10)
                {
                    MessageBox.Show("Ocena kursa mora biti izmedju 0 i 10!");
                    return false;
                }
                try
                {
                    kurs.CenaKursa = double.Parse(txtCena.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {

                    MessageBox.Show("Cena nije u odgovarajucem formatu!");
                    return false;
                }
                kurs.uloge = listaUloga.ToList<Uloga>();
                bool uspesno;
                try
                {
                    uspesno = Komunikacija.Instance.DodajKurs(kurs);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (uspesno)
                {
                    MessageBox.Show("Dodat je kurs film po imenu: " + txtNaziv.Text);
                    return true;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti kurs");
                    return false;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
