
namespace Klijent
{
    partial class FrmUnosTehnologije
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtKompanija = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerzija = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(48, 365);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(6);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(496, 44);
            this.btnDodaj.TabIndex = 21;
            this.btnDodaj.Text = "Dodaj tehnologiju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtKompanija
            // 
            this.txtKompanija.Location = new System.Drawing.Point(249, 211);
            this.txtKompanija.Margin = new System.Windows.Forms.Padding(6);
            this.txtKompanija.Name = "txtKompanija";
            this.txtKompanija.Size = new System.Drawing.Size(300, 31);
            this.txtKompanija.TabIndex = 19;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(249, 140);
            this.txtVrsta.Margin = new System.Windows.Forms.Padding(6);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(300, 31);
            this.txtVrsta.TabIndex = 18;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(249, 63);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(300, 31);
            this.txtNaziv.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aktuelna verzija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kompanija vlasnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vrsta tehnologije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Naziv:";
            // 
            // txtVerzija
            // 
            this.txtVerzija.Location = new System.Drawing.Point(247, 281);
            this.txtVerzija.Margin = new System.Windows.Forms.Padding(6);
            this.txtVerzija.Name = "txtVerzija";
            this.txtVerzija.Size = new System.Drawing.Size(300, 31);
            this.txtVerzija.TabIndex = 22;
            // 
            // FrmUnosTehnologije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 462);
            this.Controls.Add(this.txtVerzija);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKompanija);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmUnosTehnologije";
            this.Text = "FrmUnosTehnologije";
            this.Load += new System.EventHandler(this.FrmUnosTehnologije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtKompanija;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerzija;
    }
}