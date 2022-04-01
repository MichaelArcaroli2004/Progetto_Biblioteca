using Biblioteca_Bros_e_Arcaroli_Libreria;
using System;
using System.Windows.Forms;

namespace Bilioteca_Bros_e_Arcaroli
{
    public partial class Frm_Menù : Form
    {
        Biblioteca b;
        public Frm_Menù()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Biblioteca();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //viene aperta la form Login
            this.Width = 1;
            this.Height = 1;
            Frm_Login frm = new Frm_Login(b);
            frm.ShowDialog();
            Close();
        }

        private void btn_Registrati_Click(object sender, EventArgs e)
        { // viene aperta la form Registrati
            Frm_Registrati frm = new Frm_Registrati(b);
            frm.ShowDialog();
        }

        private void btn_ApriVeloce_Click(object sender, EventArgs e)
        { // viene aperta la form biblioteca senza effettuare l'accesso
            this.Width = 1;
            this.Height = 1;
            utenti u = new utenti(" ", " ", " ", " "," ") ;
            b.AddUtenti(u);
            Frm_Biblioteca f = new Frm_Biblioteca(b);
            f.ShowDialog();
            Close();
        }
    }
}
