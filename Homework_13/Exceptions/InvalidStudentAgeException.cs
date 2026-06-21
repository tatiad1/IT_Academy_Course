namespace Homework_13.Exceptions
{
    internal class InvalidStudentAgeException : Exception
    {
        public InvalidStudentAgeException()
            : base("Student age must be between 16 and 100.")
        {
        }

        public InvalidStudentAgeException(string message)
            : base(message)
        {
        }
    }
}