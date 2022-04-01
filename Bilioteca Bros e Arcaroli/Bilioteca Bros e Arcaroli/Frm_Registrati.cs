using Biblioteca_Bros_e_Arcaroli_Libreria;
using System;
using System.Windows.Forms;


namespace Bilioteca_Bros_e_Arcaroli
{
    public partial class Frm_Registrati : Form
    {
        Biblioteca b = new Biblioteca();
        public Frm_Registrati(Biblioteca biblio)
        {
            InitializeComponent();
            b = biblio;

        }

        private void btn_Indietro_Click(object sender, EventArgs e)
        { //viene chiusa la form
            Close();
        }



        private void btn_Registrati_Click(object sender, EventArgs e)
        {  // i dati che abbiamo inerito nelle texbox vengono inserite nella classe bliblioteca

            if (txt_Telefono.Text == "" || txt_Email.Text == "" || txt_Cognome.Text == "" || txt_Nome.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Mancano dei Dati");
            }
            else
            {  // vengono inserite le singole texbox con gli attributi 
                utenti u = new utenti(txt_Password.Text,txt_Nome.Text, txt_Cognome.Text,txt_Telefono.Text, txt_Email.Text);
                b.AddUtenti(u);
                Close();
            }
        }

    }
}
