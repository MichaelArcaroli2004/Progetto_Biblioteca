using Biblioteca_Bros_e_Arcaroli_Libreria;
using System;
using System.Windows.Forms;

namespace Bilioteca_Bros_e_Arcaroli
{
    public partial class frm_LibriPersonali : Form
    { //vengono visualizati i libri che si ha in prestito
        Biblioteca b = new Biblioteca();

        public frm_LibriPersonali(Biblioteca biblio)
        {
            InitializeComponent();
            b = biblio;
        }

        private void pct_home_Click(object sender, EventArgs e)
        {
            Frm_Biblioteca f = new Frm_Biblioteca(b);
            this.Visible = false;
            f.ShowDialog();

        }

        private void frm_LibriPersonali_Load(object sender, EventArgs e)
        {

        }
    }
}
