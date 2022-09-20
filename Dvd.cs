// See https://aka.ms/new-console-template for more information
public class Dvd : Product
{
    string serialNumber;
    int totMinutes;

    public Dvd(string serialNumber, int totMinutes, string title, int year, string sector, bool isAvailable, string shelf, string authorName, string authorSurname) 
        : base(title, year, sector, isAvailable, shelf, authorName, authorSurname)
    {

    }
}


