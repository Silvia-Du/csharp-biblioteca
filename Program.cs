// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
 *
 *Esercizio:
Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
cognome,
nome,
email,
password,
recapito telefonico,
Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
titolo,
anno,
settore (storia, matematica, economia, …),
stato (In Prestito, Disponibile),
uno scaffale in cui è posizionato,
un autore (Nome, Cognome).
Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il 
periodo (Dal/Al) del prestito e il documento.
Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
 * */

//OGGETTO = BIBLIOTECA : NOME , PRODOTTI
//OGGETTO = UTENTE : COGNOME NOME, EMAIL, PWORD, TEL
//OGGETTO DOCUMENTO = CODICE STRINGA (LIBRI = ISBN , DVD = NUM SERIALE), TITOLO, ANNO, SETTORE, STATO, SCAFFALE, AUTORE(NOME, COGNOME)
// OGGETTO FIGLIO LIBRO = + NUMERO DI PAGINE, 
// OGGETTO FIGLIO DVD = + DURATA, 
//FUNZIONI RICERCA PER CODICE 
//FUNZIONE RICERCA PER TITOLO
//EFFETTUARE PRESTITO = DATA INIZIO E DATA FINE
//RICERCARE PRENOTAZIONE DANDO NOME E COGNOME

//OGGETTO = BIBLIOTECA : NOME , PRODOTTI
//LISTA LIBRI, LISTA DVD
//FUNZIONE AGGIUNGI NUOVO OGGETTO = RICHIAMO IL COSTRUTTORE DELLA CLASSE FIGLIO
//FUNZIONE RIMUOVI OGGETTO

public class Biblioteca
{
    string name; 
    List<string> books;
    List<string> dvd;


    public Biblioteca(string name)
    {
        this.name = name;
    }

}

public class Product
{
    string title;
    int year;
    string sector;
    bool isAvailable;
    string shelf;
    string authorName;
    string authorSurname;

    public Product(string title, int year, string sector, bool isAvailable, string shelf, string authorName, string authorSurname)
    {
        this.title = title;
        this.year = year;
        this.sector = sector;
        this.isAvailable = isAvailable;
        this.shelf = shelf;
        this.authorName = authorName;
        this.authorSurname = authorSurname;
    }

}


