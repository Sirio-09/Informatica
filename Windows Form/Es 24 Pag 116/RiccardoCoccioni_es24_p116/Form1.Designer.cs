namespace RiccardoCoccioni_es24_p116
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
            this.lblSpecie = new System.Windows.Forms.Label();
            this.lstAnimale = new System.Windows.Forms.ListBox();
            this.lstSpecie = new System.Windows.Forms.ListBox();
            this.lblAnimaleRicercata = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.txtAnimale = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnimale
            // 
            this.lblAnimale.AutoSize = true;
            this.lblAnimale.Location = new System.Drawing.Point(19, 22);
            this.lblAnimale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimale.Name = "lblAnimale";
            this.lblAnimale.Size = new System.Drawing.Size(44, 13);
            this.lblAnimale.TabIndex = 0;
            this.lblAnimale.Text = "Animale";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(200, 22);
            this.lblSpecie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(40, 13);
            this.lblSpecie.TabIndex = 1;
            this.lblSpecie.Text = "Specie";
            // 
            // lstAnimale
            // 
            this.lstAnimale.FormattingEnabled = true;
            this.lstAnimale.Location = new System.Drawing.Point(22, 55);
            this.lstAnimale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAnimale.Name = "lstAnimale";
            this.lstAnimale.Size = new System.Drawing.Size(125, 303);
            this.lstAnimale.TabIndex = 2;
            // 
            // lstSpecie
            // 
            this.lstSpecie.FormattingEnabled = true;
            this.lstSpecie.Location = new System.Drawing.Point(203, 55);
            this.lstSpecie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSpecie.Name = "lstSpecie";
            this.lstSpecie.Size = new System.Drawing.Size(130, 303);
            this.lstSpecie.TabIndex = 3;
            // 
            // lblAnimaleRicercata
            // 
            this.lblAnimaleRicercata.AutoSize = true;
            this.lblAnimaleRicercata.Location = new System.Drawing.Point(383, 55);
            this.lblAnimaleRicercata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimaleRicercata.Name = "lblAnimaleRicercata";
            this.lblAnimaleRicercata.Size = new System.Drawing.Size(47, 13);
            this.lblAnimaleRicercata.TabIndex = 4;
            this.lblAnimaleRicercata.Text = "Animale:";
            this.lblAnimaleRicercata.Click += new System.EventHandler(this.lblAnimaleRicercata_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(440, 97);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(56, 19);
            this.btnCerca.TabIndex = 5;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // txtAnimale
            // 
            this.txtAnimale.Location = new System.Drawing.Point(440, 55);
            this.txtAnimale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnimale.Name = "txtAnimale";
            this.txtAnimale.Size = new System.Drawing.Size(76, 20);
            this.txtAnimale.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 393);
            this.Controls.Add(this.txtAnimale);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lblAnimaleRicercata);
            this.Controls.Add(this.lstSpecie);
            this.Controls.Add(this.lstAnimale);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.lblAnimale);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimale;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.ListBox lstAnimale;
        private System.Windows.Forms.ListBox lstSpecie;
        private System.Windows.Forms.Label lblAnimaleRicercata;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtAnimale;
    }
}

