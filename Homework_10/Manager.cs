namespace Homework_10
{

    class Manager : Worker
    {
        public int TeamSize;

        public Manager(string name, int age, double salary, int teamSize)
            : base(name, age, salary)
        {
            TeamSize = teamSize;
        }

        public override void Print()
        {
            Console.WriteLine($"Manager: {Name}, Age: {Age}, Salary: {Salary}, TeamSize: {TeamSize}");
        }
    }
}
