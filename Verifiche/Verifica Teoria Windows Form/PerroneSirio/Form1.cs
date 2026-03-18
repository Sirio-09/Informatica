using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerroneSirio
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();

        static string[] Cognomi = {
            "Aigotti",
            "Boggetti",
            "Casu",
            "Isaia",
            "Frua",
            "Mandrile",
            "Stoppa",
            "Sciolla"
        };

        private static int[,] CreaMatriceRiempita(int n, int c)
        {
            int[,] Voti = new int[n, c];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Voti[i, j] = rnd.Next(1, 11);
                }
                Voti[i, c - 1] = i;
            }

            return Voti;
        }

        private static int VotoMax(int[,] matrix)
        {

        }

        public Form1()
        {
            InitializeComponent();
            int n = 10;
            int c = Cognomi.Length;

            for(int i = 0; i <  Cognomi.Length; i++)
            {
                int[,] matrix = CreaMatriceRiempita(n, c);
            }
            
            
            
        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_materie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
