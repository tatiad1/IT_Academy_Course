
namespace Homework_10
{
    class Engineer : Worker
    {
        public string Specialization;

        public Engineer(string name, int age, double salary, string specialization)
            : base(name, age, salary)
        {
            Specialization = specialization;
        }

        public override void Print()
        {
            Console.WriteLine($"Engineer: {Name}, Age: {Age}, Salary: {Salary}, Specialization: {Specialization}");
        }
    }
}
