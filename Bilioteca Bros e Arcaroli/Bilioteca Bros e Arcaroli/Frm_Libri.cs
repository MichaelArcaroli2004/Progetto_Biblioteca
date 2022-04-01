using Biblioteca_Bros_e_Arcaroli_Libreria;
using System;
using System.Windows.Forms;

namespace Bilioteca_Bros_e_Arcaroli
{
    public partial class Frm_Libri : Form
    {
        Biblioteca b = new Biblioteca();
        int riga;        
        public Frm_Libri(Biblioteca biblio, int riga)
        {
            InitializeComponent();
            b = biblio;
            this.riga = riga;
        }

        private void Frm_Libri_Load(object sender, EventArgs e)
        {
            lbl_TitoloLibro.Text = b.publicLstLibri[riga].Titolo;
            lbl_NumPagineLibro.Text = $"{b.publicLstLibri[riga].Pagine}";
            lbl_GenereLibro.Text = b.publicLstLibri[riga].Genere;
            lbl_AutoreLibro.Text = b.publicLstLibri[riga].Autore;
            lbl_CodiceLibro.Text = b.publicLstLibri[riga].ISBN;
        }
    }
}
