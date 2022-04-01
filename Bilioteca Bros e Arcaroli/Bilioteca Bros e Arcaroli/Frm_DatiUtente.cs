using Biblioteca_Bros_e_Arcaroli_Libreria;
using System;
using System.Windows.Forms;

namespace Bilioteca_Bros_e_Arcaroli
{
    public partial class frm_DatiUtente : Form
    {
        Biblioteca b = new Biblioteca();
        utenti u;
        public frm_DatiUtente(Biblioteca biblio)
        {
            InitializeComponent();
            b = biblio;
        }

        private void frm_DatiUtente_Load(object sender, EventArgs e)
        {
            //vengono mostrare tutti i dati dell'utente 
            lbl_NomeUtente.Text = b.publicLstUtenti[b.utenteSelezionato].Nome;
            lbl_CognomeUtente.Text = b.publicLstUtenti[b.utenteSelezionato].Cognome;
            lbl_EmailUtente.Text = b.publicLstUtenti[b.utenteSelezionato].Email;
            lbl_TelefonoUtente.Text = b.publicLstUtenti[b.utenteSelezionato].NumeroDiTelefono;
        }

        private void btn_libriPersonali_Click(object sender, EventArgs e)
        {
            frm_LibriPersonali f = new frm_LibriPersonali(b);
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
