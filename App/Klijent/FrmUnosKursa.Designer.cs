
namespace Klijent
{
    partial class FrmUnosKursa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObrisiUlogu = new System.Windows.Forms.Button();
            this.btnZapamtiUlogu = new System.Windows.Forms.Button();
            this.txtNivoZnanja = new System.Windows.Forms.TextBox();
            this.txtNazivUloge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTehnologije = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnZapamtiKurs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtMinutaza = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProvajder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 917);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(834, 234);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnObrisiUlogu
            // 
            this.btnObrisiUlogu.Location = new System.Drawing.Point(670, 142);
            this.btnObrisiUlogu.Margin = new System.Windows.Forms.Padding(6);
            this.btnObrisiUlogu.Name = "btnObrisiUlogu";
            this.btnObrisiUlogu.Size = new System.Drawing.Size(150, 88);
            this.btnObrisiUlogu.TabIndex = 7;
            this.btnObrisiUlogu.Text = "Obrisi Ulogu";
            this.btnObrisiUlogu.UseVisualStyleBackColor = true;
            this.btnObrisiUlogu.Click += new System.EventHandler(this.btnObrisiUlogu_Click);
            // 
            // btnZapamtiUlogu
            // 
            this.btnZapamtiUlogu.Location = new System.Drawing.Point(670, 42);
            this.btnZapamtiUlogu.Margin = new System.Windows.Forms.Padding(6);
            this.btnZapamtiUlogu.Name = "btnZapamtiUlogu";
            this.btnZapamtiUlogu.Size = new System.Drawing.Size(150, 88);
            this.btnZapamtiUlogu.TabIndex = 6;
            this.btnZapamtiUlogu.Text = "Dodaj Ulogu";
            this.btnZapamtiUlogu.UseVisualStyleBackColor = true;
            this.btnZapamtiUlogu.Click += new System.EventHandler(this.btnZapamtiUlogu_Click);
            // 
            // txtNivoZnanja
            // 
            this.txtNivoZnanja.Location = new System.Drawing.Point(270, 200);
            this.txtNivoZnanja.Margin = new System.Windows.Forms.Padding(6);
            this.txtNivoZnanja.Name = "txtNivoZnanja";
            this.txtNivoZnanja.Size = new System.Drawing.Size(348, 31);
            this.txtNivoZnanja.TabIndex = 5;
            // 
            // txtNazivUloge
            // 
            this.txtNazivUloge.Location = new System.Drawing.Point(270, 131);
            this.txtNazivUloge.Margin = new System.Windows.Forms.Padding(6);
            this.txtNazivUloge.Name = "txtNazivUloge";
            this.txtNazivUloge.Size = new System.Drawing.Size(348, 31);
            this.txtNazivUloge.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nivo zahtevanog znanja:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Naziv uloge:";
            // 
            // cmbTehnologije
            // 
            this.cmbTehnologije.FormattingEnabled = true;
            this.cmbTehnologije.Location = new System.Drawing.Point(270, 51);
            this.cmbTehnologije.Margin = new System.Windows.Forms.Padding(6);
            this.cmbTehnologije.Name = "cmbTehnologije";
            this.cmbTehnologije.Size = new System.Drawing.Size(348, 33);
            this.cmbTehnologije.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tehnologija:";
            // 
            // btnZapamtiKurs
            // 
            this.btnZapamtiKurs.Location = new System.Drawing.Point(40, 1219);
            this.btnZapamtiKurs.Margin = new System.Windows.Forms.Padding(6);
            this.btnZapamtiKurs.Name = "btnZapamtiKurs";
            this.btnZapamtiKurs.Size = new System.Drawing.Size(832, 73);
            this.btnZapamtiKurs.TabIndex = 28;
            this.btnZapamtiKurs.Text = "Zapamti Kurs";
            this.btnZapamtiKurs.UseVisualStyleBackColor = true;
            this.btnZapamtiKurs.Click += new System.EventHandler(this.btnZapamtiKurs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiUlogu);
            this.groupBox1.Controls.Add(this.btnZapamtiUlogu);
            this.groupBox1.Controls.Add(this.txtNivoZnanja);
            this.groupBox1.Controls.Add(this.txtNazivUloge);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbTehnologije);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(40, 578);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(832, 298);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos uloge:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(310, 494);
            this.txtCena.Margin = new System.Windows.Forms.Padding(6);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(358, 31);
            this.txtCena.TabIndex = 26;
            // 
            // txtOcena
            // 
            this.txtOcena.Location = new System.Drawing.Point(310, 417);
            this.txtOcena.Margin = new System.Windows.Forms.Padding(6);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(358, 31);
            this.txtOcena.TabIndex = 25;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(310, 203);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(6);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(358, 185);
            this.txtOpis.TabIndex = 24;
            // 
            // txtMinutaza
            // 
            this.txtMinutaza.Location = new System.Drawing.Point(310, 130);
            this.txtMinutaza.Margin = new System.Windows.Forms.Padding(6);
            this.txtMinutaza.Name = "txtMinutaza";
            this.txtMinutaza.Size = new System.Drawing.Size(358, 31);
            this.txtMinutaza.TabIndex = 23;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(310, 26);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(358, 31);
            this.txtNaziv.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 499);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cena (x.xx):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 425);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ocena (x.xx):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Opis kursa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Minutaza (minut):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Naziv kursa:";
            // 
            // txtProvajder
            // 
            this.txtProvajder.Location = new System.Drawing.Point(310, 78);
            this.txtProvajder.Margin = new System.Windows.Forms.Padding(6);
            this.txtProvajder.Name = "txtProvajder";
            this.txtProvajder.Size = new System.Drawing.Size(358, 31);
            this.txtProvajder.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Provajder kursa:";
            // 
            // FrmUnosKursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 1374);
            this.Controls.Add(this.txtProvajder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnZapamtiKurs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtOcena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtMinutaza);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmUnosKursa";
            this.Text = "FrmUnosKursa";
            this.Load += new System.EventHandler(this.FrmUnosKursa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnObrisiUlogu;
        private System.Windows.Forms.Button btnZapamtiUlogu;
        private System.Windows.Forms.TextBox txtNivoZnanja;
        private System.Windows.Forms.TextBox txtNazivUloge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTehnologije;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnZapamtiKurs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtMinutaza;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProvajder;
        private System.Windows.Forms.Label label1;
    }
}