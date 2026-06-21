using Homework_13.Exceptions;
using Homework_13.Models;

namespace Homework_13.Services
{
    // Service layer: contains all business logic for Student operations
    internal class StudentService
    {
        // Calculates average GPA of all students
        public static double GetAverageGpa(Student[] students)
        {
            double sum = 0;

            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].Gpa;
            }

            return sum / students.Length;
        }

        // Returns all students who have the highest GPA in the array
        public static Student[] GetTopStudents(Student[] students)
        {
            double maxGpa = students[0].Gpa;

            // Step 1: find maximum GPA
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].Gpa > maxGpa)
                {
                    maxGpa = students[i].Gpa;
                }
            }

            // Step 2: count how many students have max GPA
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Gpa == maxGpa)
                {
                    count++;
                }
            }

            // Step 3: create result array for top students
            Student[] result = new Student[count];

            int index = 0;

            // Step 4: fill result array
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Gpa == maxGpa)
                {
                    result[index++] = students[i];
                }
            }

            return result;
        }

        // Searches and prints students by last name (case-insensitive)
        public static void SearchByLastName(Student[] students, string lastName)
        {
            string search = lastName.Trim().ToLower();
            bool found = false;

            for (int i = 0; i < students.Length; i++)
            {
                string studentLastName = students[i].LastName.Trim().ToLower();

                if (studentLastName.Equals(search))
                {
                    Console.WriteLine($"\nSTUDENT '{search}' FOUND");
                    Console.WriteLine("=====================");
                    students[i].Print();
                    Console.WriteLine();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"\nSTUDENT '{search}' NOT FOUND\n");
            }
        }

        // Deletes a student by email (sets array slot to null)
        public static void DeleteStudent(Student[] students, string email)
        {
            string searchEmail = email.Trim().ToLower();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null &&
                    students[i].Email.ToLower() == searchEmail)
                {
                    students[i] = null;
                    Console.WriteLine("Student deleted.");
                    return;
                }
            }

            Console.WriteLine("Student not found!");
        }

        // Adds a new student using console input + validation + resize logic
        public static Student[] AddStudent(Student[] students)
        {
            try
            {
                Student student = new Student();
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine().Trim();
                student.FirstName = firstName;


                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine().Trim();
                student.LastName = lastName;

                Console.Write("Enter age: ");
                bool isValidAge = int.TryParse(Console.ReadLine().Trim(), out int age);

                if (isValidAge)
                {
                    student.Age = age;
                }
                else
                {
                    throw new FormatException("Age input is not valid.");
                }

                Console.Write("Enter email: ");
                string email = Console.ReadLine().Trim();
                student.Email = email;

                Console.Write("Enter phone: ");
                string phone = Console.ReadLine().Trim();
                student.Phone = phone;

                Console.Write("Enter GPA: ");
                bool isValidGpa = double.TryParse(Console.ReadLine().Trim(), out double gpa);
                if (isValidGpa)
                {
                    student.Gpa = gpa;
                }
                else
                {
                    throw new FormatException("Gpa Input is not given in correct format.");
                }

                Console.Write("Enter faculty (IT, Business, Design, Medicine): ");
                if (!Enum.TryParse(Console.ReadLine().Trim(), true, out Faculty faculty))
                {
                    throw new FormatException("Faculty input is invalid.");
                }

                student.Faculty = faculty;

                // Try to place student in existing empty slot
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == null)
                    {
                        students[i] = student;
                        Console.WriteLine("Student added successfully!");
                        return students;
                    }
                }

                // If array is full -> resize and add
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;

                Console.WriteLine("Student added after resize!");
            }
            catch (InvalidStudentAgeException ex)
            {
                Console.WriteLine($"Student addition failed. {ex.Message}");
            }
            catch (InvalidGpaException ex)
            {
                Console.WriteLine($"Student addition failed. {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Student addition failed. {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Student addition failed. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Student addition failed. {ex.Message}");
            }

            return students;
        }

    }
}