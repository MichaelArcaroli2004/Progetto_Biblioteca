using System;
using System.Collections.Generic;
namespace Biblioteca_Bros_e_Arcaroli_Libreria
{
    public class Biblioteca
    {
        #region variabili
        List<utenti> LstUtenti = new List<utenti>();
        List<Libro> LstLibri = new List<Libro>();
        List<DVD> LstDvd = new List<DVD>();
        public DateTime dataPrestito { get; set; }
        public DateTime dataRestituzione { get; set; }
        int valore = 0;
        public int utenteSelezionato { get { return valore; } set { value = valore; } }
        public int numeroLibroSelezionato { get; set; }

        public List<utenti> publicLstUtenti { get { return LstUtenti; } }
        public List<Libro> publicLstLibri { get { return LstLibri; } }
        public List<DVD> publicLstDvd { get { return LstDvd; } }

        #endregion
        public void Prestito()
        {
            dataPrestito = DateTime.Now;
            dataRestituzione = DateTime.Now.AddMonths(1);
        }
        public void AddUtenti(utenti u)
        {
            LstUtenti.Add(u);
        }
        public void AddLibri(Libro l)
        {
            LstLibri.Add(l);
        }
        #region CreaDatiDocumenti
        static string CreaNome()
        {
            string[] articoloMaschileSingolare = new string[] { "Il", "Un", " Lo", "Uno", "L'" };
            string[] articoloMaschilePlurale = new string[] { "I", "Alcuni", "Gli" };
            string[] articoloFemminileSingolare = new string[] { "La", "una", "L'", "un'" };
            string[] articoloFemminilePlurale = new string[] { "Alcune", "Le" };
            string[] NomeMaschileSingolare = new string[] { "gatto", "bambino", "gallo", "leone", "toro", "cane", "gnomo", "ariete", "elefante" };
            string[] NomeMaschilePlurale = new string[] { "ragazzi", "grilli", "cuochi", "polli", "studenti", "animali" };
            string[] NomeFemminileSingolare = new string[] { "gatta", "gallina", "mucca", "regina", "volpe", "dottoressa", "psicologa", "iena", "elefantessa", "amica" };
            string[] NomeFemminilePlurale = new string[] { "tigri", "persone", "giraffe", "api", "oche" };
            string[] AggettivoMaschileSingolare = new string[] { "maldestro", "squilibrato", "affascinante", "affidabile", "abile", "inaffidabile", "allegro" };
            string[] AggettivoFemminileSingolare = new string[] { "bella", "brutta", "scontrosa", "malvagia", "carismatica", "fedele", "coraggiosa", "divertente", "egoista", "introversa" };
            string[] AggettivoMaschilePlurale = new string[] { "divertenti", "squilibrati", "fedeli", "gioiosi", "tristi", "introversi", "assassini" };
            string[] AggettivoFemminilePlurale = new string[] { "paurose", "pericolose", "premurose", "bugiarde", "impavide ", "intelligenti", "orgogliose" };
            Random frase = new Random();
            int numero = frase.Next(4);
            if (numero == 0)
            {
                string[] titoloMS = new string[] { $"{articoloMaschileSingolare[frase.Next(articoloMaschileSingolare.Length - 3)]} {NomeMaschileSingolare[frase.Next(NomeMaschileSingolare.Length - 3)]}", $"{articoloMaschileSingolare[frase.Next(2, articoloMaschileSingolare.Length - 1)]} {NomeMaschileSingolare[frase.Next(6, NomeMaschileSingolare.Length - 2)]}", $"{articoloMaschileSingolare[articoloMaschileSingolare.Length - 1]} {NomeMaschileSingolare[frase.Next(7, NomeMaschileSingolare.Length)]}", $" { AggettivoMaschileSingolare[frase.Next(AggettivoMaschileSingolare.Length)]}" };
                return titoloMS[frase.Next(titoloMS.Length - 1)] + titoloMS[titoloMS.Length - 1];
            }
            else if (numero == 1)
            {
                string[] titoloMP = new string[] { $"{articoloMaschilePlurale[frase.Next(articoloMaschilePlurale.Length - 2)]} {NomeMaschilePlurale[frase.Next(NomeMaschilePlurale.Length - 2)]}", $"{articoloMaschilePlurale[frase.Next(2, articoloMaschilePlurale.Length)]} {NomeMaschilePlurale[frase.Next(4, NomeMaschilePlurale.Length)]}", $" {AggettivoMaschilePlurale[frase.Next(AggettivoMaschilePlurale.Length)]}" };
                return titoloMP[frase.Next(titoloMP.Length - 1)] + titoloMP[titoloMP.Length - 1];
            }
            else if (numero == 2)
            {
                string[] titoloFS = new string[] { $"{articoloFemminileSingolare[frase.Next(articoloFemminileSingolare.Length - 2)]} {NomeFemminileSingolare[frase.Next(NomeFemminileSingolare.Length - 2)]}", $"{articoloFemminileSingolare[frase.Next(2, articoloFemminileSingolare.Length)]} { NomeFemminileSingolare[frase.Next(8, NomeFemminileSingolare.Length)] }", $" {AggettivoFemminileSingolare[frase.Next(AggettivoFemminileSingolare.Length)]}" };
                return titoloFS[frase.Next(titoloFS.Length - 1)] + titoloFS[titoloFS.Length - 1];
            }
            else
            {
                string[] titoloFP = new string[] { $"{articoloFemminilePlurale[frase.Next(articoloFemminilePlurale.Length)]} {NomeFemminilePlurale[frase.Next(NomeFemminilePlurale.Length)]}", $" {AggettivoFemminilePlurale[frase.Next(AggettivoFemminilePlurale.Length)]}" };
                return titoloFP[frase.Next(titoloFP.Length - 1)] + titoloFP[titoloFP.Length - 1];
            }
        }
        static string CreaISBN()
        {
            string caratteri = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] caratteriScelti = new char[6];
            Random random = new Random();

            for (int i = 0; i < caratteriScelti.Length; i++)
            {
                caratteriScelti[i] = caratteri[random.Next(caratteri.Length)];
            }

            var stringa = new String(caratteriScelti);
            return stringa;
        }
        static string CreaAutore()
        {
            string[] NomeMaschili = new string[] { " Leonardo", " Francesco", " Alessandro", " Mattia", " Lorenzo", " Andrea", " Gabriele", " Gabriel", " Tommaso", " Riccardo", " Giuseppe", " Matteo", " Nicolò", " Antonio ", " Federico ", " David ", " Diego", " Giovanni ", " Filippo ", " Pietro ", " Christian "};
            string[] NomeFemminili = new string[] { " Beatrice", " Sofia", " Ginevra", " Gaia", " Aurora", " Nicole ", " Greta", " Emma ", " Chloe	", " Matilde", " Alice	", " Clara ", " Luisa	", " Fabiana ", " Dafne", " Perla", " Miriam", " Iris ", " Marianna	", " Ginevra", " Margherita", " Gloria", " Giulia"};
            string[] Cognomi = new string[] { " Rossi", " Ferrari ", " Russo", " Bianchi ", " Romano", " Gallo ", " Costa", " Fontana ", " Conti", " Esposito ", " Ricci", " Bruno ", " De Luca ", " Moretti", " Marino", " Greco", " Barbieri", " Lombardi ", " Giordano", " Cassano", " Colombo", " Mancini", " Longo", " Leone ", " Martinelli" };
            var rand = new Random();
            int x = rand.Next(2);

            if (x == 0)
            {
                string nomeM = NomeMaschili[rand.Next(NomeMaschili.Length)];
                string CognomeM = Cognomi[rand.Next(Cognomi.Length)];
                return nomeM + " " + CognomeM;
            }
            else
            {
                string nomeF = NomeFemminili[rand.Next(NomeFemminili.Length)];
                string CognomeF = Cognomi[rand.Next(Cognomi.Length)];
                return nomeF + " " + CognomeF;
            }
        }
        static string CreaGenere()
        {
            string[] Generi = new string[] { "BIOGRAFIA E AUTOBIOGRAFIA", "ROMANZO STORICO", "GIALLO", "THRILLER", "AVVENTURA E AZIONE", "AVVENTURA E AZIONE", "AVVENTURA E AZIONE", "FANTASCIENZA", "FANTASCIENZA", "FANTASY", "HORROR", "FANTASY" };
            Random numero = new Random();
            return Generi[numero.Next(Generi.Length)];
        }
        
        static int CreaPagine()
        {
            Random numero = new Random();
            return numero.Next(50, 300);
        }
        #endregion
        #region CreaLibro
        public void CreaLibro(int quantitàDiLibri)
        {
            for (int i = 0; i < quantitàDiLibri; i++)
            {
                Libro libro = new Libro(CreaISBN(), CreaPagine(), CreaNome(), CreaAutore(), CreaGenere());
                AddLibri(libro);
            }
        }
        #endregion
    }
    public class Documenti
    {
        public string Titolo { get; set; }
        public string Genere { get; set; }

        public string Autore { get; set; }
        public bool Stato { get; set; }
        public int Scaffale { get; set; }

        List<Libro> LstLibri = new List<Libro>();
        List<DVD> LstDVD = new List<DVD>();
        public Documenti(string titolo, string autore, string genere)
        {
            this.Titolo = titolo;
            this.Autore = autore;
            this.Genere = genere;
        }
        public void AddLibri(Libro l)
        {
            LstLibri.Add(l);
        }
        public void AddDVD(DVD d)
        {
            LstDVD.Add(d);
        }
    }
    public class Libro : Documenti
    {
        public string ISBN { get; set; }
        public int Pagine { get; set; }

        public Libro(string isbn, int pagine, string titolo, string autore, string genere) : base(titolo, autore, genere)
        {
            this.ISBN = isbn;
            this.Pagine = pagine;
        }
        public override string ToString()
        {
            return Titolo;
        }
    }
    public class DVD : Documenti
    {
        public string numeroSeriale { get; set; }
        int durata;
        public DVD(string numeroSeriale, int durata, string codice, string titolo, string autore) : base(codice, titolo, autore)
        {
            this.numeroSeriale = numeroSeriale;
            this.durata = durata;
        }
    }
    public class utenti : Persona
    {
        public string Password { get; set; }
        List<Documenti> lstDocumentiInPossesso = new List<Documenti>();
        public utenti(string password, string nome, string cognome, string numeroditelefono, string email) : base (nome, cognome, numeroditelefono, email)
        {
        
        }
    }
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumeroDiTelefono { get; set; }
        public string Email { get; set; }
        public Persona (string nome, string cognome, string numeroditelefono, string email)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.NumeroDiTelefono = numeroditelefono;
            this.Email = email;
        }
    }
}
