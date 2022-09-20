// See https://aka.ms/new-console-template for more information
public class Loan
{
    DateTime startDate;
    int duration;
    string name;
    string surname;
    string product;

    public Loan( int duration, string name, string surname, string product)
    {
        this.startDate = new DateTime();
        this.duration = duration;
        this.name = name;
        this.surname = surname;
        this.product = product;
    }

    public string Name { get { return name; } }

    public string Surname { get { return surname; } }

    public DateTime StartDate { get { return startDate; } }

    public int Duration { get { return duration; } }

    public string Product { get { return product; } }


}


