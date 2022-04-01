using Biblioteca_Bros_e_Arcaroli_Libreria;
using System;
using System.Windows.Forms;

namespace Bilioteca_Bros_e_Arcaroli
{
    public partial class Frm_Login : Form
    {
        Biblioteca b = new Biblioteca();
        public Frm_Login(Biblioteca biblio)
        {
            InitializeComponent();
            b = biblio;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        { //controllo che le credenziali siano complete
            if (txt_Email.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Mancano dei Dati");
            }
            else
            {
                for (int i = 0; i < b.publicLstUtenti.Count; i++)
                {
                    if (b.publicLstUtenti[i+1].Email == txt_Email.Text && b.publicLstUtenti[i+1].Password == txt_Password.Text)//controllo che le credenziali che siano corrette
                    {
                        b.utenteSelezionato = i;
                        this.Visible = false;
                        Frm_Biblioteca f = new Frm_Biblioteca(b);
                        f.ShowDialog();
                    }
                    else if (i == b.publicLstUtenti.Count - 1)
                    {
                        MessageBox.Show("Email o Password sbagliata");
                    }
                }
            }

        }

        private void btn_Indietro_Click(object sender, EventArgs e)
        { //viene chiusa la form per tornare indietroù
            this.Width = 1;
            this.Height = 1;
            Frm_Menù f = new Frm_Menù();
            f.ShowDialog();
            Close();
        }

    }
}
