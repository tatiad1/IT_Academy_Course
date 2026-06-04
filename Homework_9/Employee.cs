using Homework_9;

internal class Employee
{
    private string _name;
    private string _surname;
    private DateTime _dateOfBirth;
    private Gender _gender;
    private Country _country;
    private Contacts _contacts;

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Name cannot be NULL or empty!");
                return;
            }
            _name = value.Trim();
        }
    }
    public string Surname
    {
        get { return _surname; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Surname cannot be NULL or empty!");
                return;
            }
            _surname = value.Trim();
        }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set
        {
            if (value > DateTime.Today)
            {
                Console.WriteLine("Birth Date cannot be in the future!");
                return;
            }

            _dateOfBirth = value;
        }
    }
    public Gender Gender { get; set; }
    public Country Country { get; set; }
    public Contacts Contacts { get; set; }

    public Employee(string name, string surname, DateTime dateOfBirth, Gender gender, Country country, Contacts contacts)
    {
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        Country = country;
        Contacts = contacts;
    }


    public int GetAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;

        if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
        {
            age--;
        }

        return age;
    }


    public static void FilterByCountry(Employee[] employees, Country country)
    {
        Console.WriteLine($"\n----------{country}----------");
        foreach (Employee emp in employees)
        {
            if (emp.Country == country)
            {
                Console.WriteLine($"{emp.Name} | {emp.Surname}");
            }
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{Name} - {Surname} - {GetAge()} - {DateOfBirth:dd/MM/yyyy} - {Country}\n" +
            $"{Contacts.MobileNumber} - {Contacts.Email}";
    }
}