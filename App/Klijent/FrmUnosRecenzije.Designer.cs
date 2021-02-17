
namespace Klijent
{
    partial class FrmUnosRecenzije
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
            this.btnPotvrdiKurs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecenzijaKursa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiRecenzijuUloge = new System.Windows.Forms.Button();
            this.txtRecenzijaUloge = new System.Windows.Forms.TextBox();
            this.btnPotvrdiUlogu = new System.Windows.Forms.Button();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKursevi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKurs = new System.Windows.Forms.Button();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 946);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 234);
            this.dataGridView1.TabIndex = 50;
            // 
            // btnPotvrdiKurs
            // 
            this.btnPotvrdiKurs.Location = new System.Drawing.Point(40, 1242);
            this.btnPotvrdiKurs.Margin = new System.Windows.Forms.Padding(6);
            this.btnPotvrdiKurs.Name = "btnPotvrdiKurs";
            this.btnPotvrdiKurs.Size = new System.Drawing.Size(716, 83);
            this.btnPotvrdiKurs.TabIndex = 46;
            this.btnPotvrdiKurs.Text = "Potvrdi Recenziju Kursa";
            this.btnPotvrdiKurs.UseVisualStyleBackColor = true;
            this.btnPotvrdiKurs.Click += new System.EventHandler(this.btnPotvrdiKurs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecenzijaKursa);
            this.groupBox2.Location = new System.Drawing.Point(40, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(716, 228);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recenzija kursa";
            // 
            // txtRecenzijaKursa
            // 
            this.txtRecenzijaKursa.Location = new System.Drawing.Point(15, 70);
            this.txtRecenzijaKursa.Margin = new System.Windows.Forms.Padding(6);
            this.txtRecenzijaKursa.Multiline = true;
            this.txtRecenzijaKursa.Name = "txtRecenzijaKursa";
            this.txtRecenzijaKursa.Size = new System.Drawing.Size(662, 107);
            this.txtRecenzijaKursa.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiRecenzijuUloge);
            this.groupBox1.Controls.Add(this.txtRecenzijaUloge);
            this.groupBox1.Controls.Add(this.btnPotvrdiUlogu);
            this.groupBox1.Location = new System.Drawing.Point(40, 617);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(716, 317);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recenzija uloge";
            // 
            // btnObrisiRecenzijuUloge
            // 
            this.btnObrisiRecenzijuUloge.Location = new System.Drawing.Point(404, 220);
            this.btnObrisiRecenzijuUloge.Margin = new System.Windows.Forms.Padding(6);
            this.btnObrisiRecenzijuUloge.Name = "btnObrisiRecenzijuUloge";
            this.btnObrisiRecenzijuUloge.Size = new System.Drawing.Size(276, 61);
            this.btnObrisiRecenzijuUloge.TabIndex = 33;
            this.btnObrisiRecenzijuUloge.Text = "Obrisi Recenziju Uloge";
            this.btnObrisiRecenzijuUloge.UseVisualStyleBackColor = true;
            this.btnObrisiRecenzijuUloge.Click += new System.EventHandler(this.btnObrisiRecenzijuUloge_Click);
            // 
            // txtRecenzijaUloge
            // 
            this.txtRecenzijaUloge.Location = new System.Drawing.Point(15, 52);
            this.txtRecenzijaUloge.Margin = new System.Windows.Forms.Padding(6);
            this.txtRecenzijaUloge.Multiline = true;
            this.txtRecenzijaUloge.Name = "txtRecenzijaUloge";
            this.txtRecenzijaUloge.Size = new System.Drawing.Size(662, 129);
            this.txtRecenzijaUloge.TabIndex = 31;
            // 
            // btnPotvrdiUlogu
            // 
            this.btnPotvrdiUlogu.Location = new System.Drawing.Point(15, 220);
            this.btnPotvrdiUlogu.Margin = new System.Windows.Forms.Padding(6);
            this.btnPotvrdiUlogu.Name = "btnPotvrdiUlogu";
            this.btnPotvrdiUlogu.Size = new System.Drawing.Size(292, 61);
            this.btnPotvrdiUlogu.TabIndex = 32;
            this.btnPotvrdiUlogu.Text = "Dodaj Recenziju Uloge";
            this.btnPotvrdiUlogu.UseVisualStyleBackColor = true;
            this.btnPotvrdiUlogu.Click += new System.EventHandler(this.btnPotvrdiUlogu_Click);
            // 
            // cmbUloge
            // 
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(222, 569);
            this.cmbUloge.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(446, 33);
            this.cmbUloge.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 574);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Izaberite ulogu:";
            // 
            // cmbKursevi
            // 
            this.cmbKursevi.FormattingEnabled = true;
            this.cmbKursevi.Location = new System.Drawing.Point(222, 116);
            this.cmbKursevi.Margin = new System.Windows.Forms.Padding(6);
            this.cmbKursevi.Name = "cmbKursevi";
            this.cmbKursevi.Size = new System.Drawing.Size(446, 33);
            this.cmbKursevi.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Izaberite kurs:";
            // 
            // btnKurs
            // 
            this.btnKurs.Location = new System.Drawing.Point(40, 192);
            this.btnKurs.Margin = new System.Windows.Forms.Padding(6);
            this.btnKurs.Name = "btnKurs";
            this.btnKurs.Size = new System.Drawing.Size(716, 83);
            this.btnKurs.TabIndex = 49;
            this.btnKurs.Text = "Potvrdi kurs";
            this.btnKurs.UseVisualStyleBackColor = true;
            this.btnKurs.Click += new System.EventHandler(this.btnKurs_Click);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(244, 52);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(200, 25);
            this.lblKorisnik.TabIndex = 48;
            this.lblKorisnik.Text = "Ulogovani korisnik: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 52);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ulogovani korisnik: ";
            // 
            // FrmUnosRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPotvrdiKurs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUloge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKursevi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKurs);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.label12);
            this.Name = "FrmUnosRecenzije";
            this.Text = "Recenzija kursa";
            this.Load += new System.EventHandler(this.FrmUnosRecenzije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPotvrdiKurs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecenzijaKursa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiRecenzijuUloge;
        private System.Windows.Forms.TextBox txtRecenzijaUloge;
        private System.Windows.Forms.Button btnPotvrdiUlogu;
        private System.Windows.Forms.ComboBox cmbUloge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKursevi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKurs;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label label12;
    }
}