using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_01
{
    public partial class Form1 : Form
    {
        int dif = 50;
        int prgImage = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDuplica_Click(object sender, EventArgs e)
        {
            

            PictureBox nuovaIMG = new PictureBox();
            nuovaIMG.Size = new Size(picVallauri.Width, picVallauri.Height);

            // IMPORTANTE!!!
            this.Controls.Add(nuovaIMG);

            nuovaIMG.Image = picVallauri.Image;
            nuovaIMG.Name = $"picDuplica{prgImage++}";

            nuovaIMG.Location = new Point(picVallauri.Location.X + dif, dif);

            dif += 20;
        }
    }
}
