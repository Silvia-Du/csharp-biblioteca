// See https://aka.ms/new-console-template for more information

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

//FUNZIONE RIMUOVI OGGETTO


Biblioteca boolTeca = new Biblioteca("boolTeca");
boolTeca.books.Add(new Book("Moby Dick", 1851, "12345678"));
boolTeca.books.Add(new Book("Le parole sono fineste oppure muri", 1999, "12456789"));
Console.WriteLine(boolTeca.books);


boolTeca.dvds.Add(new Dvd("Big Fish", 2003, "12356"));
boolTeca.dvds.Add(new Dvd("Edward mani di forbici", 2003, "145236"));
Console.WriteLine(boolTeca.Dvds);



boolTeca.users.Add(new User("Ugo", "DeUghi", "ugo@gmail.com", "password1", 389789654));
boolTeca.users.Add(new User("Dudi", "DeDudi", "dudi@gmail.com", "password2", 389789656));
Console.WriteLine(boolTeca.User);



Console.WriteLine("Benvenuto, sei della biblioteca?y-n");
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


if (response == "n")
{
    Console.WriteLine("Cosa stai cercando?dvd - libri");
    response = Console.ReadLine().ToLower();
    string userString;
    Product r;
    if(response == "dvd")
    {
        Console.WriteLine("Scrivi 1 per ricerca titolo, 2 per ricerca codice");
        response = Console.ReadLine().ToLower();
        if(response == "1")
        {
            Console.WriteLine("Scrivi il titolo da cercare");
            userString = Console.ReadLine().ToLower();
            r = boolTeca.SetByTitle("Dvd", userString);
            Console.WriteLine($"Titolo:{r.Title}, anno di pubblicazione : {r.Year}");

        }
        else if(response == "2")
        {
            Console.WriteLine("Scrivi il codice da cercare");
            userString = Console.ReadLine().ToLower();
            r = boolTeca.SetByCode("Dvd", userString);
            Console.WriteLine($"Titolo:{r.Title}, anno di pubblicazione : {r.Year}");
        }
        else
        {
            Console.WriteLine("Risposta non valida");
        }

    }
    else if(response == "libri")
    {
        Console.WriteLine("Scrivi 1 per ricerca titolo, 2 per ricerca codice");
        response = Console.ReadLine().ToLower();
        if (response == "1")
        {
            Console.WriteLine("Scrivi il titolo da cercare");
            userString = Console.ReadLine().ToLower();
            r = boolTeca.SetByTitle("libri", userString);
            Console.WriteLine($"Titolo:{r.Title}, anno di pubblicazione : {r.Year}");

        }
        else if (response == "2")
        {
            Console.WriteLine("Scrivi il codice da cercare");
            userString = Console.ReadLine().ToLower();
            r = boolTeca.SetByCode("libri", userString);
            Console.WriteLine($"Titolo:{r.Title}, anno di pubblicazione : {r.Year}");
            setLoan(r);
        }
        else
        {
            Console.WriteLine("Risposta non valida");
        }
    }
    else
    {
        Console.WriteLine("risposta non valida");
    }
}

void setLoan(Product response)
{
    string userString;
    string userName;
    string userSurame;

    if (response.Title != "non trovato")
    {
        Console.WriteLine("Vuoi noleggiare?[1] vuoi restituire?[2]");
        userString = Console.ReadLine().ToLower();
        if (userString == "1")
        {
            Console.WriteLine("Sei un'utente registrato? [y / n]");
            userString = Console.ReadLine().ToLower();
            if(userString == "y")
            {
                Console.WriteLine("Inserisci Il tuo nome");
                userName = Console.ReadLine().ToLower();
                Console.WriteLine("Inserisci Il tuo cognome");
                userSurame = Console.ReadLine().ToLower();
                bool isUser = boolTeca.GetCheckUser(userName, userSurame);
                if (isUser)
                {

                    boolTeca.SetLoan( userName, userSurame, response);
                }

            }
        }

    }
}









