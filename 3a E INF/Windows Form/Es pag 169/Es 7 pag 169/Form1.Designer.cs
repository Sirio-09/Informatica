namespace Es_7_pag_169
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
            this.btn_leggi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_leggi
            // 
            this.btn_leggi.Location = new System.Drawing.Point(52, 51);
            this.btn_leggi.Name = "btn_leggi";
            this.btn_leggi.Size = new System.Drawing.Size(75, 23);
            this.btn_leggi.TabIndex = 0;
            this.btn_leggi.Text = "Leggi File";
            this.btn_leggi.UseVisualStyleBackColor = true;
            this.btn_leggi.Click += new System.EventHandler(this.btn_leggi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 122);
            this.Controls.Add(this.btn_leggi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_leggi;
    }
}

