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
    public class KUnosRecenzije
    {
        //public static Korisnik k;
        private Korisnik k = FrmGlavna.k;

        public static Recenzija recenzija;
        BindingList<RecenzijaUloge> recenzijeUloga;
        //FrmUnosRecenzije frmUnosRecenzije;
        UCUnosRecenzije frmUnosRecenzije;


        //public KUnosRecenzije(FrmUnosRecenzije frmUnosRecenzije)
        public KUnosRecenzije(UCUnosRecenzije frmUnosRecenzije)
        {
            recenzija = new Recenzija();
            this.frmUnosRecenzije = frmUnosRecenzije;
        }

        internal void srediFormu(ComboBox cmbUloge, GroupBox groupBox1, GroupBox groupBox2, Button btnPotvrdiFilm, ComboBox cmbFilmovi, Label lblKorisnik, DataGridView dataGridView1)
        {

            try
            {
                cmbUloge.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnPotvrdiFilm.Enabled = false;
                lblKorisnik.Text = k.Ime;
                cmbFilmovi.DataSource = Komunikacija.Instance.vratiKurseve();
                recenzijeUloga = new BindingList<RecenzijaUloge>();
                dataGridView1.DataSource = recenzijeUloga;
            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo rad");
                //frmUnosRecenzije.Close();
            }
        }

        internal void srediFormu2(GroupBox groupBox2, ComboBox cmbUloge, ComboBox cmbKursevi, GroupBox groupBox1, Button btnPotvrdiKurs)
        {
            groupBox2.Enabled = true;
            cmbUloge.Enabled = true;
            try
            {
                cmbUloge.DataSource = Komunikacija.Instance.VratiUloge((Kurs)cmbKursevi.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Server je prekinuo sa radom i ne mogu da se pronadju uloge");
                //frmUnosRecenzije.Close();
                return;
            }
            groupBox1.Enabled = true;
            btnPotvrdiKurs.Enabled = true;
            MessageBox.Show("Sistem je pronasao kurs!");


        }

        internal void obrisiRecenzijuUloge(DataGridView dataGridView1)
        {
            try
            {
                RecenzijaUloge r = (RecenzijaUloge)dataGridView1.CurrentRow.DataBoundItem;

                recenzijeUloga.Remove(r);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal bool dodajRecenziju(TextBox txtRecenzijaKursa, ComboBox cmbKursevi)
        {
            try
            {
                Kurs kurs = (Kurs)cmbKursevi.SelectedItem;
                recenzija.Kurs = kurs;
                if (String.IsNullOrEmpty(txtRecenzijaKursa.Text))
                {
                    MessageBox.Show("Recenzija kursa ne moze biti prazna");
                    return false;
                }
                recenzija.RecenzijaKursa = txtRecenzijaKursa.Text;
                recenzija.Korisnik = k;
                recenzija.RecenzijeUloga = recenzijeUloga.ToList<RecenzijaUloge>();
                bool uspesno = Komunikacija.Instance.DodajRecenziju(recenzija);
                if (uspesno)
                {
                    MessageBox.Show("Dodata je nova recenzija za kurs: " + kurs.NazivKursa);
                    return uspesno;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti recenziju!");
                    return uspesno;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
        }

        internal void UbaciRecenzijuUloge(ComboBox cmbUloge, TextBox txtRecenzijaUloge, ComboBox cmbKursevi)
        {
            RecenzijaUloge ru = new RecenzijaUloge();
            Kurs k = (Kurs)cmbKursevi.SelectedItem;
            Uloga uloga = (Uloga)cmbUloge.SelectedItem;
            if (uloga == null)
            {
                MessageBox.Show("Morate odabrati ulogu");
                return;
            }

            ru.Kurs = k;
            ru.Tehnologija.IDTehnologije = uloga.IDTehnologija;
            if (String.IsNullOrEmpty(txtRecenzijaUloge.Text))
            {
                MessageBox.Show("Recenzija uloge ne moze biti prazna");
                return;
            }
            ru.Recenzija = txtRecenzijaUloge.Text;
            ru.IDRecenzijeUloge = recenzijeUloga.Count() + 1;
            recenzijeUloga.Add(ru);
            txtRecenzijaUloge.Clear();


        }
    }
}
