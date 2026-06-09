namespace Homework_10
{
    using System;

    class President : Worker
    {
        public string Country;

        public President(string name, int age, double salary, string country)
            : base(name, age, salary)
        {
            Country = country;
        }

        public override void Print()
        {
            Console.WriteLine($"President: {Name}, Age: {Age}, Salary: {Salary}, Country: {Country}");
        }
    }
}
