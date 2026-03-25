namespace Es_1_Pag_150
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
            this.lst_cognomi = new System.Windows.Forms.ListBox();
            this.lbl_cognomi = new System.Windows.Forms.Label();
            this.lst_turni = new System.Windows.Forms.ListBox();
            this.lbl_turni = new System.Windows.Forms.Label();
            this.btn_sorteggia = new System.Windows.Forms.Button();
            this.txt_gruppi = new System.Windows.Forms.TextBox();
            this.lbl_gruppi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_cognomi
            // 
            this.lst_cognomi.FormattingEnabled = true;
            this.lst_cognomi.Location = new System.Drawing.Point(30, 66);
            this.lst_cognomi.Name = "lst_cognomi";
            this.lst_cognomi.Size = new System.Drawing.Size(120, 212);
            this.lst_cognomi.TabIndex = 0;
            // 
            // lbl_cognomi
            // 
            this.lbl_cognomi.AutoSize = true;
            this.lbl_cognomi.Location = new System.Drawing.Point(27, 32);
            this.lbl_cognomi.Name = "lbl_cognomi";
            this.lbl_cognomi.Size = new System.Drawing.Size(48, 13);
            this.lbl_cognomi.TabIndex = 1;
            this.lbl_cognomi.Text = "Cognomi";
            // 
            // lst_turni
            // 
            this.lst_turni.FormattingEnabled = true;
            this.lst_turni.Location = new System.Drawing.Point(201, 66);
            this.lst_turni.Name = "lst_turni";
            this.lst_turni.Size = new System.Drawing.Size(120, 212);
            this.lst_turni.TabIndex = 2;
            // 
            // lbl_turni
            // 
            this.lbl_turni.AutoSize = true;
            this.lbl_turni.Location = new System.Drawing.Point(198, 32);
            this.lbl_turni.Name = "lbl_turni";
            this.lbl_turni.Size = new System.Drawing.Size(31, 13);
            this.lbl_turni.TabIndex = 3;
            this.lbl_turni.Text = "Turni";
            // 
            // btn_sorteggia
            // 
            this.btn_sorteggia.Location = new System.Drawing.Point(346, 138);
            this.btn_sorteggia.Name = "btn_sorteggia";
            this.btn_sorteggia.Size = new System.Drawing.Size(83, 33);
            this.btn_sorteggia.TabIndex = 4;
            this.btn_sorteggia.Text = "Sorteggia";
            this.btn_sorteggia.UseVisualStyleBackColor = true;
            this.btn_sorteggia.Click += new System.EventHandler(this.btn_sorteggia_Click);
            // 
            // txt_gruppi
            // 
            this.txt_gruppi.Location = new System.Drawing.Point(346, 95);
            this.txt_gruppi.Name = "txt_gruppi";
            this.txt_gruppi.Size = new System.Drawing.Size(100, 20);
            this.txt_gruppi.TabIndex = 5;
            // 
            // lbl_gruppi
            // 
            this.lbl_gruppi.AutoSize = true;
            this.lbl_gruppi.Location = new System.Drawing.Point(343, 66);
            this.lbl_gruppi.Name = "lbl_gruppi";
            this.lbl_gruppi.Size = new System.Drawing.Size(191, 13);
            this.lbl_gruppi.TabIndex = 6;
            this.lbl_gruppi.Text = "Inserisci la Grandezza dei Gruppi (3 - 5)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 294);
            this.Controls.Add(this.lbl_gruppi);
            this.Controls.Add(this.txt_gruppi);
            this.Controls.Add(this.btn_sorteggia);
            this.Controls.Add(this.lbl_turni);
            this.Controls.Add(this.lst_turni);
            this.Controls.Add(this.lbl_cognomi);
            this.Controls.Add(this.lst_cognomi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_cognomi;
        private System.Windows.Forms.Label lbl_cognomi;
        private System.Windows.Forms.ListBox lst_turni;
        private System.Windows.Forms.Label lbl_turni;
        private System.Windows.Forms.Button btn_sorteggia;
        private System.Windows.Forms.TextBox txt_gruppi;
        private System.Windows.Forms.Label lbl_gruppi;
    }
}

