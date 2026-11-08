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
            PopolaDatiDiProva();
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

            dgvCatalogo.DataSource = _libreria.OttieniLista().Select(p => new
            {
                Titolo = p.Titolo,
                Autore = p.Autore,
                Prezzo = p.Prezzo,
                Pagine = (p is Libro l) ? (int?)l.numeroPagine : null,
                Edizione = (p is Rivista r) ? (int?)r.NumeroEdizione : null
            }).ToList();
        }

        private void btnCercaTitolo_Click(object sender, EventArgs e)
        {
            lblCercaAutore.Text = string.Empty;
            lblCercaNPagine.Text = string.Empty;
            lblCercaNEdizione.Text = string.Empty;
            lblCercaPrezzo.Text = string.Empty;

            if(txtCercaTitolo.Text == string.Empty)
            {
                MessageBox.Show("Bisogna Inserire prima tutti i Dati!");
            }
            else
            {
                Pubblicazione t = _libreria.CercaPerTitolo(txtCercaTitolo.Text);

                if(t != null)
                {
                    if(t is Libro l)
                    {

                        lblCercaAutore.Text = l.Autore;
                        lblCercaNPagine.Text = l.numeroPagine.ToString();
                        lblCercaPrezzo.Text = l.Prezzo.ToString();
                    }
                    else if(t is Rivista r)
                    {
                        lblCercaAutore.Text = r.Autore;
                        lblCercaNEdizione.Text = r.NumeroEdizione.ToString();
                        lblCercaPrezzo.Text = r.Prezzo.ToString();
                    }
                }
            }
        }

        private void btnPrezzoMedio_Click(object sender, EventArgs e)
        {
            lblPrezzoMedio.Text = string.Empty;
            double prezzoMedio = _libreria.CalcolaPrezzoMedio();
            lblPrezzoMedio.Text = prezzoMedio.ToString("F2");
        }

        private void PopolaDatiDiProva()
        {
            _libreria.AggiungiPubblicazione(new Libro("1984", "George Orwell", 12.50, 328));
            _libreria.AggiungiPubblicazione(new Libro("Il Signore degli Anelli", "J.R.R. Tolkien", 25.00, 1200));
            _libreria.AggiungiPubblicazione(new Libro("Il Nome della Rosa", "Umberto Eco", 15.80, 512));

            _libreria.AggiungiPubblicazione(new Rivista("Focus", "Mondadori", 4.90, 354));
            _libreria.AggiungiPubblicazione(new Rivista("National Geographic", "NG Society", 6.50, 420));
        }
    }
}
