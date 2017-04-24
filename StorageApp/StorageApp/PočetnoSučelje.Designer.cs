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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ursus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaSkladista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Skladište1",
            "Skladište2",
            "Skladište3"});
            this.comboBox1.Location = new System.Drawing.Point(139, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skladište";
            // 
            // artikli
            // 
            this.artikli.Location = new System.Drawing.Point(24, 217);
            this.artikli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.artikli.Name = "artikli";
            this.artikli.Size = new System.Drawing.Size(140, 46);
            this.artikli.TabIndex = 2;
            this.artikli.Text = "Artikli";
            this.artikli.UseVisualStyleBackColor = true;
            // 
            // kupci
            // 
            this.kupci.Location = new System.Drawing.Point(653, 96);
            this.kupci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kupci.Name = "kupci";
            this.kupci.Size = new System.Drawing.Size(140, 46);
            this.kupci.TabIndex = 3;
            this.kupci.Text = "Kupci";
            this.kupci.UseVisualStyleBackColor = true;
            // 
            // medjuskladisnice
            // 
            this.medjuskladisnice.Location = new System.Drawing.Point(24, 523);
            this.medjuskladisnice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medjuskladisnice.Name = "medjuskladisnice";
            this.medjuskladisnice.Size = new System.Drawing.Size(140, 46);
            this.medjuskladisnice.TabIndex = 4;
            this.medjuskladisnice.Text = "Međuskladišnice";
            this.medjuskladisnice.UseVisualStyleBackColor = true;
            // 
            // primke
            // 
            this.primke.Location = new System.Drawing.Point(24, 446);
            this.primke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.primke.Name = "primke";
            this.primke.Size = new System.Drawing.Size(140, 46);
            this.primke.TabIndex = 5;
            this.primke.Text = "Primke";
            this.primke.UseVisualStyleBackColor = true;
            // 
            // otpremnice
            // 
            this.otpremnice.Location = new System.Drawing.Point(24, 293);
            this.otpremnice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otpremnice.Name = "otpremnice";
            this.otpremnice.Size = new System.Drawing.Size(140, 46);
            this.otpremnice.TabIndex = 6;
            this.otpremnice.Text = "Otpremnice";
            this.otpremnice.UseVisualStyleBackColor = true;
            this.otpremnice.Click += new System.EventHandler(this.otpremnice_Click);
            // 
            // Izdatnice
            // 
            this.Izdatnice.Location = new System.Drawing.Point(24, 368);
            this.Izdatnice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Izdatnice.Name = "Izdatnice";
            this.Izdatnice.Size = new System.Drawing.Size(140, 46);
            this.Izdatnice.TabIndex = 7;
            this.Izdatnice.Text = "Izdatnice";
            this.Izdatnice.UseVisualStyleBackColor = true;
            // 
            // zaposlenici
            // 
            this.zaposlenici.Location = new System.Drawing.Point(827, 95);
            this.zaposlenici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zaposlenici.Name = "zaposlenici";
            this.zaposlenici.Size = new System.Drawing.Size(140, 46);
            this.zaposlenici.TabIndex = 8;
            this.zaposlenici.Text = "Zaposlenici";
            this.zaposlenici.UseVisualStyleBackColor = true;
            // 
            // dobavljaci
            // 
            this.dobavljaci.Location = new System.Drawing.Point(485, 94);
            this.dobavljaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobavljaci.Name = "dobavljaci";
            this.dobavljaci.Size = new System.Drawing.Size(140, 46);
            this.dobavljaci.TabIndex = 9;
            this.dobavljaci.Text = "Dobavljači";
            this.dobavljaci.UseVisualStyleBackColor = true;
            // 
            // evidencijaSkladista
            // 
            this.evidencijaSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evidencijaSkladista.Location = new System.Drawing.Point(211, 217);
            this.evidencijaSkladista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evidencijaSkladista.Name = "evidencijaSkladista";
            this.evidencijaSkladista.RowTemplate.Height = 24;
            this.evidencijaSkladista.Size = new System.Drawing.Size(757, 351);
            this.evidencijaSkladista.TabIndex = 10;
            // 
            // Odjava
            // 
            this.Odjava.Location = new System.Drawing.Point(899, 30);
            this.Odjava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(68, 31);
            this.Odjava.TabIndex = 11;
            this.Odjava.Text = "Odjava";
            this.Odjava.UseVisualStyleBackColor = true;
            // 
            // odabranoSkladiste
            // 
            this.odabranoSkladiste.AutoSize = true;
            this.odabranoSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odabranoSkladiste.Location = new System.Drawing.Point(23, 108);
            this.odabranoSkladiste.Name = "odabranoSkladiste";
            this.odabranoSkladiste.Size = new System.Drawing.Size(141, 32);
            this.odabranoSkladiste.TabIndex = 12;
            this.odabranoSkladiste.Text = "Skladište";
            // 
            // Skladišta
            // 
            this.Skladišta.Location = new System.Drawing.Point(316, 94);
            this.Skladišta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Skladišta.Name = "Skladišta";
            this.Skladišta.Size = new System.Drawing.Size(140, 46);
            this.Skladišta.TabIndex = 13;
            this.Skladišta.Text = "Skladišta";
            this.Skladišta.UseVisualStyleBackColor = true;
            this.Skladišta.Click += new System.EventHandler(this.Skladišta_Click);
            // 
            // dodaj
            // 
            this.dodaj.BackgroundImage = global::StorageApp.Properties.Resources.add;
            this.dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodaj.Location = new System.Drawing.Point(211, 175);
            this.dodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(35, 34);
            this.dodaj.TabIndex = 14;
            this.dodaj.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(352, 175);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ursus
            // 
            this.Ursus.AutoSize = true;
            this.Ursus.Location = new System.Drawing.Point(763, 223);
            this.Ursus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ursus.Name = "Ursus";
            this.Ursus.Size = new System.Drawing.Size(46, 17);
            this.Ursus.TabIndex = 16;
            this.Ursus.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(953, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // PočetnoSučelje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ursus);
            this.Controls.Add(this.comboBox2);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PočetnoSučelje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageApp";
            this.Load += new System.EventHandler(this.PočetnoSučelje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaSkladista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label Ursus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}