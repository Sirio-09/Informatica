namespace Es_19_Pag_116
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
            this.lbl_cantanti = new System.Windows.Forms.Label();
            this.lbl_canzoni = new System.Windows.Forms.Label();
            this.lst_cantanti = new System.Windows.Forms.ListBox();
            this.lst_canzoni = new System.Windows.Forms.ListBox();
            this.lnl_nomeCantante = new System.Windows.Forms.Label();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.txt_nomeCantante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_cantanti
            // 
            this.lbl_cantanti.AutoSize = true;
            this.lbl_cantanti.Location = new System.Drawing.Point(39, 38);
            this.lbl_cantanti.Name = "lbl_cantanti";
            this.lbl_cantanti.Size = new System.Drawing.Size(46, 13);
            this.lbl_cantanti.TabIndex = 0;
            this.lbl_cantanti.Text = "Cantanti";
            this.lbl_cantanti.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_canzoni
            // 
            this.lbl_canzoni.AutoSize = true;
            this.lbl_canzoni.Location = new System.Drawing.Point(203, 38);
            this.lbl_canzoni.Name = "lbl_canzoni";
            this.lbl_canzoni.Size = new System.Drawing.Size(45, 13);
            this.lbl_canzoni.TabIndex = 1;
            this.lbl_canzoni.Text = "Canzoni";
            // 
            // lst_cantanti
            // 
            this.lst_cantanti.FormattingEnabled = true;
            this.lst_cantanti.Location = new System.Drawing.Point(42, 73);
            this.lst_cantanti.Name = "lst_cantanti";
            this.lst_cantanti.Size = new System.Drawing.Size(120, 212);
            this.lst_cantanti.TabIndex = 3;
            this.lst_cantanti.SelectedIndexChanged += new System.EventHandler(this.lst_cantanti_SelectedIndexChanged);
            // 
            // lst_canzoni
            // 
            this.lst_canzoni.FormattingEnabled = true;
            this.lst_canzoni.Location = new System.Drawing.Point(206, 73);
            this.lst_canzoni.Name = "lst_canzoni";
            this.lst_canzoni.Size = new System.Drawing.Size(120, 212);
            this.lst_canzoni.TabIndex = 4;
            // 
            // lnl_nomeCantante
            // 
            this.lnl_nomeCantante.AutoSize = true;
            this.lnl_nomeCantante.Location = new System.Drawing.Point(375, 126);
            this.lnl_nomeCantante.Name = "lnl_nomeCantante";
            this.lnl_nomeCantante.Size = new System.Drawing.Size(81, 13);
            this.lnl_nomeCantante.TabIndex = 5;
            this.lnl_nomeCantante.Text = "Nome Cantante";
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(378, 197);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(75, 23);
            this.btn_cerca.TabIndex = 6;
            this.btn_cerca.Text = "Cerca";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // txt_nomeCantante
            // 
            this.txt_nomeCantante.Location = new System.Drawing.Point(378, 152);
            this.txt_nomeCantante.Name = "txt_nomeCantante";
            this.txt_nomeCantante.Size = new System.Drawing.Size(100, 20);
            this.txt_nomeCantante.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 331);
            this.Controls.Add(this.txt_nomeCantante);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.lnl_nomeCantante);
            this.Controls.Add(this.lst_canzoni);
            this.Controls.Add(this.lst_cantanti);
            this.Controls.Add(this.lbl_canzoni);
            this.Controls.Add(this.lbl_cantanti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantanti;
        private System.Windows.Forms.Label lbl_canzoni;
        private System.Windows.Forms.ListBox lst_cantanti;
        private System.Windows.Forms.ListBox lst_canzoni;
        private System.Windows.Forms.Label lnl_nomeCantante;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.TextBox txt_nomeCantante;
    }
}

