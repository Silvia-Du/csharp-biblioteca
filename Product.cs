// See https://aka.ms/new-console-template for more information
public class Product
{
    string title;
    int year;
    string sector;
    bool isAvailable = true;
    string shelf;
    string authorName;
    string authorSurname;

    public Product(string title, int year)
    {
        this.title = title;
        this.year = year;
    
    }

    public string Title{ get { return title; } }

    public int Year{ get { return year; } set { year = value; } }

    public string Sector{ get { return sector; } set { sector = value; } }

    public string Shelf { get { return shelf; } set { shelf = value; } }

    public string AuthorName{ get { return authorName; } set { authorName = value; } }

    public string AuthorSurname { get { return authorSurname; } set { authorSurname = value; } }



}


