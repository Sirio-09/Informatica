using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_19_Pag_116
{
    public partial class Form1 : Form
    {
        static string[] cantanti = {
            "Laura Pausini",
            "Laura Pausini",
            "Tiziano Ferro",
            "Tiziano Ferro",
            "Eros Ramazzotti",
            "Eros Ramazzotti",
            "Giorgia",
            "Giorgia",
            "Vasco Rossi",
            "Vasco Rossi"
        };

        static string[] canzoni = {
            "La solitudine",
            "Strani amori",
            "Sere nere",
            "Non me lo so spiegare",
            "Più bella cosa",
            "Un'emozione per sempre",
            "Come saprei",
            "Gocce di memoria",
            "Albachiara",
            "Sally"
        };

        public Form1()
        {
            InitializeComponent();
            lst_cantanti.Items.AddRange(cantanti);
            lst_canzoni.Items.AddRange(canzoni);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerca_Click(object sender, EventArgs e)
        {
            int count = 0;

            for(int i = 0; i < cantanti.Length; i++)
            {
                if (txt_nomeCantante.Text.CompareTo(cantanti[i]) == 0)
                {
                    count++;
                }
            }
            MessageBox.Show("Sono Presenti " + count + " Canzoni di " + txt_nomeCantante.Text);
        }

        private void lst_cantanti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
