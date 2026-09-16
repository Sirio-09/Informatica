using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_Pag_163
{
    public partial class Form1 : Form
    {
        public struct Studente
        {
            public int matricola;
            public string cognome;
            public string nome;
            public string dataNascita;
            public string classe;
        }

        int n = 3;
        int m = 4;
        Studente[] studenti1;
        Studente[] studenti2;
        Studente[] studentiMerge;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studenti1 = new Studente[n + 1];
            studenti2 = new Studente[m + 1];
            studentiMerge = new Studente[n + m];

            studenti1[0] = new Studente { matricola = 101, cognome = "Bianchi", nome = "Luca", dataNascita = "10/05/2005", classe = "3A" };
            studenti1[1] = new Studente { matricola = 108, cognome = "Rossi", nome = "Mario", dataNascita = "22/08/2005", classe = "3A" };
            studenti1[2] = new Studente { matricola = 112, cognome = "Verdi", nome = "Giulia", dataNascita = "15/01/2005", classe = "3B" };
            studenti1[n].matricola = 999999;

            studenti2[0] = new Studente { matricola = 102, cognome = "Gialli", nome = "Anna", dataNascita = "03/11/2005", classe = "3C" };
            studenti2[1] = new Studente { matricola = 105, cognome = "Neri", nome = "Paolo", dataNascita = "30/04/2005", classe = "3A" };
            studenti2[2] = new Studente { matricola = 110, cognome = "Marrone", nome = "Sofia", dataNascita = "12/07/2005", classe = "3B" };
            studenti2[3] = new Studente { matricola = 120, cognome = "Viola", nome = "Sara", dataNascita = "25/02/2005", classe = "3C" };
            studenti2[m].matricola = 999999;

            int i = 0;
            int j = 0;

            for (int k = 0; k < (n + m); k++)
            {
                if (studenti1[i].matricola > studenti2[j].matricola)
                {
                    studentiMerge[k] = studenti2[j];
                    j = j + 1;
                }
                else
                {
                    studentiMerge[k] = studenti1[i];
                    i = i + 1;
                }
            }

            lst_studenti.Items.Clear();

            for (int k = 0; k < (n + m); k++)
            {
                string output = $"{studentiMerge[k].matricola} - " +
                                $"{studentiMerge[k].cognome} - " +
                                $"{studentiMerge[k].nome} - " +
                                $"{studentiMerge[k].dataNascita} - " +
                                $"{studentiMerge[k].classe}";

                lst_studenti.Items.Add(output);
            }
        }
    }
}