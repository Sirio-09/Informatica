using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**********************/
        /* Struttura Studente */
        /**********************/

        public struct studente
        {
            // Definisco le Caratteristiche

            public int nMatr;
            public string cognome;
            public string nome;
            public DateTime dataN;
            public string classe; // 3A - 4B - 5C
            public string spec; // INF - MEC - ELT

            // Costruttore
            public studente(int nM, string co, string no, DateTime dN, string cl, string sp)
            {
                nMatr = nM;
                cognome = co;
                nome = no;
                dataN = dN;
                classe = cl;
                spec = sp;
            }

            // Pulizia Dati Studente
            public void clear()
            {
                nMatr = 0;
                cognome = string.Empty;
                nome = string.Empty;
                dataN = DateTime.MinValue;
                classe = string.Empty;
                spec = string.Empty;
            }

            // Calcolo Eta Studente
            public int calcolaEta()
            {
                int eta;

                eta = DateTime.Now.Year - dataN.Year;

                return eta;
            }

            // Dati dello Studente
            public string getStudente()
            {
                return $"No Matricola = {nMatr}" +
                       $" | Cognome = {cognome}" +
                       $" | Nome = {nome}" +
                       $" | Data Nascita = {dataN.ToString(@"dd\/MM\/yyyy")}" +
                       $" | Classe = {classe}" +
                       $" | Specializzazione = {spec}";
            }

            // Dati Studente per Salvare su File
            public override string ToString()
            {
                return nMatr.ToString() + ";";

                //DA FINIRE
            }
        }
    }
}
