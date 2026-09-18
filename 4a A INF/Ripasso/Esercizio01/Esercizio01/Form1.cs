using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio01
{
    public partial class Form1 : Form
    {

        int Diff = 20;
        int prgImmagine = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDuplica_Click(object sender, EventArgs e)
        {
           
            
            PictureBox nuovaIMG = new PictureBox();

            nuovaIMG.Size = new Size(picVallauri.Width, picVallauri.Height);

            /// IMPORTANTE !!!
            this.Controls.Add(nuovaIMG);

            nuovaIMG.Image = picVallauri.Image;
            nuovaIMG.Name = $"picDuplica{prgImmagine++}";

            nuovaIMG.Location = new Point(picVallauri.Location.X + Diff, picVallauri.Location.Y + Diff);

            Diff += 20;
        }

        private void btnDuplica2_Click(object sender, EventArgs e)
        {

            PictureBox nuovaIMG = new PictureBox();
            nuovaIMG.Size = new Size(200, 100);

            /// IMPORTANTE !!!
            this.Controls.Add(nuovaIMG);

            Bitmap bmp = new Bitmap(200, 100);
            Graphics bmpGraphics = Graphics.FromImage(bmp);

            bmpGraphics.FillRectangle(Brushes.Blue, 0, 0, 200, 100);
            nuovaIMG.Image = bmp;

            nuovaIMG.Name = $"picDuplica2{prgImmagine++}";

            nuovaIMG.Location = new Point(picVallauri.Location.X + Diff, picVallauri.Location.Y + Diff);

            Diff += 50;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            TextBox nuovoTXT = new TextBox();

            nuovoTXT.Size = new Size(200, 23);
            nuovoTXT.Name = "txtInput";

            this.Controls.Add(nuovoTXT);

            nuovoTXT.Location = new Point(btnDuplica.Location.X,
                                            btnDuplica.Location.Y +
                                            btnDuplica.Size.Height + 25);

            Button nuouvoBTN = new Button()
            {
                Size = new Size(btnAggiungi.Size.Width, btnAggiungi.Size.Height),
                Name = "btnVisualizza",
                Text = "Visualizza",
                Location = new Point(btnAggiungi.Location.X,
                                    btnAggiungi.Location.Y +
                                    btnAggiungi.Size.Height + 25)
            };

            // Evento CLICK
            nuouvoBTN.Click += btnVisualizza_Click;

            this.Controls.Add(nuouvoBTN);

            btnAggiungi.Enabled = false;

        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;

            MessageBox.Show($"Evento creato da [{control.Name}] : {Controls["txtInput"].Text}");
        }

    }
}
