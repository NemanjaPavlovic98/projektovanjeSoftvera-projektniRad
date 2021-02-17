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
    public partial class Login : Form
    {
        KLogin kontroler = new KLogin();
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = btnLogin;
            kontroler.SrediFormu(lblPoruka, lblPokusaj);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            //Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(kontroler.PokusajPonovo(groupBox1, lblPoruka, lblPokusaj))
            {
                bool uspelo = kontroler.UlogujSe(txtUsername, txtPassword, lblPokusaj, btnLogin);
                if (uspelo)
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Server ne radi");

            }
            //bool uspelo = kontroler.UlogujSe(txtUsername, txtPassword, lblPokusaj, btnLogin);
            //if (uspelo)
            //{
            //    this.Hide();

            //}
        }

        private void btnPoveziSe_Click(object sender, EventArgs e)
        {
            //kontroler.PokusajPonovo(groupBox1, lblPoruka, btnPoveziSe, lblPokusaj);
        }
    }
}
