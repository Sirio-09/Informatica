namespace Es_Pag_168
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_scrivi = new System.Windows.Forms.Button();
            this.btn_leggi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_scrivi
            // 
            this.btn_scrivi.Location = new System.Drawing.Point(43, 45);
            this.btn_scrivi.Name = "btn_scrivi";
            this.btn_scrivi.Size = new System.Drawing.Size(75, 33);
            this.btn_scrivi.TabIndex = 0;
            this.btn_scrivi.Text = "Scrivi File";
            this.btn_scrivi.UseVisualStyleBackColor = true;
            this.btn_scrivi.Click += new System.EventHandler(this.btn_scrivi_Click);
            // 
            // btn_leggi
            // 
            this.btn_leggi.Location = new System.Drawing.Point(143, 45);
            this.btn_leggi.Name = "btn_leggi";
            this.btn_leggi.Size = new System.Drawing.Size(75, 33);
            this.btn_leggi.TabIndex = 1;
            this.btn_leggi.Text = "Leggi File";
            this.btn_leggi.UseVisualStyleBackColor = true;
            this.btn_leggi.Click += new System.EventHandler(this.btn_leggi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 119);
            this.Controls.Add(this.btn_leggi);
            this.Controls.Add(this.btn_scrivi);
            this.Name = "Form1";
            this.Text = "Carica File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_scrivi;
        private System.Windows.Forms.Button btn_leggi;
    }
}

