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

namespace Es_Pag_159
{
    public partial class Form1 : Form
    {
        struct Studente
        {
            int matricola;
            string cognome;
            string nome;
            string dataNascita;
            string classe;
        }

        int nStudenti;
        string dato;

        public Form1()
        {
            InitializeComponent();

            do
            {
                dato = Interaction.InputBox("Inserisci Il Numero Degli Studenti: ");
            } while (!(int.TryParse(dato, out nStudenti)) && nStudenti <= 0);

            Studente[] studenti = new Studente[nStudenti];


            for(int i = 0; i < nStudenti; i++)
            {
                if(i == 0)
                {
                    dato = Interaction.InputBox("Matricola Studente: ");
                }
                else
                {
                    do
                    {

                    }while()
                }
            }

        }
    }
}
