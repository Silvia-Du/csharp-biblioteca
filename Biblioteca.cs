// See https://aka.ms/new-console-template for more information


using System.ComponentModel;

public class Biblioteca
{
    string name;
    string password = "passwordB";
    List<Book> books;
    List<Dvd> dvd;
    List<Loan> loans;
    List<User> users;


    public Biblioteca(string name)
    {
        this.name = name;
        books = new List<Book>();
        dvd = new List<Dvd>();
        loans = new List<Loan>();
        users = new List<User>();
    }

    public bool checkPassword(string password)
    {
        return this.password.Equals(password);
    }

    public List<Book> Books { get; }
    public List<Dvd> Dvd { get; }

    public List<Loan> Loan { get; }

    public List<User> User { get; }


    public void searchTitle(string type , string title)
    {
        
    }

    public void searchCode(string type, string code)
    {

    }





}


