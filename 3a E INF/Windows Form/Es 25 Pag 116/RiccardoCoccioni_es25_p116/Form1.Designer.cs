namespace RiccardoCoccioni_es25_p116
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
            this.lblAnimale = new System.Windows.Forms.Label();
            this.lstAnimale = new System.Windows.Forms.ListBox();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.lstSpecie = new System.Windows.Forms.ListBox();
            this.lblAnimeleRicercata = new System.Windows.Forms.Label();
            this.txtAnimale = new System.Windows.Forms.TextBox();
            this.btnAnimale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnimale
            // 
            this.lblAnimale.AutoSize = true;
            this.lblAnimale.Location = new System.Drawing.Point(17, 26);
            this.lblAnimale.Name = "lblAnimale";
            this.lblAnimale.Size = new System.Drawing.Size(44, 13);
            this.lblAnimale.TabIndex = 1;
            this.lblAnimale.Text = "Animale";
            // 
            // lstAnimale
            // 
            this.lstAnimale.FormattingEnabled = true;
            this.lstAnimale.Location = new System.Drawing.Point(20, 54);
            this.lstAnimale.Name = "lstAnimale";
            this.lstAnimale.Size = new System.Drawing.Size(102, 290);
            this.lstAnimale.TabIndex = 2;
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(183, 26);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(40, 13);
            this.lblSpecie.TabIndex = 3;
            this.lblSpecie.Text = "Specie";
            // 
            // lstSpecie
            // 
            this.lstSpecie.FormattingEnabled = true;
            this.lstSpecie.Location = new System.Drawing.Point(186, 54);
            this.lstSpecie.Name = "lstSpecie";
            this.lstSpecie.Size = new System.Drawing.Size(102, 290);
            this.lstSpecie.TabIndex = 4;
            // 
            // lblAnimeleRicercata
            // 
            this.lblAnimeleRicercata.AutoSize = true;
            this.lblAnimeleRicercata.Location = new System.Drawing.Point(347, 54);
            this.lblAnimeleRicercata.Name = "lblAnimeleRicercata";
            this.lblAnimeleRicercata.Size = new System.Drawing.Size(47, 13);
            this.lblAnimeleRicercata.TabIndex = 6;
            this.lblAnimeleRicercata.Text = "Animale:";
            // 
            // txtAnimale
            // 
            this.txtAnimale.Location = new System.Drawing.Point(400, 51);
            this.txtAnimale.Name = "txtAnimale";
            this.txtAnimale.Size = new System.Drawing.Size(100, 20);
            this.txtAnimale.TabIndex = 7;
            // 
            // btnAnimale
            // 
            this.btnAnimale.Location = new System.Drawing.Point(350, 117);
            this.btnAnimale.Name = "btnAnimale";
            this.btnAnimale.Size = new System.Drawing.Size(75, 23);
            this.btnAnimale.TabIndex = 8;
            this.btnAnimale.Text = "Cerca";
            this.btnAnimale.UseVisualStyleBackColor = true;
            this.btnAnimale.Click += new System.EventHandler(this.btnAnimale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAnimale);
            this.Controls.Add(this.txtAnimale);
            this.Controls.Add(this.lblAnimeleRicercata);
            this.Controls.Add(this.lstSpecie);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.lstAnimale);
            this.Controls.Add(this.lblAnimale);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimale;
        private System.Windows.Forms.ListBox lstAnimale;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.ListBox lstSpecie;
        private System.Windows.Forms.Label lblAnimeleRicercata;
        private System.Windows.Forms.TextBox txtAnimale;
        private System.Windows.Forms.Button btnAnimale;
    }
}

