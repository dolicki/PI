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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // desije
            // 
            this.desije.Location = new System.Drawing.Point(83, 77);
            this.desije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.desije.Name = "desije";
            this.desije.Size = new System.Drawing.Size(100, 28);
            this.desije.TabIndex = 0;
            this.desije.Text = "button1";
            this.desije.UseVisualStyleBackColor = true;
            // 
            // sadasfa
            // 
            this.sadasfa.FormattingEnabled = true;
            this.sadasfa.Location = new System.Drawing.Point(83, 137);
            this.sadasfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sadasfa.Name = "sadasfa";
            this.sadasfa.Size = new System.Drawing.Size(160, 24);
            this.sadasfa.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sadasfa);
            this.Controls.Add(this.desije);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "s";
            this.Text = "Otpremnica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button desije;
        private System.Windows.Forms.ComboBox sadasfa;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}