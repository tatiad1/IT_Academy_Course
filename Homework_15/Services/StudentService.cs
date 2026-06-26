using Homework_15.Exceptions;
using Homework_15.Models;

namespace Homework_15.Services
{
    internal class StudentService
    {
        // Main storage for student objects
        private List<Student> students = new();

        // Fast lookup storage for scores by student name
        private Dictionary<string, int> studentScores = new();

        // Adds a new student to the system
        public void AddStudent(Student student)
        {
            // Prevent duplicate student names
            if (studentScores.ContainsKey(student.Name))
                throw new DuplicateStudentException(student.Name);

            students.Add(student);
            studentScores.Add(student.Name, student.Score);
        }


        // Finds and returns a student by name
        public Student FindStudent(string name)
        {
            foreach (Student student in students)
            {
                if (student.Name == name)
                {
                    return student;
                }
            }

            // If not found, throw custom exception
            throw new StudentNotFoundException(name);
        }

        // Updates an existing student's score
        public void UpdateScore(string name, int newScore)
        {
            Student student = FindStudent(name);

            student.Score = newScore;
            studentScores[name] = newScore;
        }

        // Displays all students in a formatted way
        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine("------------------");
                Console.WriteLine(student);
                Console.WriteLine("------------------");
            }
        }
    }
}
