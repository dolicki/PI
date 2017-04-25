namespace StorageApp
{
    partial class UpravljanjeSkladistima
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
            this.skladisteNaziv = new System.Windows.Forms.Label();
            this.lokacija = new System.Windows.Forms.Label();
            this.velicina = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.nazivSkladistaUnos = new System.Windows.Forms.TextBox();
            this.lokacijaUnos = new System.Windows.Forms.TextBox();
            this.velicinaUnos = new System.Windows.Forms.TextBox();
            this.tipUnos = new System.Windows.Forms.TextBox();
            this.obrisi = new System.Windows.Forms.Button();
            this.azuriraj = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.skladiste = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skladisteNaziv
            // 
            this.skladisteNaziv.AutoSize = true;
            this.skladisteNaziv.Location = new System.Drawing.Point(55, 81);
            this.skladisteNaziv.Name = "skladisteNaziv";
            this.skladisteNaziv.Size = new System.Drawing.Size(102, 17);
            this.skladisteNaziv.TabIndex = 0;
            this.skladisteNaziv.Text = "Naziv skladišta";
            // 
            // lokacija
            // 
            this.lokacija.AutoSize = true;
            this.lokacija.Location = new System.Drawing.Point(97, 117);
            this.lokacija.Name = "lokacija";
            this.lokacija.Size = new System.Drawing.Size(60, 17);
            this.lokacija.TabIndex = 1;
            this.lokacija.Text = "Lokacija";
            // 
            // velicina
            // 
            this.velicina.AutoSize = true;
            this.velicina.Location = new System.Drawing.Point(100, 159);
            this.velicina.Name = "velicina";
            this.velicina.Size = new System.Drawing.Size(57, 17);
            this.velicina.TabIndex = 2;
            this.velicina.Text = "Veličina";
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(129, 195);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(28, 17);
            this.tip.TabIndex = 3;
            this.tip.Text = "Tip";
            // 
            // nazivSkladistaUnos
            // 
            this.nazivSkladistaUnos.Location = new System.Drawing.Point(207, 81);
            this.nazivSkladistaUnos.Name = "nazivSkladistaUnos";
            this.nazivSkladistaUnos.Size = new System.Drawing.Size(178, 22);
            this.nazivSkladistaUnos.TabIndex = 4;
            // 
            // lokacijaUnos
            // 
            this.lokacijaUnos.Location = new System.Drawing.Point(207, 117);
            this.lokacijaUnos.Name = "lokacijaUnos";
            this.lokacijaUnos.Size = new System.Drawing.Size(178, 22);
            this.lokacijaUnos.TabIndex = 5;
            // 
            // velicinaUnos
            // 
            this.velicinaUnos.Location = new System.Drawing.Point(207, 159);
            this.velicinaUnos.Name = "velicinaUnos";
            this.velicinaUnos.Size = new System.Drawing.Size(178, 22);
            this.velicinaUnos.TabIndex = 6;
            // 
            // tipUnos
            // 
            this.tipUnos.Location = new System.Drawing.Point(207, 195);
            this.tipUnos.Name = "tipUnos";
            this.tipUnos.Size = new System.Drawing.Size(178, 22);
            this.tipUnos.TabIndex = 7;
            // 
            // obrisi
            // 
            this.obrisi.Location = new System.Drawing.Point(163, 261);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(109, 36);
            this.obrisi.TabIndex = 8;
            this.obrisi.Text = "Obriši";
            this.obrisi.UseVisualStyleBackColor = true;
            // 
            // azuriraj
            // 
            this.azuriraj.Location = new System.Drawing.Point(48, 261);
            this.azuriraj.Name = "azuriraj";
            this.azuriraj.Size = new System.Drawing.Size(109, 36);
            this.azuriraj.TabIndex = 9;
            this.azuriraj.Text = "Ažuriraj";
            this.azuriraj.UseVisualStyleBackColor = true;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(278, 261);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(109, 36);
            this.dodaj.TabIndex = 10;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            // 
            // skladiste
            // 
            this.skladiste.FormattingEnabled = true;
            this.skladiste.Location = new System.Drawing.Point(207, 43);
            this.skladiste.Name = "skladiste";
            this.skladiste.Size = new System.Drawing.Size(178, 24);
            this.skladiste.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Skladiste";
            // 
            // UpravljanjeSkladistima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(442, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skladiste);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.azuriraj);
            this.Controls.Add(this.obrisi);
            this.Controls.Add(this.tipUnos);
            this.Controls.Add(this.velicinaUnos);
            this.Controls.Add(this.lokacijaUnos);
            this.Controls.Add(this.nazivSkladistaUnos);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.velicina);
            this.Controls.Add(this.lokacija);
            this.Controls.Add(this.skladisteNaziv);
            this.Name = "UpravljanjeSkladistima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje skladištima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label skladisteNaziv;
        private System.Windows.Forms.Label lokacija;
        private System.Windows.Forms.Label velicina;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.TextBox nazivSkladistaUnos;
        private System.Windows.Forms.TextBox lokacijaUnos;
        private System.Windows.Forms.TextBox velicinaUnos;
        private System.Windows.Forms.TextBox tipUnos;
        private System.Windows.Forms.Button obrisi;
        private System.Windows.Forms.Button azuriraj;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.ComboBox skladiste;
        private System.Windows.Forms.Label label2;
    }
}