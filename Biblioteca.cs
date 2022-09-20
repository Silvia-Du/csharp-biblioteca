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
    }

    public bool checkPassword(string password)
    {
        return this.password.Equals(password);
    }

    

}


