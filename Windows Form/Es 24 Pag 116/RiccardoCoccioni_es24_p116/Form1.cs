using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiccardoCoccioni_es24_p116
{
    public partial class Form1 : Form
    {
        string[] animali = {
            "Aquila",
            "Cane",
            "Cavallo",
            "Coccodrillo",
            "Delfino",
            "Elefante",
            "Farfalla",
            "Gatto",
            "Rana",
            "Squalo"
        };

        string[] specie = {
            "Uccello",
            "Mammifero",
            "Mammifero",
            "Rettile",
            "Mammifero",
            "Mammifero",
            "Insetto",
            "Mammifero",
            "Anfibio",
            "Pesce"
        };

        public Form1()
        {
            InitializeComponent();
            lstAnimale.Items.AddRange(animali);
            lstSpecie.Items.AddRange(specie);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            if (txtAnimale.Text == null || txtAnimale.Text == "")
            {
                MessageBox.Show("Inserire il campo Animale");
            }
            else
            {
                int pos = ricercaBinaria(txtAnimale.Text, animali);
                if (pos == -1)
                {
                    MessageBox.Show("Animale non presente");
                }
                else MessageBox.Show($"La specie a cui appartiene " +
                        $"{txtAnimale.Text} è {specie[pos]}");
            }
        }

        private int ricercaBinaria(string animale, string[] animali)
        {
            bool trovato = false;
            int inizio = 0, fine = animali.Length - 1, meta = -1;

            while (inizio <= fine && !trovato)
            {
                meta = (inizio + fine) / 2;
                if (animali[meta] == animale)
                {
                    trovato = true;
                }
                else
                {
                    if (animali[meta].CompareTo(animale) > 0)
                    {
                        fine = meta - 1;
                    }
                    else inizio = meta + 1;
                }
            }

            if (trovato)
            {
                return meta;
            }
            else return -1;
        }

        private void lblAnimaleRicercata_Click(object sender, EventArgs e)
        {

        }
    }
}
