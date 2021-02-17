
namespace Klijent.UserControls
{
    partial class UCIzmenaBrisanjeKursa
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinutaza = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPotvrdiIzmenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtProvajder = new System.Windows.Forms.TextBox();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmbKursevi = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sta zelite da uradite?";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(330, 140);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(6);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(288, 44);
            this.btnIzmeni.TabIndex = 39;
            this.btnIzmeni.Text = "Izmeni kurs";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(30, 140);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(6);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(288, 44);
            this.btnObrisi.TabIndex = 38;
            this.btnObrisi.Text = "Obrisi kurs";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Izaberite kurs:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Minutaza:";
            // 
            // txtMinutaza
            // 
            this.txtMinutaza.Location = new System.Drawing.Point(175, 204);
            this.txtMinutaza.Margin = new System.Windows.Forms.Padding(6);
            this.txtMinutaza.Name = "txtMinutaza";
            this.txtMinutaza.Size = new System.Drawing.Size(332, 31);
            this.txtMinutaza.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMinutaza);
            this.groupBox1.Controls.Add(this.btnPotvrdiIzmenu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtProvajder);
            this.groupBox1.Controls.Add(this.txtOcena);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Location = new System.Drawing.Point(35, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(584, 777);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena kursa";
            // 
            // btnPotvrdiIzmenu
            // 
            this.btnPotvrdiIzmenu.Location = new System.Drawing.Point(48, 678);
            this.btnPotvrdiIzmenu.Margin = new System.Windows.Forms.Padding(6);
            this.btnPotvrdiIzmenu.Name = "btnPotvrdiIzmenu";
            this.btnPotvrdiIzmenu.Size = new System.Drawing.Size(496, 44);
            this.btnPotvrdiIzmenu.TabIndex = 24;
            this.btnPotvrdiIzmenu.Text = "Potvrdi izmenu kursa";
            this.btnPotvrdiIzmenu.UseVisualStyleBackColor = true;
            this.btnPotvrdiIzmenu.Click += new System.EventHandler(this.btnPotvrdiIzmenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naziv kursa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Provajder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Opis kursa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 510);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ocena kursa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 587);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cena:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(176, 49);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(332, 31);
            this.txtNaziv.TabIndex = 19;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(176, 581);
            this.txtCena.Margin = new System.Windows.Forms.Padding(6);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(332, 31);
            this.txtCena.TabIndex = 23;
            // 
            // txtProvajder
            // 
            this.txtProvajder.Location = new System.Drawing.Point(176, 129);
            this.txtProvajder.Margin = new System.Windows.Forms.Padding(6);
            this.txtProvajder.Name = "txtProvajder";
            this.txtProvajder.Size = new System.Drawing.Size(332, 31);
            this.txtProvajder.TabIndex = 20;
            // 
            // txtOcena
            // 
            this.txtOcena.Location = new System.Drawing.Point(176, 506);
            this.txtOcena.Margin = new System.Windows.Forms.Padding(6);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(332, 31);
            this.txtOcena.TabIndex = 22;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(175, 275);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(6);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(332, 188);
            this.txtOpis.TabIndex = 21;
            // 
            // cmbKursevi
            // 
            this.cmbKursevi.FormattingEnabled = true;
            this.cmbKursevi.Location = new System.Drawing.Point(210, 32);
            this.cmbKursevi.Margin = new System.Windows.Forms.Padding(6);
            this.cmbKursevi.Name = "cmbKursevi";
            this.cmbKursevi.Size = new System.Drawing.Size(404, 33);
            this.cmbKursevi.TabIndex = 37;
            // 
            // UCIzmenaBrisanjeKursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbKursevi);
            this.Name = "UCIzmenaBrisanjeKursa";
            this.Size = new System.Drawing.Size(664, 1040);
            this.Load += new System.EventHandler(this.UCIzmenaBrisanjeKursa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinutaza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPotvrdiIzmenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtProvajder;
        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.ComboBox cmbKursevi;
    }
}
