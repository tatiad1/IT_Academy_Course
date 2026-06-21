using Homework_13.Helpers;
using Homework_13.Models;
using Homework_13.Services;

namespace Homework_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Logger logger = new Logger())
            {
                logger.Log("Start");

                Student[] students =
                {
                new Student("Tatia", "Dundua", 20, "tatia@gmail.com", "+995555111111", 4.0, Faculty.IT),
                new Student("Davit", "Darjania", 22, "davit@gmail.com", "+995555111112", 3.9, Faculty.Business),
                new Student("Nino", "Beridze", 19, "nino@gmail.com", "+995555111113", 3.8, Faculty.Design),
                new Student("Giorgi", "Kapanadze", 21, "giorgi@gmail.com", "+995555111114", 3.7, Faculty.Medicine),
                new Student("Luka", "Gelashvili", 23, "luka@gmail.com", "+995555111115", 4.0, Faculty.IT),
                new Student("Ana", "Mchedlishvili", 18, "ana@gmail.com", "+995555111116", 3.6, Faculty.Business),
                new Student("Saba", "Japaridze", 20, "saba@gmail.com", "+995555111117", 3.5, Faculty.Design),
                new Student("Mariam", "Kiknadze", 22, "mariam@gmail.com", "+995555111118", 3.9, Faculty.Medicine),
                new Student("Irakli", "Tsiklauri", 24, "irakli@gmail.com", "+995555111119", 3.4, Faculty.IT),
                new Student("Elene", "Maisuradze", 19, "elene@gmail.com", "+995555111120", 3.8, Faculty.Business)
                };

                bool isRunning = true;

                while (isRunning)
                {
                    Console.WriteLine("\n===== STUDENT MANAGEMENT =====");
                    Console.WriteLine("1. Show All Students");
                    Console.WriteLine("2. Find Top Students");
                    Console.WriteLine("3. Calculate Average GPA");
                    Console.WriteLine("4. Search Student By Last Name");
                    Console.WriteLine("5. Sort Students By Age");
                    Console.WriteLine("6. Add Student");
                    Console.WriteLine("7. Delete Student");
                    Console.WriteLine("0. Exit");

                    Console.Write("Choose option: ");
                    string choice = Console.ReadLine().Trim();

                    switch (choice)
                    {
                        case "1":
                            Student.PrintStudents(students);
                            break;

                        case "2":
                            Student[] topStudents = StudentService.GetTopStudents(students);

                            Console.WriteLine("\nTOP STUDENTS");
                            Console.WriteLine("=============");

                            foreach (Student student in topStudents)
                            {
                                student.Print();
                            }
                            break;

                        case "3":
                            double avg = StudentService.GetAverageGpa(students);
                            Console.WriteLine("\n\nAVERAGE GPA");
                            Console.WriteLine("=============");
                            Console.WriteLine(avg);
                            break;

                        case "4":
                            Console.WriteLine("\n\nSEARCH STUDENT ...");
                            Console.WriteLine("=================");

                            Console.Write("Enter last name: ");
                            string lastName_input = Console.ReadLine().Trim();

                            StudentService.SearchByLastName(students, lastName_input);
                            break;

                        case "5":
                            Console.WriteLine("SORTED BY AGE IN DESCENDING ORDER");
                            Console.WriteLine("=================================");
                            Array.Sort(students);
                            Student.PrintStudents(students);
                            break;

                        case "6":
                            students = StudentService.AddStudent(students);
                            break;

                        case "7":
                            Console.Write("Enter email: ");
                            string email = Console.ReadLine().Trim();

                            StudentService.DeleteStudent(students, email);
                            break;

                        case "0":
                            isRunning = false;
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Try Again!");
                            break;
                    }
                }
            }
        }
    }
}

