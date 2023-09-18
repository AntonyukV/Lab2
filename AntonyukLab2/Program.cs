using System;

class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double usdAmount)
    {
        return usdAmount * usd;
    }

    public double ConvertFromEUR(double eurAmount)
    {
        return eurAmount * eur;
    }

    public double ConvertFromPLN(double plnAmount)
    {
        return plnAmount * pln;
    }
}

class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void SetPosition(string position)
    {
        this.position = position;
    }

    public void SetExperience(int experience)
    {
        this.experience = experience;
    }

    public double CalculateSalary()
    {
        return 0.0;
    }

    public double CalculateTax()
    {
        return 0.0;
    }
}

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        registrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Логін: " + login);
        Console.WriteLine("Iм'я: " + firstName);
        Console.WriteLine("Прiзвище: " + lastName);
        Console.WriteLine("Вiк: " + age);
        Console.WriteLine("Дата заповнення анкети: " + registrationDate);
    }
}

class Program
{
    static void Main()
    {
        Address address = new Address();
        address.Index = "02221";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Закревського";
        address.House = "39";
        address.Apartment = "15";

        Console.WriteLine("Поштова адреса:");
        Console.WriteLine("Iндекс: " + address.Index);
        Console.WriteLine("Країна: " + address.Country);
        Console.WriteLine("Мiсто: " + address.City);
        Console.WriteLine("Вулиця: " + address.Street);
        Console.WriteLine("Будинок: " + address.House);
        Console.WriteLine("Квартира: " + address.Apartment);

        Converter converter = new Converter(27.5, 33.0, 7.2);
        double amountInUAH = 1000.0;
        double amountInUSD = converter.ConvertToUSD(amountInUAH);
        double amountInEUR = converter.ConvertToEUR(amountInUAH);
        double amountInPLN = converter.ConvertToPLN(amountInUAH);

        Console.WriteLine("1000 гривень в еквiвалентi:");
        Console.WriteLine("У USD: " + amountInUSD);
        Console.WriteLine("У EUR: " + amountInEUR);
        Console.WriteLine("У PLN: " + amountInPLN);

        Employee employee = new Employee("Антонюк", "Валерiй");
        employee.SetPosition("Спецiалiст з iнформацiйної безпеки");
        employee.SetExperience(5);
        double salary = employee.CalculateSalary();
        double tax = employee.CalculateTax();

        Console.WriteLine("Спiвробiтник:");
        Console.WriteLine("Прiзвище: " + employee.LastName);
        Console.WriteLine("Iм'я: " + employee.FirstName);
        Console.WriteLine("Посада: " + employee.Position);
        Console.WriteLine("Оклад: " + salary);
        Console.WriteLine("Податковий збiр: " + tax);

        User user = new User("V.AntonyukFIT2-13", "Валерiй", "Антонюк", 18);
        user.DisplayUserInfo();

        Console.ReadLine();
    }
}
