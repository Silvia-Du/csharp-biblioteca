// See https://aka.ms/new-console-template for more information
public class Book : Product
{
    string isbn;
    int pageNumber;
    public Book(string isbn, int pageNumber, string title, int year, string sector, bool isAvailable, string shelf, string authorName, string authorSurname) 
        : base(title, year, sector, isAvailable, shelf, authorName, authorSurname)
    {

    }
}


