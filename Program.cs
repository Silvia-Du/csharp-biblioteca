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

//OGGETTO = BIBLIOTECA : NOME , PRODOTTI * fatto
//OGGETTO = UTENTE : COGNOME NOME, EMAIL, PWORD, TEL *fatto
//OGGETTO DOCUMENTO = CODICE STRINGA (LIBRI = ISBN , DVD = NUM SERIALE), TITOLO, ANNO, SETTORE, STATO, SCAFFALE, AUTORE(NOME, COGNOME) * fatto
// OGGETTO FIGLIO LIBRO = + NUMERO DI PAGINE, * fatto
// OGGETTO FIGLIO DVD = + DURATA, *fatto 
// OGGETTO PRENOTAZIONE = DATA INZIO, DATA DI FINE, NOME COGNOME, ARTICOLO *fatto

//LISTA LIBRI, LISTA DVD * fatto

//FUNZIONI RICERCA PER CODICE 
//FUNZIONE RICERCA PER TITOLO
//EFFETTUARE PRESTITO = DATA INIZIO E DATA FINE
//RICERCARE PRENOTAZIONE DANDO NOME E COGNOME



//NELLA BIBLIOTECA: 

//FUNZIONE AGGIUNGI NUOVO OGGETTO = RICHIAMO IL COSTRUTTORE DELLA CLASSE FIGLIO
//FUNZIONE RIMUOVI OGGETTO

// devo inserire i libri nella lista della blblioteca

Biblioteca boolTeca = new Biblioteca("boolTeca");


Book mobyDick = new Book("Moby Dick", 1851);
Book marshal = new Book("Le parole sono fineste oppure muri", 1999);

Dvd bigFish = new Dvd("Big Fish", 2003);
Dvd edward = new Dvd("Edward mani di forbici", 2003);

User ugo = new User("Ugo", "DeUghi", "ugo@gmail.com", "password1", 389789654);
User dudi = new User("Dudi", "DeDudi", "dudi@gmail.com", "password2", 389789656);


Console.WriteLine("sei della biblioteca?y-n");
string response = Console.ReadLine().ToLower();

bool start = false;
while (!start)
{

    
    if (response == "y")
    {
        Console.WriteLine("Inserisci la password");
        string stringToCheck = Console.ReadLine();
        bool getAccess = boolTeca.checkPassword(stringToCheck);
        if (getAccess)
        {
            start = true;
        }
        else
        {
            Console.WriteLine("sei della biblioteca?y-n");
            response = Console.ReadLine().ToLower();
        }
    }
    else if(response == "n")
    {
        start=true;
    }
    else
    {
        Console.WriteLine("risposta non valida");
        
    }
    

}

if(response == "y")
{
    Console.WriteLine("");
}









