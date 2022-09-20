// See https://aka.ms/new-console-template for more information
public class Dvd : Product
{
    string serialNumber;
    int totMinutes;
    public Dvd(string title, int year) : base(title, year)
    {
    }

    public string SerialNumber { get { return serialNumber; } set { serialNumber = value; } }

    public int Timers { get { return totMinutes; } set { totMinutes = value; } }
}


