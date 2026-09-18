namespace Esercizio01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picVallauri = new System.Windows.Forms.PictureBox();
            this.btnDuplica = new System.Windows.Forms.Button();
            this.btnDuplica2 = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVallauri)).BeginInit();
            this.SuspendLayout();
            // 
            // picVallauri
            // 
            this.picVallauri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVallauri.Image = ((System.Drawing.Image)(resources.GetObject("picVallauri.Image")));
            this.picVallauri.Location = new System.Drawing.Point(56, 42);
            this.picVallauri.Name = "picVallauri";
            this.picVallauri.Size = new System.Drawing.Size(202, 195);
            this.picVallauri.TabIndex = 0;
            this.picVallauri.TabStop = false;
            // 
            // btnDuplica
            // 
            this.btnDuplica.Location = new System.Drawing.Point(292, 42);
            this.btnDuplica.Name = "btnDuplica";
            this.btnDuplica.Size = new System.Drawing.Size(75, 23);
            this.btnDuplica.TabIndex = 1;
            this.btnDuplica.Text = "Duplica";
            this.btnDuplica.UseVisualStyleBackColor = true;
            this.btnDuplica.Click += new System.EventHandler(this.btnDuplica_Click);
            // 
            // btnDuplica2
            // 
            this.btnDuplica2.Location = new System.Drawing.Point(409, 43);
            this.btnDuplica2.Name = "btnDuplica2";
            this.btnDuplica2.Size = new System.Drawing.Size(75, 23);
            this.btnDuplica2.TabIndex = 2;
            this.btnDuplica2.Text = "Duplica2";
            this.btnDuplica2.UseVisualStyleBackColor = true;
            this.btnDuplica2.Click += new System.EventHandler(this.btnDuplica2_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(528, 43);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 3;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnDuplica2);
            this.Controls.Add(this.btnDuplica);
            this.Controls.Add(this.picVallauri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Esercizio 1 - Ripasso";
            ((System.ComponentModel.ISupportInitialize)(this.picVallauri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picVallauri;
        private System.Windows.Forms.Button btnDuplica;
        private System.Windows.Forms.Button btnDuplica2;
        private System.Windows.Forms.Button btnAggiungi;
    }
}

