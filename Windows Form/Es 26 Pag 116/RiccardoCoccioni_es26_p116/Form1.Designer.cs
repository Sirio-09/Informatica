namespace RiccardoCoccioni_es26_p116
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
            this.lblAnimali = new System.Windows.Forms.Label();
            this.lstAnimali = new System.Windows.Forms.ListBox();
            this.lstSpecie = new System.Windows.Forms.ListBox();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnimali
            // 
            this.lblAnimali.AutoSize = true;
            this.lblAnimali.Location = new System.Drawing.Point(22, 23);
            this.lblAnimali.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimali.Name = "lblAnimali";
            this.lblAnimali.Size = new System.Drawing.Size(40, 13);
            this.lblAnimali.TabIndex = 0;
            this.lblAnimali.Text = "Animali";
            // 
            // lstAnimali
            // 
            this.lstAnimali.FormattingEnabled = true;
            this.lstAnimali.Location = new System.Drawing.Point(25, 53);
            this.lstAnimali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAnimali.Name = "lstAnimali";
            this.lstAnimali.Size = new System.Drawing.Size(113, 251);
            this.lstAnimali.TabIndex = 2;
            // 
            // lstSpecie
            // 
            this.lstSpecie.FormattingEnabled = true;
            this.lstSpecie.Location = new System.Drawing.Point(193, 53);
            this.lstSpecie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSpecie.Name = "lstSpecie";
            this.lstSpecie.Size = new System.Drawing.Size(112, 251);
            this.lstSpecie.TabIndex = 3;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(440, 151);
            this.btnOrdina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(100, 39);
            this.btnOrdina.TabIndex = 4;
            this.btnOrdina.Text = "Ordina per specie";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.lstSpecie);
            this.Controls.Add(this.lstAnimali);
            this.Controls.Add(this.lblAnimali);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimali;
        private System.Windows.Forms.ListBox lstAnimali;
        private System.Windows.Forms.ListBox lstSpecie;
        private System.Windows.Forms.Button btnOrdina;
    }
}

