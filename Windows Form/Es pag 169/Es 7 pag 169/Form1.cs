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


namespace Es_7_pag_169
{
    public partial class Form1 : Form
    {
        public struct Libri
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

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_leggi_Click(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader("Libri.dat"))
            {
                Libri libro;

                while (!sr.EndOfStream)
                {
                    Read(sr, out libro);
                    MessageBox.Show(libro.ToString());
                }
            }
        }

        private void Read(StreamReader sr, out Libri libro)
        {
            libro = new Libri();

            libro.codLibro = sr.ReadLine();
            libro.titolo = sr.ReadLine();
            libro.autore = sr.ReadLine();  
            libro.casaEditrice = sr.ReadLine();
            libro.genere = sr.ReadLine();
            libro.costo = sr.ReadLine();
        }
    }
}
