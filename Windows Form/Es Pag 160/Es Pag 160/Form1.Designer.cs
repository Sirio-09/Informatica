namespace Es_Pag_160
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
            this.lst_studenti = new System.Windows.Forms.ListBox();
            this.lbl_studenti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_studenti
            // 
            this.lst_studenti.FormattingEnabled = true;
            this.lst_studenti.Location = new System.Drawing.Point(75, 66);
            this.lst_studenti.Name = "lst_studenti";
            this.lst_studenti.Size = new System.Drawing.Size(246, 225);
            this.lst_studenti.TabIndex = 0;
            // 
            // lbl_studenti
            // 
            this.lbl_studenti.AutoSize = true;
            this.lbl_studenti.Location = new System.Drawing.Point(72, 35);
            this.lbl_studenti.Name = "lbl_studenti";
            this.lbl_studenti.Size = new System.Drawing.Size(46, 13);
            this.lbl_studenti.TabIndex = 2;
            this.lbl_studenti.Text = "Studenti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 319);
            this.Controls.Add(this.lbl_studenti);
            this.Controls.Add(this.lst_studenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_studenti;
        private System.Windows.Forms.Label lbl_studenti;
    }
}

