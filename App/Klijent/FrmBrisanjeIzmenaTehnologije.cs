﻿using System;
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
    public partial class FrmBrisanjeIzmenaTehnologije : Form
    {
        KBrisanjeIzmenaTehnologije kontroler;

        public FrmBrisanjeIzmenaTehnologije()
        {
            InitializeComponent();
           // kontroler = new KBrisanjeIzmenaTehnologije(this);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmBrisanjeIzmenaTehnologije_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbTehnologije, groupBox1);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.ObrisiTehnologiju(cmbTehnologije);
            if (uspelo)
            {
                this.Close();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void btnPotvrdiIzmenu_Click(object sender, EventArgs e)
        {
            bool uspelo = kontroler.IzmeniTehnologije(cmbTehnologije, txtNaziv, txtVrsta, txtKompanija, txtVerzija);
            if (uspelo)
            {
                this.Close();
            }
        }
    }
}
