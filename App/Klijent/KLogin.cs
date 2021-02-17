using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KLogin
    {
        int brojPokusaja = 3;
        //internal void SrediFormu(GroupBox groupBox1, Label lblPoruka, Button btnPoveziSe, Label lblPokusaj)
        internal void SrediFormu(Label lblPoruka, Label lblPokusaj)
        {
            lblPoruka.Visible = false;
            lblPokusaj.Visible = false;
            //btnPoveziSe.Visible = false;
            //lblPokusaj.Text = brojPokusaja.ToString();
            if (!Komunikacija.Instance.PoveziSe())
            {
                //groupBox1.Enabled = false;
                lblPoruka.Visible = true;
                lblPoruka.Text = " ";
                //btnPoveziSe.Visible = true;
                //lblPokusaj.Text = "0";
            }
        }
        
      

        internal bool PokusajPonovo(GroupBox groupBox1, Label lblPoruka, Label lblPokusaj)
        {
            if (!Komunikacija.Instance.PoveziSe())
            {
                
                lblPokusaj.Text = "Server ne radi";
                return false;
            }
            else
            {
                groupBox1.Enabled = true;
                lblPoruka.Visible = true;
                lblPokusaj.Visible = true;
                lblPoruka.Text = "Broj pokusaja: ";
                //btnPoveziSe.Visible = false;
                lblPokusaj.Text = brojPokusaja.ToString();
                return true;
            }
        }

        //internal void PokusajPonovo(GroupBox groupBox1, Label lblPoruka, Button btnPoveziSe, Label lblPokusaj)
        //{
        //    if (!Komunikacija.Instance.PoveziSe())
        //    {
        //        groupBox1.Enabled = false;
        //        lblPoruka.Visible = true;
        //        btnPoveziSe.Visible = true;
        //        lblPokusaj.Text = "0";
        //    }
        //    else
        //    {
        //        groupBox1.Enabled = true;
        //        lblPoruka.Visible = false;
        //        btnPoveziSe.Visible = false;
        //        lblPokusaj.Text = brojPokusaja.ToString();
        //    }
        //}

        internal bool UlogujSe(TextBox txtUsername, TextBox txtPassword, Label lblPokusaj, Button btnLogin)
        {
            try
            {
                if (brojPokusaja <= 1)
                {
                    MessageBox.Show("Nemate vise pokusaja");
                    lblPokusaj.Text = "0";
                    btnLogin.Enabled = false;
                    return false;
                }
                Korisnik k;
                try
                {
                    k = Komunikacija.Instance.PrijaviKorisnika(txtUsername.Text, txtPassword.Text);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                if (k != null)
                {
                    MessageBox.Show("Uspesna prijava!");
                    FrmGlavna frmGlavnaForma = new FrmGlavna();
                    //KGlavnaForma.k = k;
                    FrmGlavna.k = k;        
                    frmGlavnaForma.Show();
                    return true;
                }
                else
                {
                    brojPokusaja--;
                    MessageBox.Show("Neuspesna prijava");
                    lblPokusaj.Text = brojPokusaja.ToString();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
