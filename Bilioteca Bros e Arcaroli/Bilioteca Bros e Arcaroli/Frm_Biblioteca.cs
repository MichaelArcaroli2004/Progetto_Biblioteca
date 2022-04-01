using Biblioteca_Bros_e_Arcaroli_Libreria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bilioteca_Bros_e_Arcaroli
{
    public partial class Frm_Biblioteca : Form
    {
        Biblioteca b = new Biblioteca();
        Button button;

        public Frm_Biblioteca(Biblioteca biblio)
        {
            InitializeComponent();
            b = biblio;
        }

        private void frmBiblioteca_Load(object sender, EventArgs e)
        {
            b.CreaLibro(10);            // viene richiamato il metodo CreaLibro per generare dei libri casualmete 
            cmb_OrdineLibri.Items.Add("Nome");
            cmb_OrdineLibri.Items.Add("Lunghezza");
            cmb_OrdineLibri.Items.Add("Genere");
            for (int i = 0; i < b.publicLstLibri.Count; i++)
                {
                        Button t = new Button();//creazione del pulsante in modo dinamico
                        this.Controls.Add(t);
                        t.Height = 110; t.Width = 80; t.Top = 140; t.Left = 40 + i * 90;//viene gestita la grandezza e la distanza dei pulsanti
                        t.Tag = i;//altezza e lunghezza del campo di pulsanti 
                        t.Text = b.publicLstLibri[i].Titolo;//vengono inseriti il titolo dalla classe
                        b.numeroLibroSelezionato = (i);
                        t.Click += new System.EventHandler(Cliccato); //il bottone richiama il metodo "Cliccato"
                        button = t;
                }
        }
        public void Cliccato(object sender, EventArgs e)
        {
            Button btn = (Button)sender; 
            string LibroScelto = btn.Tag.ToString();
            int numeroLibroScelto = int.Parse(LibroScelto);

            Frm_Libri libri = new Frm_Libri(b,numeroLibroScelto);
            libri.Show();
        }
        private void pct_ImmagineUtente_Click(object sender, EventArgs e)
        {   //mostra le informazione di registrazione dell'untente 
            if (b.publicLstUtenti[b.utenteSelezionato].Nome == " " || b.publicLstUtenti[b.utenteSelezionato].Cognome == " " || b.publicLstUtenti[b.utenteSelezionato].Email == " " || b.publicLstUtenti[b.utenteSelezionato].NumeroDiTelefono == " ")
            {
                Frm_Menù f = new Frm_Menù();
                f.ShowDialog();
            }
            else
            {
                frm_DatiUtente datiutente = new frm_DatiUtente(b);
                datiutente.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { // una texbox che server per cercare i libri per il loro titolo 
            lst_NomiLibriRicerca.Visible = true;
            List<Libro> libriTrovati = new List<Libro>();
            Random random = new Random();
            if (txt_Cerca.Text == "")
            {
                lst_NomiLibriRicerca.DataSource = null;
            }
            else
            {
                for (int i = 0; i < b.publicLstLibri.Count; i++)
                {
                    for (int k = 0; k < txt_Cerca.Text.Length; k++)
                    {
                        if (b.publicLstLibri[i].Titolo[k] == txt_Cerca.Text[k])
                        {
                            libriTrovati.Add(b.publicLstLibri[i]);
                            lst_NomiLibriRicerca.DataSource = null;
                            lst_NomiLibriRicerca.DataSource = libriTrovati;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
