using Homework_15.Exceptions;

namespace Homework_15.Helpers
{
    public static class ValidationHelper
    {
        // Validates that a name is between 2–30 characters and contains only letters.
        public static void ValidateName(string value, string fieldName)
        {
            if (value.Length < 2 || value.Length > 30)
                throw new ArgumentException($"{fieldName} must be between 2 and 30 characters.");

            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    throw new ArgumentException($"{fieldName} must contain only letters.");
            }
        }

        // Validates that score is within allowed range (0–100).
        public static void ValidateScore(int score)
        {
            if (score < 0 || score > 100)
                throw new InvalidScoreException();
        }

    }
}