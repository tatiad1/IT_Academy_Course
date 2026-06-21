using Homework_13.Helpers;

namespace Homework_13.Models
{
    internal abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be empty.");

                string trimmed = value.Trim();

                ValidationHelper.ValidateName(trimmed, "First name");

                _firstName = trimmed;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");

                string trimmed = value.Trim();

                ValidationHelper.ValidateName(trimmed, "Last name");

                _lastName = trimmed;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                ValidationHelper.ValidateAge(value);
                _age = value;
            }
        }

        protected Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        protected Person()
        {
        }
    }
}