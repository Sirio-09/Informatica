namespace Es_Biblioteca
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
            this.btnMostraCatalogo = new System.Windows.Forms.Button();
            this.btnCercaTitolo = new System.Windows.Forms.Button();
            this.btnPrezzoMedio = new System.Windows.Forms.Button();
            this.btnAggiungiLibro = new System.Windows.Forms.Button();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.nudNPagine = new System.Windows.Forms.NumericUpDown();
            this.nudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblNPagine = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNEdizione = new System.Windows.Forms.Label();
            this.lblAutoreRivista = new System.Windows.Forms.Label();
            this.lblTitoloRivista = new System.Windows.Forms.Label();
            this.nudPrezzoRivista = new System.Windows.Forms.NumericUpDown();
            this.nudNEdizione = new System.Windows.Forms.NumericUpDown();
            this.txtAutoreRivista = new System.Windows.Forms.TextBox();
            this.txtTitoloRivista = new System.Windows.Forms.TextBox();
            this.btnAggiungiRivista = new System.Windows.Forms.Button();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNPagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoRivista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNEdizione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostraCatalogo
            // 
            this.btnMostraCatalogo.Location = new System.Drawing.Point(14, 11);
            this.btnMostraCatalogo.Name = "btnMostraCatalogo";
            this.btnMostraCatalogo.Size = new System.Drawing.Size(102, 30);
            this.btnMostraCatalogo.TabIndex = 1;
            this.btnMostraCatalogo.Text = "Mostra Catalogo";
            this.btnMostraCatalogo.UseVisualStyleBackColor = true;
            this.btnMostraCatalogo.Click += new System.EventHandler(this.btnMostraCatalogo_Click);
            // 
            // btnCercaTitolo
            // 
            this.btnCercaTitolo.Location = new System.Drawing.Point(402, 326);
            this.btnCercaTitolo.Name = "btnCercaTitolo";
            this.btnCercaTitolo.Size = new System.Drawing.Size(102, 30);
            this.btnCercaTitolo.TabIndex = 2;
            this.btnCercaTitolo.Text = "Cerca Titolo";
            this.btnCercaTitolo.UseVisualStyleBackColor = true;
            // 
            // btnPrezzoMedio
            // 
            this.btnPrezzoMedio.Location = new System.Drawing.Point(283, 326);
            this.btnPrezzoMedio.Name = "btnPrezzoMedio";
            this.btnPrezzoMedio.Size = new System.Drawing.Size(102, 30);
            this.btnPrezzoMedio.TabIndex = 3;
            this.btnPrezzoMedio.Text = "Prezzo Medio";
            this.btnPrezzoMedio.UseVisualStyleBackColor = true;
            // 
            // btnAggiungiLibro
            // 
            this.btnAggiungiLibro.Location = new System.Drawing.Point(12, 11);
            this.btnAggiungiLibro.Name = "btnAggiungiLibro";
            this.btnAggiungiLibro.Size = new System.Drawing.Size(100, 30);
            this.btnAggiungiLibro.TabIndex = 0;
            this.btnAggiungiLibro.Text = "Aggiungi Libro";
            this.btnAggiungiLibro.UseVisualStyleBackColor = true;
            this.btnAggiungiLibro.Click += new System.EventHandler(this.btnAggiungiLibro_Click);
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(12, 69);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 5;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(12, 112);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 6;
            // 
            // nudNPagine
            // 
            this.nudNPagine.Location = new System.Drawing.Point(147, 69);
            this.nudNPagine.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNPagine.Name = "nudNPagine";
            this.nudNPagine.Size = new System.Drawing.Size(59, 20);
            this.nudNPagine.TabIndex = 5;
            // 
            // nudPrezzo
            // 
            this.nudPrezzo.DecimalPlaces = 2;
            this.nudPrezzo.Location = new System.Drawing.Point(147, 113);
            this.nudPrezzo.Name = "nudPrezzo";
            this.nudPrezzo.Size = new System.Drawing.Size(59, 20);
            this.nudPrezzo.TabIndex = 7;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(9, 53);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(33, 13);
            this.lblTitolo.TabIndex = 5;
            this.lblTitolo.Text = "Titolo";
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Location = new System.Drawing.Point(9, 96);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(38, 13);
            this.lblAutore.TabIndex = 8;
            this.lblAutore.Text = "Autore";
            // 
            // lblNPagine
            // 
            this.lblNPagine.AutoSize = true;
            this.lblNPagine.Location = new System.Drawing.Point(144, 53);
            this.lblNPagine.Name = "lblNPagine";
            this.lblNPagine.Size = new System.Drawing.Size(51, 13);
            this.lblNPagine.TabIndex = 9;
            this.lblNPagine.Text = "N Pagine";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(144, 97);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(39, 13);
            this.lblPrezzo.TabIndex = 10;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPrezzo);
            this.panel1.Controls.Add(this.lblNPagine);
            this.panel1.Controls.Add(this.lblAutore);
            this.panel1.Controls.Add(this.lblTitolo);
            this.panel1.Controls.Add(this.nudPrezzo);
            this.panel1.Controls.Add(this.nudNPagine);
            this.panel1.Controls.Add(this.txtAutore);
            this.panel1.Controls.Add(this.txtTitolo);
            this.panel1.Controls.Add(this.btnAggiungiLibro);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 154);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblNEdizione);
            this.panel2.Controls.Add(this.lblAutoreRivista);
            this.panel2.Controls.Add(this.lblTitoloRivista);
            this.panel2.Controls.Add(this.nudPrezzoRivista);
            this.panel2.Controls.Add(this.nudNEdizione);
            this.panel2.Controls.Add(this.txtAutoreRivista);
            this.panel2.Controls.Add(this.txtTitoloRivista);
            this.panel2.Controls.Add(this.btnAggiungiRivista);
            this.panel2.Location = new System.Drawing.Point(29, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 154);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prezzo";
            // 
            // lblNEdizione
            // 
            this.lblNEdizione.AutoSize = true;
            this.lblNEdizione.Location = new System.Drawing.Point(144, 53);
            this.lblNEdizione.Name = "lblNEdizione";
            this.lblNEdizione.Size = new System.Drawing.Size(58, 13);
            this.lblNEdizione.TabIndex = 9;
            this.lblNEdizione.Text = "N Edizione";
            // 
            // lblAutoreRivista
            // 
            this.lblAutoreRivista.AutoSize = true;
            this.lblAutoreRivista.Location = new System.Drawing.Point(9, 96);
            this.lblAutoreRivista.Name = "lblAutoreRivista";
            this.lblAutoreRivista.Size = new System.Drawing.Size(38, 13);
            this.lblAutoreRivista.TabIndex = 8;
            this.lblAutoreRivista.Text = "Autore";
            // 
            // lblTitoloRivista
            // 
            this.lblTitoloRivista.AutoSize = true;
            this.lblTitoloRivista.Location = new System.Drawing.Point(9, 53);
            this.lblTitoloRivista.Name = "lblTitoloRivista";
            this.lblTitoloRivista.Size = new System.Drawing.Size(33, 13);
            this.lblTitoloRivista.TabIndex = 5;
            this.lblTitoloRivista.Text = "Titolo";
            // 
            // nudPrezzoRivista
            // 
            this.nudPrezzoRivista.DecimalPlaces = 2;
            this.nudPrezzoRivista.Location = new System.Drawing.Point(147, 113);
            this.nudPrezzoRivista.Name = "nudPrezzoRivista";
            this.nudPrezzoRivista.Size = new System.Drawing.Size(59, 20);
            this.nudPrezzoRivista.TabIndex = 7;
            // 
            // nudNEdizione
            // 
            this.nudNEdizione.Location = new System.Drawing.Point(147, 69);
            this.nudNEdizione.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNEdizione.Name = "nudNEdizione";
            this.nudNEdizione.Size = new System.Drawing.Size(59, 20);
            this.nudNEdizione.TabIndex = 5;
            // 
            // txtAutoreRivista
            // 
            this.txtAutoreRivista.Location = new System.Drawing.Point(12, 112);
            this.txtAutoreRivista.Name = "txtAutoreRivista";
            this.txtAutoreRivista.Size = new System.Drawing.Size(100, 20);
            this.txtAutoreRivista.TabIndex = 6;
            // 
            // txtTitoloRivista
            // 
            this.txtTitoloRivista.Location = new System.Drawing.Point(12, 69);
            this.txtTitoloRivista.Name = "txtTitoloRivista";
            this.txtTitoloRivista.Size = new System.Drawing.Size(100, 20);
            this.txtTitoloRivista.TabIndex = 5;
            // 
            // btnAggiungiRivista
            // 
            this.btnAggiungiRivista.Location = new System.Drawing.Point(12, 11);
            this.btnAggiungiRivista.Name = "btnAggiungiRivista";
            this.btnAggiungiRivista.Size = new System.Drawing.Size(100, 30);
            this.btnAggiungiRivista.TabIndex = 0;
            this.btnAggiungiRivista.Text = "Aggiungi Rivista";
            this.btnAggiungiRivista.UseVisualStyleBackColor = true;
            this.btnAggiungiRivista.Click += new System.EventHandler(this.btnAggiungiRivista_Click);
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(14, 53);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.Size = new System.Drawing.Size(543, 202);
            this.dgvCatalogo.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnMostraCatalogo);
            this.panel3.Controls.Add(this.dgvCatalogo);
            this.panel3.Location = new System.Drawing.Point(283, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 269);
            this.panel3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 374);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrezzoMedio);
            this.Controls.Add(this.btnCercaTitolo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNPagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrezzoRivista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNEdizione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostraCatalogo;
        private System.Windows.Forms.Button btnCercaTitolo;
        private System.Windows.Forms.Button btnPrezzoMedio;
        private System.Windows.Forms.Button btnAggiungiLibro;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.NumericUpDown nudNPagine;
        private System.Windows.Forms.NumericUpDown nudPrezzo;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.Label lblNPagine;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNEdizione;
        private System.Windows.Forms.Label lblAutoreRivista;
        private System.Windows.Forms.Label lblTitoloRivista;
        private System.Windows.Forms.NumericUpDown nudPrezzoRivista;
        private System.Windows.Forms.NumericUpDown nudNEdizione;
        private System.Windows.Forms.TextBox txtAutoreRivista;
        private System.Windows.Forms.TextBox txtTitoloRivista;
        private System.Windows.Forms.Button btnAggiungiRivista;
        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Panel panel3;
    }
}

