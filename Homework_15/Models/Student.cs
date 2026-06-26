using Homework_15.Helpers;

namespace Homework_15.Models
{
    public class Student
    {
        private string _name;
        private int _score;

        // Encapsulated property for student name with validation
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // Check if name is empty or whitespace
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Student Name cannot be empty.");

                string trimmed = value.Trim();

                // Additional validation rules (length + letters only)
                ValidationHelper.ValidateName(trimmed, "Student Name");

                _name = trimmed;
            }
        }

        // Encapsulated property for score with validation
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                // Validate score range (0–100)
                ValidationHelper.ValidateScore(value);
                _score = value;
            }
        }

        // Constructor with parameters (recommended way to create Student)
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }

        // Parameterless constructor (optional, can be used if needed later)
        public Student()
        {
        }

        // String representation of Student object (useful for printing)
        public override string ToString()
        {
            return $"Student Name: {Name}\nStudent Score: {Score}";
        }
    }
}