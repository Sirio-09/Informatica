using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_27_Pag_116
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
            lst_animali.Items.AddRange(animali);
            lst_specie.Items.AddRange(specie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] risultato = OttieniAnimaliSpecieMaggiore();
            lst_specieAnimali.Items.AddRange(risultato);
        }

        private string[] OttieniAnimaliSpecieMaggiore()
        {
            string specieMax = "";
            int maxConteggio = 0;

            for (int i = 0; i < specie.Length; i++)
            {
                int conta = 0;
                for (int j = 0; j < specie.Length; j++)
                {
                    if (specie[i] == specie[j])
                    {
                        conta++;
                    }
                }

                if (conta > maxConteggio)
                {
                    maxConteggio = conta;
                    specieMax = specie[i];
                }
            }

            string[] temp = new string[maxConteggio];
            int posizione = 0;

            for (int i = 0; i < animali.Length; i++)
            {
                if (specie[i] == specieMax)
                {
                    temp[posizione] = animali[i];
                    posizione++;
                }
            }

            return temp;
        }
    }
}
