// See https://aka.ms/new-console-template for more information
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


