using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es_Biblioteca
{
    public partial class Form1 : Form
    {
        private Libreria _libreria = new Libreria();


        public Form1()
        {
            InitializeComponent();

            ConfiguraDataGridView();
        }

        private void ConfiguraDataGridView()
        {
            // Disattiva la creazione automatica delle sole 3 colonne base
            dgvCatalogo.AutoGenerateColumns = false;
            dgvCatalogo.Columns.Clear();

            // Colonna Titolo
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Titolo1",
                HeaderText = "Titolo"
            });

            // Colonna Autore
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Autore1",
                HeaderText = "Autore"
            });

            // Colonna Prezzo
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Prezzo1",
                HeaderText = "Prezzo (€)"
            });

            // Colonna Numero Pagine (per i Libri)
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroPagine1",
                HeaderText = "N° Pagine"
            });

            // Colonna Numero Edizione (per le Riviste)
            dgvCatalogo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroEdizione1",
                HeaderText = "N° Edizione"
            });
        }

        private void btnAggiungiLibro_Click(object sender, EventArgs e)
        {
            if(txtTitolo.Text == string.Empty || txtAutore.Text == string.Empty || nudPrezzo.Value == 0 || nudNPagine.Value == 0)
            {
                MessageBox.Show("Bisogna Inserire prima tutti i Dati!");
            }
            else
            {
                Libro l = new Libro(txtTitolo.Text, txtAutore.Text, ((double)nudPrezzo.Value), (int)nudNPagine.Value);
                _libreria.AggiungiPubblicazione(l);

                MessageBox.Show("Libro Aggiunto al Catalogo");

                txtTitolo.Text = string.Empty;
                txtAutore.Text = string.Empty;
                nudNPagine.Value = 0;
                nudPrezzo.Value = 0;
            }
        }

        private void btnAggiungiRivista_Click(object sender, EventArgs e)
        {
            if (txtTitoloRivista.Text == string.Empty || txtAutoreRivista.Text == string.Empty || nudPrezzoRivista.Value == 0 || nudNEdizione.Value == 0)
            {
                MessageBox.Show("Bisogna Inserire prima tutti i Dati!");
            }
            else
            {
                Rivista r = new Rivista(txtTitoloRivista.Text, txtAutoreRivista.Text, ((double)nudPrezzoRivista.Value), (int)nudNEdizione.Value);
                _libreria.AggiungiPubblicazione(r);

                MessageBox.Show("Libro Aggiunto al Catalogo");

                txtTitoloRivista.Text = string.Empty;
                txtAutoreRivista.Text = string.Empty;
                nudNEdizione.Value = 0;
                nudPrezzoRivista.Value = 0;
            }
        }

        private void btnMostraCatalogo_Click(object sender, EventArgs e)
        {
            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = _libreria.OttieniLista();
        }
    }
}
