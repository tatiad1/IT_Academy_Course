using Homework_13.Exceptions;

namespace Homework_13.Helpers
{
    // Central validation helper for all domain rules
    public static class ValidationHelper
    {
        // Validates general name rules (used for FirstName / LastName)
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

        // Validates general age range (used for Person or general age fields)
        public static void ValidateAge(int value)
        {
            if (value < 0 || value > 120)
                throw new ArgumentException("Age must be between 0 and 120.");
        }

        // Validates student-specific age rule (business rule for Student entity)
        public static void ValidateStudentAge(int value)
        {
            if (value < 16 || value > 100)
                throw new InvalidStudentAgeException("Student age must be between 16 and 100.");
        }

        // Validates email structure (basic format check)
        public static void ValidateEmail(string email)
        {
            int atIndex = email.IndexOf('@');

            if (atIndex <= 0 || atIndex != email.LastIndexOf('@') || atIndex == email.Length - 1)
                throw new ArgumentException("Email must contain a valid '@' position.");

            string domain = email.Substring(atIndex + 1);

            if (!domain.Contains("."))
                throw new ArgumentException("Email domain is invalid.");

            if (domain.StartsWith(".") || domain.EndsWith("."))
                throw new ArgumentException("Email format is invalid.");
        }

        // Validates phone number format (supports +countrycode or digits)
        public static void ValidatePhone(string phone)
        {
            if (!(phone[0] == '+' || char.IsDigit(phone[0])))
                throw new ArgumentException("Phone must start with + or digit.");

            for (int i = 1; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone[i]))
                    throw new ArgumentException("Phone must contain only digits after first character.");
            }

            if (char.IsDigit(phone[0]) && phone.Length < 9)
                throw new ArgumentException("Phone number is too short.");

            if (phone[0] == '+' && phone.Length < 10)
                throw new ArgumentException("Phone number is too short.");
        }

        // Validates GPA range (academic performance rule 0 - 4)
        public static void ValidateGpa(double gpa)
        {
            if (gpa < 0 || gpa > 4)
                throw new InvalidGpaException();
        }
    }
}