using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;


namespace Es_Pag_168
{
    struct Libri
    {
        public string codLibro;
        public string titolo;
        public string autore;
        public string casaEditrice;
        public string genere;
        public string costo;

        public override string ToString()
        {
            return $"{codLibro}, {titolo}, {autore}, {casaEditrice}, {genere}, {costo}";
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_scrivi_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Libri.dat"))
            {
                Libri libro = new Libri();
                string risposta = "";

                do
                {
                    libro.codLibro = Interaction.InputBox("Inserisci il Codice: ");
                    libro.titolo = Interaction.InputBox("Inserisci il Titolo: ");
                    libro.autore = Interaction.InputBox("Inserisci l'Autore: ");
                    libro.casaEditrice = Interaction.InputBox("Inserisci la Casa Editrice: ");
                    libro.genere = Interaction.InputBox("Inserisci il Genere: ");
                    libro.costo = Interaction.InputBox("Inserisci il Costo: ");

                    sw.WriteLine(libro.ToString());

                    risposta = Interaction.InputBox("Vuoi Continuare?(S/N)");

                } while (risposta.ToUpper() == "S");
            }
        }

        private void btn_leggi_Click(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader("Libri.dat"))
            {
                string riga = "";

                while((riga = sr.ReadLine()) != null)
                {
                    string[] libro = new string[6];
                    libro = riga.Split(',');
                    string msg = "Dati del Libro: \n";

                    foreach(string s in libro)
                    {
                        msg += s + "\n";
                    }
                    MessageBox.Show(msg);
                }
            }
        }
    }
}
