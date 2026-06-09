namespace Homework_10
{
    using System;

    class Security : Worker
    {
        public string Shift;

        public Security(string name, int age, double salary, string shift)
            : base(name, age, salary)
        {
            Shift = shift;
        }

        public override void Print()
        {
            Console.WriteLine($"Security: {Name}, Age: {Age}, Salary: {Salary}, Shift: {Shift}");
        }
    }
}
