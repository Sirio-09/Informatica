using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_Pag_161
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

            studenti = new Studente[n];

            studenti[0] = new Studente { matricola = 101, cognome = "Rossi", nome = "Mario", dataNascita = "10/05/2005", classe = "3A" };
            studenti[1] = new Studente { matricola = 105, cognome = "Bianchi", nome = "Luca", dataNascita = "22/08/2005", classe = "3A" };
            studenti[2] = new Studente { matricola = 112, cognome = "Verdi", nome = "Giulia", dataNascita = "15/01/2005", classe = "3B" };
            studenti[3] = new Studente { matricola = 120, cognome = "Gialli", nome = "Anna", dataNascita = "03/11/2005", classe = "3C" };
            studenti[4] = new Studente { matricola = 135, cognome = "Neri", nome = "Paolo", dataNascita = "30/04/2005", classe = "3A" };

            string dato;

            dato = Interaction.InputBox("Inserisci Il Cognome: ", "Ricerca Studente");

            if (string.IsNullOrEmpty(dato)) return;
            
            bool found = false;
            for(int i = 0; i < n; i++)
            {
                if (studenti[i].cognome == dato)
                {
                    string output = $"{studenti[i].matricola} - " +
                                    $"{studenti[i].cognome} - " +
                                    $"{studenti[i].nome} - " +
                                    $"{studenti[i].dataNascita} - " +
                                    $"{studenti[i].classe}";

                    lst_studenti.Items.Add(output);
                    found = true;
                }
            }
            if (!found)
            {
                MessageBox.Show("Cognome non trovato.", "Risultato Ricerca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
