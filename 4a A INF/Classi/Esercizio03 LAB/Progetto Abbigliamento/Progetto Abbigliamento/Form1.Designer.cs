namespace Progetto_Abbigliamento
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
            this.tlb_indumenti = new System.Windows.Forms.TabControl();
            this.tabMaglie = new System.Windows.Forms.TabPage();
            this.tabPantaloni = new System.Windows.Forms.TabPage();
            this.tabScarpe = new System.Windows.Forms.TabPage();
            this.tabGiacche = new System.Windows.Forms.TabPage();
            this.tabBorse = new System.Windows.Forms.TabPage();
            this.btnInserisciMaglie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbColoreMaglia = new System.Windows.Forms.ComboBox();
            this.txtMarcaMaglia = new System.Windows.Forms.TextBox();
            this.cbMaterialeMaglia = new System.Windows.Forms.ComboBox();
            this.cbTipoMaglia = new System.Windows.Forms.ComboBox();
            this.cbGenereMaglia = new System.Windows.Forms.ComboBox();
            this.cbTagliaMaglia = new System.Windows.Forms.ComboBox();
            this.cbManicaMaglia = new System.Windows.Forms.ComboBox();
            this.cbAperturaMaglia = new System.Windows.Forms.ComboBox();
            this.nudPrezzoMaglia = new System.Windows.Forms.NumericUpDown();
            this.tlb_indumenti.SuspendLayout();
            this.tabMaglie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoMaglia)).BeginInit();
            this.SuspendLayout();
            // 
            // tlb_indumenti
            // 
            this.tlb_indumenti.Controls.Add(this.tabMaglie);
            this.tlb_indumenti.Controls.Add(this.tabPantaloni);
            this.tlb_indumenti.Controls.Add(this.tabScarpe);
            this.tlb_indumenti.Controls.Add(this.tabGiacche);
            this.tlb_indumenti.Controls.Add(this.tabBorse);
            this.tlb_indumenti.Location = new System.Drawing.Point(1, 2);
            this.tlb_indumenti.Name = "tlb_indumenti";
            this.tlb_indumenti.SelectedIndex = 0;
            this.tlb_indumenti.Size = new System.Drawing.Size(764, 402);
            this.tlb_indumenti.TabIndex = 0;
            // 
            // tabMaglie
            // 
            this.tabMaglie.Controls.Add(this.panel1);
            this.tabMaglie.Location = new System.Drawing.Point(4, 22);
            this.tabMaglie.Name = "tabMaglie";
            this.tabMaglie.Size = new System.Drawing.Size(756, 376);
            this.tabMaglie.TabIndex = 0;
            this.tabMaglie.Text = "Maglie";
            this.tabMaglie.UseVisualStyleBackColor = true;
            // 
            // tabPantaloni
            // 
            this.tabPantaloni.Location = new System.Drawing.Point(4, 22);
            this.tabPantaloni.Name = "tabPantaloni";
            this.tabPantaloni.Size = new System.Drawing.Size(756, 376);
            this.tabPantaloni.TabIndex = 1;
            this.tabPantaloni.Text = "Pantaloni";
            this.tabPantaloni.UseVisualStyleBackColor = true;
            // 
            // tabScarpe
            // 
            this.tabScarpe.Location = new System.Drawing.Point(4, 22);
            this.tabScarpe.Name = "tabScarpe";
            this.tabScarpe.Size = new System.Drawing.Size(756, 376);
            this.tabScarpe.TabIndex = 2;
            this.tabScarpe.Text = "Scarpe";
            this.tabScarpe.UseVisualStyleBackColor = true;
            // 
            // tabGiacche
            // 
            this.tabGiacche.Location = new System.Drawing.Point(4, 22);
            this.tabGiacche.Name = "tabGiacche";
            this.tabGiacche.Size = new System.Drawing.Size(756, 376);
            this.tabGiacche.TabIndex = 3;
            this.tabGiacche.Text = "Giacche";
            this.tabGiacche.UseVisualStyleBackColor = true;
            // 
            // tabBorse
            // 
            this.tabBorse.Location = new System.Drawing.Point(4, 22);
            this.tabBorse.Name = "tabBorse";
            this.tabBorse.Size = new System.Drawing.Size(756, 376);
            this.tabBorse.TabIndex = 4;
            this.tabBorse.Text = "Borse";
            this.tabBorse.UseVisualStyleBackColor = true;
            // 
            // btnInserisciMaglie
            // 
            this.btnInserisciMaglie.Location = new System.Drawing.Point(14, 15);
            this.btnInserisciMaglie.Name = "btnInserisciMaglie";
            this.btnInserisciMaglie.Size = new System.Drawing.Size(101, 23);
            this.btnInserisciMaglie.TabIndex = 0;
            this.btnInserisciMaglie.Text = "Inserisci Maglia";
            this.btnInserisciMaglie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Colore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Materiale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Genere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Taglia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Manica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Apertura";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudPrezzoMaglia);
            this.panel1.Controls.Add(this.cbAperturaMaglia);
            this.panel1.Controls.Add(this.cbManicaMaglia);
            this.panel1.Controls.Add(this.cbTagliaMaglia);
            this.panel1.Controls.Add(this.cbGenereMaglia);
            this.panel1.Controls.Add(this.cbTipoMaglia);
            this.panel1.Controls.Add(this.cbMaterialeMaglia);
            this.panel1.Controls.Add(this.cbColoreMaglia);
            this.panel1.Controls.Add(this.btnInserisciMaglie);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMarcaMaglia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 189);
            this.panel1.TabIndex = 19;
            // 
            // cbColoreMaglia
            // 
            this.cbColoreMaglia.FormattingEnabled = true;
            this.cbColoreMaglia.Items.AddRange(new object[] {
            "Rosso",
            "Verde",
            "Giallo",
            "Rosa",
            "Blu",
            "Viola",
            "Bianco",
            "Nero"});
            this.cbColoreMaglia.Location = new System.Drawing.Point(14, 150);
            this.cbColoreMaglia.Name = "cbColoreMaglia";
            this.cbColoreMaglia.Size = new System.Drawing.Size(89, 21);
            this.cbColoreMaglia.TabIndex = 20;
            // 
            // txtMarcaMaglia
            // 
            this.txtMarcaMaglia.Location = new System.Drawing.Point(14, 67);
            this.txtMarcaMaglia.Name = "txtMarcaMaglia";
            this.txtMarcaMaglia.Size = new System.Drawing.Size(89, 20);
            this.txtMarcaMaglia.TabIndex = 2;
            // 
            // cbMaterialeMaglia
            // 
            this.cbMaterialeMaglia.FormattingEnabled = true;
            this.cbMaterialeMaglia.Items.AddRange(new object[] {
            "Cotone",
            "Lana",
            "Lino",
            "Seta",
            "Sintetico",
            "Cashmere"});
            this.cbMaterialeMaglia.Location = new System.Drawing.Point(123, 66);
            this.cbMaterialeMaglia.Name = "cbMaterialeMaglia";
            this.cbMaterialeMaglia.Size = new System.Drawing.Size(89, 21);
            this.cbMaterialeMaglia.TabIndex = 21;
            // 
            // cbTipoMaglia
            // 
            this.cbTipoMaglia.FormattingEnabled = true;
            this.cbTipoMaglia.Items.AddRange(new object[] {
            "Felpa",
            "T-Shirt",
            "Polo",
            "Canotta"});
            this.cbTipoMaglia.Location = new System.Drawing.Point(123, 150);
            this.cbTipoMaglia.Name = "cbTipoMaglia";
            this.cbTipoMaglia.Size = new System.Drawing.Size(89, 21);
            this.cbTipoMaglia.TabIndex = 22;
            // 
            // cbGenereMaglia
            // 
            this.cbGenereMaglia.FormattingEnabled = true;
            this.cbGenereMaglia.Items.AddRange(new object[] {
            "Uomo",
            "Donna",
            "Bambino",
            "Bambina"});
            this.cbGenereMaglia.Location = new System.Drawing.Point(123, 106);
            this.cbGenereMaglia.Name = "cbGenereMaglia";
            this.cbGenereMaglia.Size = new System.Drawing.Size(89, 21);
            this.cbGenereMaglia.TabIndex = 23;
            // 
            // cbTagliaMaglia
            // 
            this.cbTagliaMaglia.FormattingEnabled = true;
            this.cbTagliaMaglia.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cbTagliaMaglia.Location = new System.Drawing.Point(230, 66);
            this.cbTagliaMaglia.Name = "cbTagliaMaglia";
            this.cbTagliaMaglia.Size = new System.Drawing.Size(89, 21);
            this.cbTagliaMaglia.TabIndex = 24;
            // 
            // cbManicaMaglia
            // 
            this.cbManicaMaglia.FormattingEnabled = true;
            this.cbManicaMaglia.Items.AddRange(new object[] {
            "Lunga",
            "Corta",
            "Mezza Manica",
            "Smanicata"});
            this.cbManicaMaglia.Location = new System.Drawing.Point(230, 106);
            this.cbManicaMaglia.Name = "cbManicaMaglia";
            this.cbManicaMaglia.Size = new System.Drawing.Size(89, 21);
            this.cbManicaMaglia.TabIndex = 25;
            // 
            // cbAperturaMaglia
            // 
            this.cbAperturaMaglia.FormattingEnabled = true;
            this.cbAperturaMaglia.Items.AddRange(new object[] {
            "Zip",
            "Bottoni",
            "Velcro",
            "Senza"});
            this.cbAperturaMaglia.Location = new System.Drawing.Point(230, 150);
            this.cbAperturaMaglia.Name = "cbAperturaMaglia";
            this.cbAperturaMaglia.Size = new System.Drawing.Size(89, 21);
            this.cbAperturaMaglia.TabIndex = 26;
            // 
            // nudPrezzoMaglia
            // 
            this.nudPrezzoMaglia.Location = new System.Drawing.Point(14, 107);
            this.nudPrezzoMaglia.Name = "nudPrezzoMaglia";
            this.nudPrezzoMaglia.Size = new System.Drawing.Size(89, 20);
            this.nudPrezzoMaglia.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 410);
            this.Controls.Add(this.tlb_indumenti);
            this.Name = "Form1";
            this.Text = "Indumenti";
            this.tlb_indumenti.ResumeLayout(false);
            this.tabMaglie.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoMaglia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tlb_indumenti;
        private System.Windows.Forms.TabPage tabMaglie;
        private System.Windows.Forms.TabPage tabPantaloni;
        private System.Windows.Forms.TabPage tabScarpe;
        private System.Windows.Forms.TabPage tabGiacche;
        private System.Windows.Forms.TabPage tabBorse;
        private System.Windows.Forms.Button btnInserisciMaglie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColoreMaglia;
        private System.Windows.Forms.TextBox txtMarcaMaglia;
        private System.Windows.Forms.NumericUpDown nudPrezzoMaglia;
        private System.Windows.Forms.ComboBox cbAperturaMaglia;
        private System.Windows.Forms.ComboBox cbManicaMaglia;
        private System.Windows.Forms.ComboBox cbTagliaMaglia;
        private System.Windows.Forms.ComboBox cbGenereMaglia;
        private System.Windows.Forms.ComboBox cbTipoMaglia;
        private System.Windows.Forms.ComboBox cbMaterialeMaglia;
    }
}

