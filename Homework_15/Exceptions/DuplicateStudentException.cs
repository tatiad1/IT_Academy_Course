namespace Homework_15.Exceptions
{
    public class DuplicateStudentException : Exception
    {
        public DuplicateStudentException(string name)
            : base($"Student '{name}' already exists.")
        {
        }
    }
}