namespace StorageApp
{
    partial class Prijava
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
            this.prijaviSe = new System.Windows.Forms.Button();
            this.unosKorIme = new System.Windows.Forms.TextBox();
            this.unosPW = new System.Windows.Forms.TextBox();
            this.korIme = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prijaviSe
            // 
            this.prijaviSe.Location = new System.Drawing.Point(33, 167);
            this.prijaviSe.Name = "prijaviSe";
            this.prijaviSe.Size = new System.Drawing.Size(248, 40);
            this.prijaviSe.TabIndex = 0;
            this.prijaviSe.Text = "Prijavi se";
            this.prijaviSe.UseVisualStyleBackColor = true;
            this.prijaviSe.Click += new System.EventHandler(this.prijaviSe_Click);
            // 
            // unosKorIme
            // 
            this.unosKorIme.Location = new System.Drawing.Point(150, 48);
            this.unosKorIme.Multiline = true;
            this.unosKorIme.Name = "unosKorIme";
            this.unosKorIme.Size = new System.Drawing.Size(131, 30);
            this.unosKorIme.TabIndex = 1;
            // 
            // unosPW
            // 
            this.unosPW.Location = new System.Drawing.Point(150, 101);
            this.unosPW.Multiline = true;
            this.unosPW.Name = "unosPW";
            this.unosPW.Size = new System.Drawing.Size(131, 31);
            this.unosPW.TabIndex = 2;
            // 
            // korIme
            // 
            this.korIme.AutoSize = true;
            this.korIme.Location = new System.Drawing.Point(30, 51);
            this.korIme.Name = "korIme";
            this.korIme.Size = new System.Drawing.Size(99, 17);
            this.korIme.TabIndex = 3;
            this.korIme.Text = "Korisničko ime";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Location = new System.Drawing.Point(30, 104);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(57, 17);
            this.lozinka.TabIndex = 4;
            this.lozinka.Text = "Lozinka";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 253);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.unosPW);
            this.Controls.Add(this.unosKorIme);
            this.Controls.Add(this.prijaviSe);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijaviSe;
        private System.Windows.Forms.TextBox unosKorIme;
        private System.Windows.Forms.TextBox unosPW;
        private System.Windows.Forms.Label korIme;
        private System.Windows.Forms.Label lozinka;
    }
}

