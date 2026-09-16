using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_17_Pag_116
{
    public partial class FormCanzoni : Form
    {
        string[] cantanti = {
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

        string[] canzoni = {
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

        public FormCanzoni()
        {
            InitializeComponent();
            lst_Cantanti.Items.AddRange(cantanti);
            lst_Canzoni.Items.AddRange(canzoni);
        }
    }
}
