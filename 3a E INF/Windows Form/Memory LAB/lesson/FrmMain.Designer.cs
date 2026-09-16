namespace lesson
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnResetGame = new System.Windows.Forms.Button();
            this.LblRemainingErrors = new System.Windows.Forms.Label();
            this.PcbGrid00 = new System.Windows.Forms.PictureBox();
            this.PcbGrid01 = new System.Windows.Forms.PictureBox();
            this.PcbGrid02 = new System.Windows.Forms.PictureBox();
            this.PcbGrid12 = new System.Windows.Forms.PictureBox();
            this.PcbGrid11 = new System.Windows.Forms.PictureBox();
            this.PcbGrid10 = new System.Windows.Forms.PictureBox();
            this.PcbGrid22 = new System.Windows.Forms.PictureBox();
            this.PcbGrid21 = new System.Windows.Forms.PictureBox();
            this.PcbGrid20 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid20)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnResetGame
            // 
            this.BtnResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetGame.Location = new System.Drawing.Point(368, 7);
            this.BtnResetGame.Margin = new System.Windows.Forms.Padding(2);
            this.BtnResetGame.Name = "BtnResetGame";
            this.BtnResetGame.Size = new System.Drawing.Size(111, 44);
            this.BtnResetGame.TabIndex = 0;
            this.BtnResetGame.Text = "NUOVA PARTITA";
            this.BtnResetGame.UseVisualStyleBackColor = true;
            this.BtnResetGame.Click += new System.EventHandler(this.BtnResetGame_Click);
            // 
            // LblRemainingErrors
            // 
            this.LblRemainingErrors.AutoSize = true;
            this.LblRemainingErrors.Location = new System.Drawing.Point(368, 64);
            this.LblRemainingErrors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRemainingErrors.Name = "LblRemainingErrors";
            this.LblRemainingErrors.Size = new System.Drawing.Size(104, 15);
            this.LblRemainingErrors.TabIndex = 1;
            this.LblRemainingErrors.Text = "Errori Rimanenti: 3";
            this.LblRemainingErrors.Visible = false;
            // 
            // PcbGrid00
            // 
            this.PcbGrid00.BackColor = System.Drawing.Color.White;
            this.PcbGrid00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid00.Enabled = false;
            this.PcbGrid00.Location = new System.Drawing.Point(10, 7);
            this.PcbGrid00.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid00.Name = "PcbGrid00";
            this.PcbGrid00.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid00.TabIndex = 2;
            this.PcbGrid00.TabStop = false;
            this.PcbGrid00.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid01
            // 
            this.PcbGrid01.BackColor = System.Drawing.Color.White;
            this.PcbGrid01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid01.Enabled = false;
            this.PcbGrid01.Location = new System.Drawing.Point(120, 7);
            this.PcbGrid01.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid01.Name = "PcbGrid01";
            this.PcbGrid01.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid01.TabIndex = 3;
            this.PcbGrid01.TabStop = false;
            this.PcbGrid01.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid02
            // 
            this.PcbGrid02.BackColor = System.Drawing.Color.White;
            this.PcbGrid02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid02.Enabled = false;
            this.PcbGrid02.Location = new System.Drawing.Point(229, 7);
            this.PcbGrid02.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid02.Name = "PcbGrid02";
            this.PcbGrid02.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid02.TabIndex = 4;
            this.PcbGrid02.TabStop = false;
            this.PcbGrid02.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid12
            // 
            this.PcbGrid12.BackColor = System.Drawing.Color.White;
            this.PcbGrid12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid12.Enabled = false;
            this.PcbGrid12.Location = new System.Drawing.Point(229, 127);
            this.PcbGrid12.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid12.Name = "PcbGrid12";
            this.PcbGrid12.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid12.TabIndex = 7;
            this.PcbGrid12.TabStop = false;
            this.PcbGrid12.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid11
            // 
            this.PcbGrid11.BackColor = System.Drawing.Color.White;
            this.PcbGrid11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid11.Enabled = false;
            this.PcbGrid11.Location = new System.Drawing.Point(120, 127);
            this.PcbGrid11.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid11.Name = "PcbGrid11";
            this.PcbGrid11.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid11.TabIndex = 6;
            this.PcbGrid11.TabStop = false;
            this.PcbGrid11.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid10
            // 
            this.PcbGrid10.BackColor = System.Drawing.Color.White;
            this.PcbGrid10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid10.Enabled = false;
            this.PcbGrid10.Location = new System.Drawing.Point(10, 127);
            this.PcbGrid10.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid10.Name = "PcbGrid10";
            this.PcbGrid10.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid10.TabIndex = 5;
            this.PcbGrid10.TabStop = false;
            this.PcbGrid10.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid22
            // 
            this.PcbGrid22.BackColor = System.Drawing.Color.White;
            this.PcbGrid22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid22.Enabled = false;
            this.PcbGrid22.Location = new System.Drawing.Point(229, 247);
            this.PcbGrid22.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid22.Name = "PcbGrid22";
            this.PcbGrid22.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid22.TabIndex = 10;
            this.PcbGrid22.TabStop = false;
            this.PcbGrid22.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid21
            // 
            this.PcbGrid21.BackColor = System.Drawing.Color.White;
            this.PcbGrid21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid21.Enabled = false;
            this.PcbGrid21.Location = new System.Drawing.Point(120, 247);
            this.PcbGrid21.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid21.Name = "PcbGrid21";
            this.PcbGrid21.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid21.TabIndex = 9;
            this.PcbGrid21.TabStop = false;
            this.PcbGrid21.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // PcbGrid20
            // 
            this.PcbGrid20.BackColor = System.Drawing.Color.White;
            this.PcbGrid20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbGrid20.Enabled = false;
            this.PcbGrid20.Location = new System.Drawing.Point(10, 247);
            this.PcbGrid20.Margin = new System.Windows.Forms.Padding(2);
            this.PcbGrid20.Name = "PcbGrid20";
            this.PcbGrid20.Size = new System.Drawing.Size(106, 117);
            this.PcbGrid20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbGrid20.TabIndex = 8;
            this.PcbGrid20.TabStop = false;
            this.PcbGrid20.Click += new System.EventHandler(this.PcbCard_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 379);
            this.Controls.Add(this.PcbGrid22);
            this.Controls.Add(this.PcbGrid21);
            this.Controls.Add(this.PcbGrid20);
            this.Controls.Add(this.PcbGrid12);
            this.Controls.Add(this.PcbGrid11);
            this.Controls.Add(this.PcbGrid10);
            this.Controls.Add(this.PcbGrid02);
            this.Controls.Add(this.PcbGrid01);
            this.Controls.Add(this.PcbGrid00);
            this.Controls.Add(this.LblRemainingErrors);
            this.Controls.Add(this.BtnResetGame);
            this.Name = "FrmMain";
            this.Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbGrid20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnResetGame;
        private Label LblRemainingErrors;
        private PictureBox PcbGrid00;
        private PictureBox PcbGrid01;
        private PictureBox PcbGrid02;
        private PictureBox PcbGrid12;
        private PictureBox PcbGrid11;
        private PictureBox PcbGrid10;
        private PictureBox PcbGrid22;
        private PictureBox PcbGrid21;
        private PictureBox PcbGrid20;
    }
}