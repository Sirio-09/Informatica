namespace Es_27_Pag_116
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
            this.lst_animali = new System.Windows.Forms.ListBox();
            this.lst_specie = new System.Windows.Forms.ListBox();
            this.lst_specieAnimali = new System.Windows.Forms.ListBox();
            this.btn_visualizza = new System.Windows.Forms.Button();
            this.lbl_animali = new System.Windows.Forms.Label();
            this.lbl_specie = new System.Windows.Forms.Label();
            this.lnl_animaliSpecie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_animali
            // 
            this.lst_animali.FormattingEnabled = true;
            this.lst_animali.Location = new System.Drawing.Point(40, 65);
            this.lst_animali.Name = "lst_animali";
            this.lst_animali.Size = new System.Drawing.Size(131, 290);
            this.lst_animali.TabIndex = 0;
            // 
            // lst_specie
            // 
            this.lst_specie.FormattingEnabled = true;
            this.lst_specie.Location = new System.Drawing.Point(214, 65);
            this.lst_specie.Name = "lst_specie";
            this.lst_specie.Size = new System.Drawing.Size(133, 290);
            this.lst_specie.TabIndex = 1;
            // 
            // lst_specieAnimali
            // 
            this.lst_specieAnimali.FormattingEnabled = true;
            this.lst_specieAnimali.Location = new System.Drawing.Point(406, 65);
            this.lst_specieAnimali.Name = "lst_specieAnimali";
            this.lst_specieAnimali.Size = new System.Drawing.Size(133, 290);
            this.lst_specieAnimali.TabIndex = 2;
            // 
            // btn_visualizza
            // 
            this.btn_visualizza.Location = new System.Drawing.Point(583, 168);
            this.btn_visualizza.Name = "btn_visualizza";
            this.btn_visualizza.Size = new System.Drawing.Size(98, 41);
            this.btn_visualizza.TabIndex = 3;
            this.btn_visualizza.Text = "Visualizza";
            this.btn_visualizza.UseVisualStyleBackColor = true;
            this.btn_visualizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_animali
            // 
            this.lbl_animali.AutoSize = true;
            this.lbl_animali.Location = new System.Drawing.Point(40, 30);
            this.lbl_animali.Name = "lbl_animali";
            this.lbl_animali.Size = new System.Drawing.Size(40, 13);
            this.lbl_animali.TabIndex = 4;
            this.lbl_animali.Text = "Animali";
            // 
            // lbl_specie
            // 
            this.lbl_specie.AutoSize = true;
            this.lbl_specie.Location = new System.Drawing.Point(211, 30);
            this.lbl_specie.Name = "lbl_specie";
            this.lbl_specie.Size = new System.Drawing.Size(40, 13);
            this.lbl_specie.TabIndex = 5;
            this.lbl_specie.Text = "Specie";
            // 
            // lnl_animaliSpecie
            // 
            this.lnl_animaliSpecie.AutoSize = true;
            this.lnl_animaliSpecie.Location = new System.Drawing.Point(403, 30);
            this.lnl_animaliSpecie.Name = "lnl_animaliSpecie";
            this.lnl_animaliSpecie.Size = new System.Drawing.Size(116, 13);
            this.lnl_animaliSpecie.TabIndex = 6;
            this.lnl_animaliSpecie.Text = "Specie Con Più Animali";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 386);
            this.Controls.Add(this.lnl_animaliSpecie);
            this.Controls.Add(this.lbl_specie);
            this.Controls.Add(this.lbl_animali);
            this.Controls.Add(this.btn_visualizza);
            this.Controls.Add(this.lst_specieAnimali);
            this.Controls.Add(this.lst_specie);
            this.Controls.Add(this.lst_animali);
            this.Name = "Form1";
            this.Text = "Specie Animali Maggiori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_animali;
        private System.Windows.Forms.ListBox lst_specie;
        private System.Windows.Forms.ListBox lst_specieAnimali;
        private System.Windows.Forms.Button btn_visualizza;
        private System.Windows.Forms.Label lbl_animali;
        private System.Windows.Forms.Label lbl_specie;
        private System.Windows.Forms.Label lnl_animaliSpecie;
    }
}

