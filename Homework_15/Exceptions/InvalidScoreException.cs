namespace Homework_15.Exceptions
{
    public class InvalidScoreException : Exception
    {
        public InvalidScoreException()
            : base("Score must be between 0 and 100.")
        {
        }
    }
}