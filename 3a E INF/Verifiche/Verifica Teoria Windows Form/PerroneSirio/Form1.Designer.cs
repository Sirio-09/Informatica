namespace PerroneSirio
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
            this.btn_calcola = new System.Windows.Forms.Button();
            this.lst_voti = new System.Windows.Forms.ListBox();
            this.lst_materia = new System.Windows.Forms.ListBox();
            this.lbl_res = new System.Windows.Forms.Label();
            this.txt_materie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcola
            // 
            this.btn_calcola.Location = new System.Drawing.Point(414, 100);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(73, 26);
            this.btn_calcola.TabIndex = 0;
            this.btn_calcola.Text = "Calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // lst_voti
            // 
            this.lst_voti.FormattingEnabled = true;
            this.lst_voti.Location = new System.Drawing.Point(57, 50);
            this.lst_voti.Name = "lst_voti";
            this.lst_voti.Size = new System.Drawing.Size(127, 251);
            this.lst_voti.TabIndex = 1;
            // 
            // lst_materia
            // 
            this.lst_materia.FormattingEnabled = true;
            this.lst_materia.Location = new System.Drawing.Point(228, 50);
            this.lst_materia.Name = "lst_materia";
            this.lst_materia.Size = new System.Drawing.Size(127, 251);
            this.lst_materia.TabIndex = 2;
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(411, 164);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(35, 13);
            this.lbl_res.TabIndex = 3;
            this.lbl_res.Text = "label1";
            // 
            // txt_materie
            // 
            this.txt_materie.Location = new System.Drawing.Point(414, 50);
            this.txt_materie.Name = "txt_materie";
            this.txt_materie.Size = new System.Drawing.Size(100, 20);
            this.txt_materie.TabIndex = 4;
            this.txt_materie.TextChanged += new System.EventHandler(this.txt_materie_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 349);
            this.Controls.Add(this.txt_materie);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lst_materia);
            this.Controls.Add(this.lst_voti);
            this.Controls.Add(this.btn_calcola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.ListBox lst_voti;
        private System.Windows.Forms.ListBox lst_materia;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.TextBox txt_materie;
    }
}

