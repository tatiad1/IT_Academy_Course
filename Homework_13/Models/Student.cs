using Homework_13.Helpers;
using Homework_13.Interfaces;
using Homework_13.Models;

namespace Homework_13
{
    // Student class inherits Person and implements comparison + printing behavior
    internal class Student : Person, IComparable<Student>, IPrintable
    {
        private string _email;
        private string _phone;
        private double _gpa;
        private Faculty _faculty;

        // Overrides Person Age with additional student-specific validation rule (>=16)
        public new int Age
        {
            get => base.Age;
            set
            {
                ValidationHelper.ValidateStudentAge(value);
                base.Age = value;
            }
        }

        // Email property with validation (format + null/empty check)
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email cannot be empty.");

                string trimmed = value.Trim();

                ValidationHelper.ValidateEmail(trimmed);

                _email = trimmed;
            }
        }

        // Phone property with validation for format rules
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Phone cannot be empty.");

                string trimmed = value.Trim();

                ValidationHelper.ValidatePhone(trimmed);

                _phone = trimmed;
            }
        }

        // GPA property with academic range validation
        public double Gpa
        {
            get { return _gpa; }
            set
            {
                ValidationHelper.ValidateGpa(value);
                _gpa = value;
            }
        }

        // Simple enum property (no validation needed here)
        public Faculty Faculty
        {
            get { return _faculty; }
            set
            {
                _faculty = value;
            }
        }

        // Empty constructor (used when building object step-by-step)
        public Student()
        {
        }

        // Full constructor enforcing complete valid object creation
        public Student(string firstName, string lastName, int age,
                       string email, string phone, double gpa, Faculty faculty)
            : base(firstName, lastName, age)
        {
            Age = age; 
            Email = email;
            Phone = phone;
            Gpa = gpa;
            Faculty = faculty;
        }

        // Operator overload: compares students by GPA
        public static bool operator >(Student s1, Student s2)
        {
            return s1.Gpa > s2.Gpa;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.Gpa < s2.Gpa;
        }

        // Default sorting logic (by Age descending)
        public int CompareTo(Student other)
        {
            if (other == null) return 1;

            return other.Age.CompareTo(this.Age);
        }

        // Prints student info 
        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}, Age: {Age}, GPA: {Gpa}, Faculty: {Faculty}");
        }

        // Helper method to print whole array of students safely
        public static void PrintStudents(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    students[i].Print();
                }
            }
        }
    }
}