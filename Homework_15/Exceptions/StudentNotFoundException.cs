namespace Homework_15.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string name)
            : base($"Student '{name}' was not found.")
        {
        }
    }
}