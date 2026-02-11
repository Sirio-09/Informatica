namespace Es_17_Pag_116
{
    partial class FormCanzoni
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
            this.lst_Cantanti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Canzoni = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_CanzoniCantante = new System.Windows.Forms.ListBox();
            this.txt_NomeCantante = new System.Windows.Forms.TextBox();
            this.btn_CercaCanzoni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Cantanti
            // 
            this.lst_Cantanti.FormattingEnabled = true;
            this.lst_Cantanti.Location = new System.Drawing.Point(32, 66);
            this.lst_Cantanti.Name = "lst_Cantanti";
            this.lst_Cantanti.Size = new System.Drawing.Size(130, 251);
            this.lst_Cantanti.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantanti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Canzoni";
            // 
            // lst_Canzoni
            // 
            this.lst_Canzoni.FormattingEnabled = true;
            this.lst_Canzoni.Location = new System.Drawing.Point(187, 66);
            this.lst_Canzoni.Name = "lst_Canzoni";
            this.lst_Canzoni.Size = new System.Drawing.Size(130, 251);
            this.lst_Canzoni.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome Cantante";
            // 
            // lst_CanzoniCantante
            // 
            this.lst_CanzoniCantante.FormattingEnabled = true;
            this.lst_CanzoniCantante.Location = new System.Drawing.Point(369, 131);
            this.lst_CanzoniCantante.Name = "lst_CanzoniCantante";
            this.lst_CanzoniCantante.Size = new System.Drawing.Size(130, 186);
            this.lst_CanzoniCantante.TabIndex = 6;
            this.lst_CanzoniCantante.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // txt_NomeCantante
            // 
            this.txt_NomeCantante.Location = new System.Drawing.Point(369, 66);
            this.txt_NomeCantante.Name = "txt_NomeCantante";
            this.txt_NomeCantante.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeCantante.TabIndex = 7;
            // 
            // btn_CercaCanzoni
            // 
            this.btn_CercaCanzoni.Location = new System.Drawing.Point(369, 92);
            this.btn_CercaCanzoni.Name = "btn_CercaCanzoni";
            this.btn_CercaCanzoni.Size = new System.Drawing.Size(100, 23);
            this.btn_CercaCanzoni.TabIndex = 8;
            this.btn_CercaCanzoni.Text = "Cerca Cantante";
            this.btn_CercaCanzoni.UseVisualStyleBackColor = true;
            // 
            // FormCanzoni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 353);
            this.Controls.Add(this.btn_CercaCanzoni);
            this.Controls.Add(this.txt_NomeCantante);
            this.Controls.Add(this.lst_CanzoniCantante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_Canzoni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_Cantanti);
            this.Name = "FormCanzoni";
            this.Text = "Canzoni";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Cantanti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Canzoni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_CanzoniCantante;
        private System.Windows.Forms.TextBox txt_NomeCantante;
        private System.Windows.Forms.Button btn_CercaCanzoni;
    }
}

