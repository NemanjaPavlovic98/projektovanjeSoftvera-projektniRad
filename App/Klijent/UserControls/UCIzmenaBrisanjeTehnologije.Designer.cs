
namespace Klijent.UserControls
{
    partial class UCIzmenaBrisanjeTehnologije
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVerzija = new System.Windows.Forms.TextBox();
            this.btnPotvrdiIzmenu = new System.Windows.Forms.Button();
            this.txtKompanija = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmbTehnologije = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVerzija);
            this.groupBox1.Controls.Add(this.btnPotvrdiIzmenu);
            this.groupBox1.Controls.Add(this.txtKompanija);
            this.groupBox1.Controls.Add(this.txtVrsta);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(54, 173);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(582, 481);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena tehnologije";
            // 
            // txtVerzija
            // 
            this.txtVerzija.Location = new System.Drawing.Point(248, 290);
            this.txtVerzija.Margin = new System.Windows.Forms.Padding(6);
            this.txtVerzija.Name = "txtVerzija";
            this.txtVerzija.Size = new System.Drawing.Size(300, 31);
            this.txtVerzija.TabIndex = 22;
            // 
            // btnPotvrdiIzmenu
            // 
            this.btnPotvrdiIzmenu.Location = new System.Drawing.Point(44, 375);
            this.btnPotvrdiIzmenu.Margin = new System.Windows.Forms.Padding(6);
            this.btnPotvrdiIzmenu.Name = "btnPotvrdiIzmenu";
            this.btnPotvrdiIzmenu.Size = new System.Drawing.Size(496, 44);
            this.btnPotvrdiIzmenu.TabIndex = 21;
            this.btnPotvrdiIzmenu.Text = "Potvrdi izmenu tehnologije";
            this.btnPotvrdiIzmenu.UseVisualStyleBackColor = true;
            this.btnPotvrdiIzmenu.Click += new System.EventHandler(this.btnPotvrdiIzmenu_Click);
            // 
            // txtKompanija
            // 
            this.txtKompanija.Location = new System.Drawing.Point(248, 218);
            this.txtKompanija.Margin = new System.Windows.Forms.Padding(6);
            this.txtKompanija.Name = "txtKompanija";
            this.txtKompanija.Size = new System.Drawing.Size(300, 31);
            this.txtKompanija.TabIndex = 19;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(248, 147);
            this.txtVrsta.Margin = new System.Windows.Forms.Padding(6);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(300, 31);
            this.txtVrsta.TabIndex = 18;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(248, 70);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(300, 31);
            this.txtNaziv.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aktuelna verzija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kompanija vlasnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vrsta tehnologije:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Naziv:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(348, 88);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(6);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(288, 44);
            this.btnIzmeni.TabIndex = 15;
            this.btnIzmeni.Text = "Izmeni tehnologiju";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(48, 88);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(6);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(288, 44);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Obrisi tehnologiju";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmbTehnologije
            // 
            this.cmbTehnologije.FormattingEnabled = true;
            this.cmbTehnologije.Location = new System.Drawing.Point(246, 19);
            this.cmbTehnologije.Margin = new System.Windows.Forms.Padding(6);
            this.cmbTehnologije.Name = "cmbTehnologije";
            this.cmbTehnologije.Size = new System.Drawing.Size(404, 33);
            this.cmbTehnologije.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Izaberite tehnologiju:";
            // 
            // UCIzmenaBrisanjeTehnologije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.cmbTehnologije);
            this.Controls.Add(this.label1);
            this.Name = "UCIzmenaBrisanjeTehnologije";
            this.Size = new System.Drawing.Size(682, 672);
            this.Load += new System.EventHandler(this.UCIzmenaBrisanjeTehnologije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVerzija;
        private System.Windows.Forms.Button btnPotvrdiIzmenu;
        private System.Windows.Forms.TextBox txtKompanija;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox cmbTehnologije;
        private System.Windows.Forms.Label label1;
    }
}
