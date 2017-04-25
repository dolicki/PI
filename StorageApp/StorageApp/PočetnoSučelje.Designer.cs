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
            this.odabirSkladista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artikli = new System.Windows.Forms.Button();
            this.kupci = new System.Windows.Forms.Button();
            this.medjuskladisnice = new System.Windows.Forms.Button();
            this.primke = new System.Windows.Forms.Button();
            this.otpremnice = new System.Windows.Forms.Button();
            this.izdatnice = new System.Windows.Forms.Button();
            this.zaposlenici = new System.Windows.Forms.Button();
            this.dobavljaci = new System.Windows.Forms.Button();
            this.evidencijaSkladista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odjava = new System.Windows.Forms.Button();
            this.odabranoSkladiste = new System.Windows.Forms.Label();
            this.skladista = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.pregled = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaSkladista)).BeginInit();
            this.SuspendLayout();
            // 
            // odabirSkladista
            // 
            this.odabirSkladista.FormattingEnabled = true;
            this.odabirSkladista.Items.AddRange(new object[] {
            "Skladište1",
            "Skladište2",
            "Skladište3"});
            this.odabirSkladista.Location = new System.Drawing.Point(139, 37);
            this.odabirSkladista.Name = "odabirSkladista";
            this.odabirSkladista.Size = new System.Drawing.Size(194, 24);
            this.odabirSkladista.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skladište";
            // 
            // artikli
            // 
            this.artikli.Location = new System.Drawing.Point(24, 217);
            this.artikli.Name = "artikli";
            this.artikli.Size = new System.Drawing.Size(140, 45);
            this.artikli.TabIndex = 2;
            this.artikli.Text = "Artikli";
            this.artikli.UseVisualStyleBackColor = true;
            this.artikli.Click += new System.EventHandler(this.artikli_Click);
            // 
            // kupci
            // 
            this.kupci.Location = new System.Drawing.Point(655, 96);
            this.kupci.Name = "kupci";
            this.kupci.Size = new System.Drawing.Size(140, 45);
            this.kupci.TabIndex = 3;
            this.kupci.Text = "Kupci";
            this.kupci.UseVisualStyleBackColor = true;
            this.kupci.Click += new System.EventHandler(this.kupci_Click);
            // 
            // medjuskladisnice
            // 
            this.medjuskladisnice.Location = new System.Drawing.Point(24, 523);
            this.medjuskladisnice.Name = "medjuskladisnice";
            this.medjuskladisnice.Size = new System.Drawing.Size(140, 45);
            this.medjuskladisnice.TabIndex = 4;
            this.medjuskladisnice.Text = "Međuskladišnice";
            this.medjuskladisnice.UseVisualStyleBackColor = true;
            this.medjuskladisnice.Click += new System.EventHandler(this.medjuskladisnice_Click);
            // 
            // primke
            // 
            this.primke.Location = new System.Drawing.Point(24, 446);
            this.primke.Name = "primke";
            this.primke.Size = new System.Drawing.Size(140, 45);
            this.primke.TabIndex = 5;
            this.primke.Text = "Primke";
            this.primke.UseVisualStyleBackColor = true;
            this.primke.Click += new System.EventHandler(this.primke_Click);
            // 
            // otpremnice
            // 
            this.otpremnice.Location = new System.Drawing.Point(24, 293);
            this.otpremnice.Name = "otpremnice";
            this.otpremnice.Size = new System.Drawing.Size(140, 45);
            this.otpremnice.TabIndex = 6;
            this.otpremnice.Text = "Otpremnice";
            this.otpremnice.UseVisualStyleBackColor = true;
            this.otpremnice.Click += new System.EventHandler(this.otpremnice_Click);
            // 
            // izdatnice
            // 
            this.izdatnice.Location = new System.Drawing.Point(24, 368);
            this.izdatnice.Name = "izdatnice";
            this.izdatnice.Size = new System.Drawing.Size(140, 45);
            this.izdatnice.TabIndex = 7;
            this.izdatnice.Text = "Izdatnice";
            this.izdatnice.UseVisualStyleBackColor = true;
            this.izdatnice.Click += new System.EventHandler(this.izdatnice_Click);
            // 
            // zaposlenici
            // 
            this.zaposlenici.Location = new System.Drawing.Point(827, 95);
            this.zaposlenici.Name = "zaposlenici";
            this.zaposlenici.Size = new System.Drawing.Size(140, 45);
            this.zaposlenici.TabIndex = 8;
            this.zaposlenici.Text = "Zaposlenici";
            this.zaposlenici.UseVisualStyleBackColor = true;
            // 
            // dobavljaci
            // 
            this.dobavljaci.Location = new System.Drawing.Point(487, 94);
            this.dobavljaci.Name = "dobavljaci";
            this.dobavljaci.Size = new System.Drawing.Size(140, 45);
            this.dobavljaci.TabIndex = 9;
            this.dobavljaci.Text = "Dobavljači";
            this.dobavljaci.UseVisualStyleBackColor = true;
            // 
            // evidencijaSkladista
            // 
            this.evidencijaSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evidencijaSkladista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.evidencijaSkladista.Location = new System.Drawing.Point(210, 217);
            this.evidencijaSkladista.Name = "evidencijaSkladista";
            this.evidencijaSkladista.ReadOnly = true;
            this.evidencijaSkladista.RowTemplate.Height = 24;
            this.evidencijaSkladista.Size = new System.Drawing.Size(757, 351);
            this.evidencijaSkladista.TabIndex = 10;
            this.evidencijaSkladista.SelectionChanged += new System.EventHandler(this.evidencijaSkladista_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // odjava
            // 
            this.odjava.Location = new System.Drawing.Point(899, 37);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(68, 31);
            this.odjava.TabIndex = 11;
            this.odjava.Text = "Odjava";
            this.odjava.UseVisualStyleBackColor = true;
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
            // skladista
            // 
            this.skladista.Location = new System.Drawing.Point(316, 94);
            this.skladista.Name = "skladista";
            this.skladista.Size = new System.Drawing.Size(140, 46);
            this.skladista.TabIndex = 13;
            this.skladista.Text = "Skladišta";
            this.skladista.UseVisualStyleBackColor = true;
            this.skladista.Click += new System.EventHandler(this.Skladišta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(827, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 18;
            this.button2.Text = "Provjera artikala";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // print
            // 
            this.print.BackgroundImage = global::StorageApp.Properties.Resources.print;
            this.print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print.Location = new System.Drawing.Point(360, 176);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(35, 35);
            this.print.TabIndex = 17;
            this.print.UseVisualStyleBackColor = true;
            // 
            // pregled
            // 
            this.pregled.BackgroundImage = global::StorageApp.Properties.Resources.view;
            this.pregled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pregled.Location = new System.Drawing.Point(311, 175);
            this.pregled.Name = "pregled";
            this.pregled.Size = new System.Drawing.Size(35, 35);
            this.pregled.TabIndex = 16;
            this.pregled.UseVisualStyleBackColor = true;
            this.pregled.Click += new System.EventHandler(this.pregled_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::StorageApp.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(260, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dodaj
            // 
            this.dodaj.BackgroundImage = global::StorageApp.Properties.Resources.add;
            this.dodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dodaj.Location = new System.Drawing.Point(210, 175);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(35, 35);
            this.dodaj.TabIndex = 14;
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // PočetnoSučelje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1019, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.print);
            this.Controls.Add(this.pregled);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.skladista);
            this.Controls.Add(this.odabranoSkladiste);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.evidencijaSkladista);
            this.Controls.Add(this.dobavljaci);
            this.Controls.Add(this.zaposlenici);
            this.Controls.Add(this.izdatnice);
            this.Controls.Add(this.otpremnice);
            this.Controls.Add(this.primke);
            this.Controls.Add(this.medjuskladisnice);
            this.Controls.Add(this.kupci);
            this.Controls.Add(this.artikli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odabirSkladista);
            this.Name = "PočetnoSučelje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageApp";
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaSkladista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox odabirSkladista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button artikli;
        private System.Windows.Forms.Button kupci;
        private System.Windows.Forms.Button medjuskladisnice;
        private System.Windows.Forms.Button primke;
        private System.Windows.Forms.Button otpremnice;
        private System.Windows.Forms.Button izdatnice;
        private System.Windows.Forms.Button zaposlenici;
        private System.Windows.Forms.Button dobavljaci;
        private System.Windows.Forms.DataGridView evidencijaSkladista;
        private System.Windows.Forms.Button odjava;
        private System.Windows.Forms.Label odabranoSkladiste;
        private System.Windows.Forms.Button skladista;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pregled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button button2;
    }
}