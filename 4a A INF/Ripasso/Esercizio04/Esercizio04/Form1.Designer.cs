namespace Esercizio04
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserisciStudenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordinaAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaSuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciStudenteToolStripMenuItem,
            this.gestioneStudentiToolStripMenuItem,
            this.gestioneClasseToolStripMenuItem,
            this.esciToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserisciStudenteToolStripMenuItem
            // 
            this.inserisciStudenteToolStripMenuItem.Name = "inserisciStudenteToolStripMenuItem";
            this.inserisciStudenteToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.inserisciStudenteToolStripMenuItem.Text = "Inserisci Studente";
            // 
            // gestioneStudentiToolStripMenuItem
            // 
            this.gestioneStudentiToolStripMenuItem.Name = "gestioneStudentiToolStripMenuItem";
            this.gestioneStudentiToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestioneStudentiToolStripMenuItem.Text = "Gestione Studenti";
            // 
            // gestioneClasseToolStripMenuItem
            // 
            this.gestioneClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaToolStripMenuItem,
            this.ordinaAZToolStripMenuItem,
            this.salvaSuFileToolStripMenuItem});
            this.gestioneClasseToolStripMenuItem.Name = "gestioneClasseToolStripMenuItem";
            this.gestioneClasseToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.gestioneClasseToolStripMenuItem.Text = "Gestione Classe";
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            // 
            // ordinaAZToolStripMenuItem
            // 
            this.ordinaAZToolStripMenuItem.Name = "ordinaAZToolStripMenuItem";
            this.ordinaAZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordinaAZToolStripMenuItem.Text = "Ordina (A...Z)";
            // 
            // salvaSuFileToolStripMenuItem
            // 
            this.salvaSuFileToolStripMenuItem.Name = "salvaSuFileToolStripMenuItem";
            this.salvaSuFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvaSuFileToolStripMenuItem.Text = "Salva su File";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.esciToolStripMenuItem.Text = "Esci";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Esercizio 4 - Gestione STUDENTI CLASSI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserisciStudenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneStudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordinaAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaSuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

