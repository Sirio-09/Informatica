using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_1_Pag_150
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();

        static string[] cognomi = {
            "Aigotti",
            "Bianchi",
            "Rossi",
            "Verdi",
            "Neri",
            "Isaia",
            "Bruni",
            "Ferrari",
            "Romano",
            "Conti"
        };

        public Form1()
        {
            InitializeComponent();
            lst_cognomi.Items.AddRange(cognomi);
        }

        private void btn_sorteggia_Click(object sender, EventArgs e)
        {
            lst_turni.Items.Clear();

            if (txt_gruppi.Text == "")
            {
                MessageBox.Show("Inserire il numero di membri dei gruppi!");
                return;
            }

            int numGruppo = Convert.ToInt32(txt_gruppi.Text);

            if (numGruppo < 3 || numGruppo > 5)
            {
                MessageBox.Show("Il numero dei memberi deve essere fra 3 e 5");
                return;
            }
            if (numGruppo > cognomi.Length)
            {
                MessageBox.Show("Non ci sono abbastanza cognomi nell'elenco.");
                return;
            }

            List<string> Cognomi = new List<string>(cognomi);

            while (Cognomi.Count > 0)
            {   
                for (int j = 0; j < numGruppo; j++)
                {
                    if (Cognomi.Count > 0)
                    {
                        int randomIndex = rnd.Next(0, Cognomi.Count);
                        lst_turni.Items.Add(Cognomi[randomIndex]);
                        Cognomi.RemoveAt(randomIndex);
                    }
                }
                if (Cognomi.Count > 0)
                {
                    lst_turni.Items.Add("----");
                }
            }
        }
    }
}
