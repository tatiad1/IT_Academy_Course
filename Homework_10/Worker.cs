namespace Homework_10
{
    abstract class Worker
    {
        protected string Name;
        protected int Age;
        protected double Salary;

        public Worker(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public abstract void Print();
    }
}
