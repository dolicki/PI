namespace StorageApp
{
    partial class PočetnoSučelje
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artikli = new System.Windows.Forms.Button();
            this.kupci = new System.Windows.Forms.Button();
            this.medjuskladisnice = new System.Windows.Forms.Button();
            this.primke = new System.Windows.Forms.Button();
            this.otpremnice = new System.Windows.Forms.Button();
            this.Izdatnice = new System.Windows.Forms.Button();
            this.zaposlenici = new System.Windows.Forms.Button();
            this.dobavljaci = new System.Windows.Forms.Button();
            this.evidencijaSkladista = new System.Windows.Forms.DataGridView();
            this.Odjava = new System.Windows.Forms.Button();
            this.odabranoSkladiste = new System.Windows.Forms.Label();
            this.Skladišta = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaSkladista)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Skladište1",
            "Skladište2",
            "Skladište3"});
            this.comboBox1.Location = new System.Drawing.Point(104, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skladište";
            // 
            // artikli
            // 
            this.artikli.Location = new System.Drawing.Point(18, 176);
            this.artikli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artikli.Name = "artikli";
            this.artikli.Size = new System.Drawing.Size(105, 37);
            this.artikli.TabIndex = 2;
            this.artikli.Text = "Artikli";
            this.artikli.UseVisualStyleBackColor = true;
            // 
            // kupci
            // 
            this.kupci.Location = new System.Drawing.Point(490, 78);
            this.kupci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kupci.Name = "kupci";
            this.kupci.Size = new System.Drawing.Size(105, 37);
            this.kupci.TabIndex = 3;
            this.kupci.Text = "Kupci";
            this.kupci.UseVisualStyleBackColor = true;
            // 
            // medjuskladisnice
            // 
            this.medjuskladisnice.Location = new System.Drawing.Point(18, 425);
            this.medjuskladisnice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medjuskladisnice.Name = "medjuskladisnice";
            this.medjuskladisnice.Size = new System.Drawing.Size(105, 37);
            this.medjuskladisnice.TabIndex = 4;
            this.medjuskladisnice.Text = "Međuskladišnice";
            this.medjuskladisnice.UseVisualStyleBackColor = true;
            // 
            // primke
            // 
            this.primke.Location = new System.Drawing.Point(18, 362);
            this.primke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.primke.Name = "primke";
            this.primke.Size = new System.Drawing.Size(105, 37);
            this.primke.TabIndex = 5;
            this.primke.Text = "Primke";
            this.primke.UseVisualStyleBackColor = true;
            // 
            // otpremnice
            // 
            this.otpremnice.Location = new System.Drawing.Point(18, 238);
            this.otpremnice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.otpremnice.Name = "otpremnice";
            this.otpremnice.Size = new System.Drawing.Size(105, 37);
            this.otpremnice.TabIndex = 6;
            this.otpremnice.Text = "Otpremnice";
            this.otpremnice.UseVisualStyleBackColor = true;
            this.otpremnice.Click += new System.EventHandler(this.otpremnice_Click);
            // 
            // Izdatnice
            // 
            this.Izdatnice.Location = new System.Drawing.Point(18, 299);
            this.Izdatnice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Izdatnice.Name = "Izdatnice";
            this.Izdatnice.Size = new System.Drawing.Size(105, 37);
            this.Izdatnice.TabIndex = 7;
            this.Izdatnice.Text = "Izdatnice";
            this.Izdatnice.UseVisualStyleBackColor = true;
            // 
            // zaposlenici
            // 
            this.zaposlenici.Location = new System.Drawing.Point(620, 77);
            this.zaposlenici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zaposlenici.Name = "zaposlenici";
            this.zaposlenici.Size = new System.Drawing.Size(105, 37);
            this.zaposlenici.TabIndex = 8;
            this.zaposlenici.Text = "Zaposlenici";
            this.zaposlenici.UseVisualStyleBackColor = true;
            // 
            // dobavljaci
            // 
            this.dobavljaci.Location = new System.Drawing.Point(364, 76);
            this.dobavljaci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dobavljaci.Name = "dobavljaci";
            this.dobavljaci.Size = new System.Drawing.Size(105, 37);
            this.dobavljaci.TabIndex = 9;
            this.dobavljaci.Text = "Dobavljači";
            this.dobavljaci.UseVisualStyleBackColor = true;
            // 
            // evidencijaSkladista
            // 
            this.evidencijaSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evidencijaSkladista.Location = new System.Drawing.Point(158, 176);
            this.evidencijaSkladista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evidencijaSkladista.Name = "evidencijaSkladista";
            this.evidencijaSkladista.RowTemplate.Height = 24;
            this.evidencijaSkladista.Size = new System.Drawing.Size(568, 285);
            this.evidencijaSkladista.TabIndex = 10;
            // 
            // Odjava
            // 
            this.Odjava.Location = new System.Drawing.Point(674, 24);
            this.Odjava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(51, 25);
            this.Odjava.TabIndex = 11;
            this.Odjava.Text = "Odjava";
            this.Odjava.UseVisualStyleBackColor = true;
            // 
            // odabranoSkladiste
            // 
            this.odabranoSkladiste.AutoSize = true;
            this.odabranoSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabranoSkladiste.Location = new System.Drawing.Point(17, 88);
            this.odabranoSkladiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.odabranoSkladiste.Name = "odabranoSkladiste";
            this.odabranoSkladiste.Size = new System.Drawing.Size(110, 26);
            this.odabranoSkladiste.TabIndex = 12;
            this.odabranoSkladiste.Text = "Skladište";
            // 
            // Skladišta
            // 
            this.Skladišta.Location = new System.Drawing.Point(237, 76);
            this.Skladišta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Skladišta.Name = "Skladišta";
            this.Skladišta.Size = new System.Drawing.Size(105, 37);
            this.Skladišta.TabIndex = 13;
            this.Skladišta.Text = "Skladišta";
            this.Skladišta.UseVisualStyleBackColor = true;
            this.Skladišta.Click += new System.EventHandler(this.Skladišta_Click);
            // 
            // dodaj
            // 
            this.dodaj.BackgroundImage = global::StorageApp.Properties.Resources.add;
            this.dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodaj.Location = new System.Drawing.Point(158, 142);
            this.dodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(26, 28);
            this.dodaj.TabIndex = 14;
            this.dodaj.UseVisualStyleBackColor = true;
            // 
            // PočetnoSučelje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 483);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.Skladišta);
            this.Controls.Add(this.odabranoSkladiste);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.evidencijaSkladista);
            this.Controls.Add(this.dobavljaci);
            this.Controls.Add(this.zaposlenici);
            this.Controls.Add(this.Izdatnice);
            this.Controls.Add(this.otpremnice);
            this.Controls.Add(this.primke);
            this.Controls.Add(this.medjuskladisnice);
            this.Controls.Add(this.kupci);
            this.Controls.Add(this.artikli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PočetnoSučelje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageApp";
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaSkladista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button artikli;
        private System.Windows.Forms.Button kupci;
        private System.Windows.Forms.Button medjuskladisnice;
        private System.Windows.Forms.Button primke;
        private System.Windows.Forms.Button otpremnice;
        private System.Windows.Forms.Button Izdatnice;
        private System.Windows.Forms.Button zaposlenici;
        private System.Windows.Forms.Button dobavljaci;
        private System.Windows.Forms.DataGridView evidencijaSkladista;
        private System.Windows.Forms.Button Odjava;
        private System.Windows.Forms.Label odabranoSkladiste;
        private System.Windows.Forms.Button Skladišta;
        private System.Windows.Forms.Button dodaj;
    }
}