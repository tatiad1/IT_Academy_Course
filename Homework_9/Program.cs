using System;
namespace Homework_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[8];

            // Georgia (2)
            employees[0] = new Employee(
                "Tatia", "Dundua",
                new DateTime(2000, 5, 10),
                Gender.Female,
                Country.Georgia,
                new Contacts("+995555123456", "tatia@gmail.com", "123456789")
            );

            employees[1] = new Employee(
                "Davit", "Darjania",
                new DateTime(2001, 3, 15),
                Gender.Male,
                Country.Georgia,
                new Contacts("+995555987654", "daviti@gmail.com", "987654321")
            );

            // Germany (2)
            employees[2] = new Employee(
                "Anna", "Dartsimelia",
                new DateTime(1998, 7, 20),
                Gender.Female,
                Country.Germany,
                new Contacts("+49123456789", "anna@gmail.com", "111111111")
            );

            employees[3] = new Employee(
                "Luka", "Batilashvili",
                new DateTime(1997, 11, 5),
                Gender.Female,
                Country.Germany,
                new Contacts("+49111111111", "luka@gmail.com", "222222222")
            );

            // Italy (2)
            employees[4] = new Employee(
                "Esma", "Verulashvili",
                new DateTime(1996, 2, 12),
                Gender.Female,
                Country.Italy,
                new Contacts("+39123456789", "esma@gmail.com", "333333333")
            );

            employees[5] = new Employee(
                "Mariam", "Tabatadze",
                new DateTime(1995, 9, 25),
                Gender.Female,
                Country.Italy,
                new Contacts("+39111111111", "mari@gmail.com", "444444444")
            );

            // France (2)
            employees[6] = new Employee(
                "Tatia", "Topuria",
                new DateTime(1994, 1, 8),
                Gender.Female,
                Country.France,
                new Contacts("+33123456789", "tatia@gmail.com", "555555555")
            );

            employees[7] = new Employee(
                "Lizi", "Chxaidze",
                new DateTime(1993, 6, 30),
                Gender.Female,
                Country.France,
                new Contacts("+33111111111", "lizi@gmail.com", "666666666")
            );




            //PRINTING EMPLOYEES DETAILS
            Console.WriteLine("----------ALL EMPLOYEES----------\n");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine("----------------------");
            }

            

            //FILTERING 
            Employee.FilterByCountry(employees, Country.Georgia);
            Employee.FilterByCountry(employees, Country.Germany);
            Employee.FilterByCountry(employees, Country.Italy);
            Employee.FilterByCountry(employees, Country.France);
        }

    }
}

