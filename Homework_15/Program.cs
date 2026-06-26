using Homework_15.Exceptions;
using Homework_15.Helpers;
using Homework_15.Models;
using Homework_15.Services;

namespace Homework_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Service that manages all student operations
            StudentService studentService = new StudentService();

            bool exit = false;

            // Main application loop
            while (!exit)
            {
                Console.WriteLine("\n===== STUDENT MANAGEMENT =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Find Student");
                Console.WriteLine("3. Update Score");
                Console.WriteLine("4. Display All Students");
                Console.WriteLine("5. Exit");

                int choice = InputHelper.ReadInt("Choose an option: ");

                try
                {
                    switch (choice)
                    {
                        // Add new student
                        case 1:
                            Student student = new Student();
                            string name = InputHelper.ReadString("Enter student name: ");
                            student.Name = name;
                            int score = InputHelper.ReadInt("Enter student score: ");
                            student.Score = score;


                            studentService.AddStudent(student);

                            Console.WriteLine("Student added successfully.");
                            break;

                        // Find student and display score
                        case 2:
                            name = InputHelper.ReadString("Enter student name: ");

                            Student st = studentService.FindStudent(name);

                            Console.WriteLine($"Score: {st.Score}");
                            break;

                        // Update existing student's score
                        case 3:
                            name = InputHelper.ReadString("Enter student name: ");
                            int newScore = InputHelper.ReadInt("Enter new score: ");

                            studentService.UpdateScore(name, newScore);

                            Console.WriteLine("Score updated successfully.");
                            break;

                        // Display all students
                        case 4:
                            studentService.DisplayStudents();
                            break;

                        // Exit application
                        case 5:
                            exit = true;
                            Console.WriteLine("Goodbye!");
                            break;

                        // Invalid menu option handling
                        default:
                            Console.WriteLine("Invalid menu option.");
                            break;
                    }
                }
                catch (DuplicateStudentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (StudentNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidScoreException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error occurred.");
                }
            }
        }
    }
}
