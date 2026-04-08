using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_Pag_162
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

        int n = 5;
        Studente[] studenti;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studenti = new Studente[n];

            studenti[0] = new Studente { matricola = 1, cognome = "Zanetti", nome = "Luca", dataNascita = "12/04/2006", classe = "3A" };
            studenti[1] = new Studente { matricola = 2, cognome = "Bianchi", nome = "Marco", dataNascita = "05/11/2006", classe = "3A" };
            studenti[2] = new Studente { matricola = 3, cognome = "Rossi", nome = "Mario", dataNascita = "21/01/2006", classe = "3A" };
            studenti[3] = new Studente { matricola = 4, cognome = "Rossi", nome = "Alberto", dataNascita = "10/09/2006", classe = "3A" };
            studenti[4] = new Studente { matricola = 5, cognome = "Esposito", nome = "Ciro", dataNascita = "30/03/2006", classe = "3A" };

            int i = -1;
            bool scambio;
            Studente recApp;

            do
            {
                i = i + 1;
                scambio = false;

                for (int j = n - 2; j >= i; j--)
                {
                    if (string.Compare(studenti[j].cognome, studenti[j + 1].cognome) >= 0)
                    {
                        if (studenti[j].cognome == studenti[j + 1].cognome)
                        {
                            if (string.Compare(studenti[j].nome, studenti[j + 1].nome) > 0)
                            {
                                recApp = studenti[j];
                                studenti[j] = studenti[j + 1];
                                studenti[j + 1] = recApp;
                                scambio = true;
                            }
                        }
                        else
                        {
                            recApp = studenti[j];
                            studenti[j] = studenti[j + 1];
                            studenti[j + 1] = recApp;
                            scambio = true;
                        }
                    }
                }

            } while (!(i == n - 2 || !scambio));

            lst_studenti.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                string output = $"{studenti[k].matricola} - " +
                                $"{studenti[k].cognome} - " +
                                $"{studenti[k].nome} - " +
                                $"{studenti[k].dataNascita} - " +
                                $"{studenti[k].classe}";

                lst_studenti.Items.Add(output);
            }
        }
    }
}