namespace Homework_13.Exceptions
{
    internal class InvalidGpaException : Exception
    {
        public InvalidGpaException()
            : base("GPA must be between 0 and 4.")
        {
        }

        public InvalidGpaException(string message)
            : base(message)
        {
        }
    }
}