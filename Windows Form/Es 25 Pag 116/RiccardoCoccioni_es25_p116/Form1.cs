using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiccardoCoccioni_es25_p116
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
        }

        private void btnAnimale_Click(object sender, EventArgs e)
        {
            if (txtAnimale.Text == null || txtAnimale.Text == "")
            {
                MessageBox.Show("Inserire il campo Animale");
            }
            else
            {
                int pos = ricercaABlocchi(txtAnimale.Text, animali);
                if (pos == -1)
                {
                    MessageBox.Show("Animale non presente");
                }
                else MessageBox.Show($"La specie a cui appartiene " +
                        $"{txtAnimale.Text} è {specie[pos]}");
            }
        }
        

        private int ricercaABlocchi(string animale, string[] animali)
        {
            int n = animali.Length;
            int salto = (int)Math.Sqrt(n);
            int precedente = 0;

            while (precedente < n && animali[Math.Min(salto, n) - 1].CompareTo(animale) < 0)
            {
                precedente = salto;
                salto += (int)Math.Sqrt(n);

                if (precedente >= n) return -1;
            }

            while (precedente < Math.Min(salto, n))
            {
                if (animali[precedente] == animale)
                {
                    return precedente;
                }
                precedente++;

                if (precedente == Math.Min(salto, n)) return -1;
            }

            return -1;
        }
    }
}
