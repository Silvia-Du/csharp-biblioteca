// See https://aka.ms/new-console-template for more information
public class User
{
    string name;
    string surname;
    string eMail;
    string password;
    int telephone;

    //costruttore
    public User(string name, string surname, string eMail, string password, int telephone)
    {
        this.name = name;
        this.surname = surname;
        this.eMail = eMail;
        this.password = password;
        this.telephone = telephone;
    }

    public string Name { get { return name; } }

    public string Surname { get { return surname; } }

    public string EMail { get { return eMail; } }

    public int Tlephone { get { return telephone; } }

    public string Password { get { return password; } set { password = value; } }
}


