namespace StorageApp
{
    partial class s
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
            this.desije = new System.Windows.Forms.Button();
            this.sadasfa = new System.Windows.Forms.ComboBox();
            this.fdsf = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // desije
            // 
            this.desije.Location = new System.Drawing.Point(47, 43);
            this.desije.Name = "desije";
            this.desije.Size = new System.Drawing.Size(75, 23);
            this.desije.TabIndex = 0;
            this.desije.Text = "button1";
            this.desije.UseVisualStyleBackColor = true;
            // 
            // sadasfa
            // 
            this.sadasfa.FormattingEnabled = true;
            this.sadasfa.Location = new System.Drawing.Point(62, 93);
            this.sadasfa.Name = "sadasfa";
            this.sadasfa.Size = new System.Drawing.Size(121, 21);
            this.sadasfa.TabIndex = 1;
            // 
            // fdsf
            // 
            this.fdsf.Location = new System.Drawing.Point(147, 45);
            this.fdsf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fdsf.Name = "fdsf";
            this.fdsf.Size = new System.Drawing.Size(56, 19);
            this.fdsf.TabIndex = 2;
            this.fdsf.Text = "button1";
            this.fdsf.UseVisualStyleBackColor = true;
            this.fdsf.Click += new System.EventHandler(this.fdsf_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 150);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fdsf);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sadasfa);
            this.Controls.Add(this.desije);
            this.Name = "s";
            this.Text = "Otpremnica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button desije;
        private System.Windows.Forms.ComboBox sadasfa;

        private System.Windows.Forms.Button fdsf;

        private System.Windows.Forms.ComboBox comboBox1;

    }
}