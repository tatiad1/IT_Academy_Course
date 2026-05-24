using System.Diagnostics.Tracing;
using System.Text;

namespace Homework_6
{
    internal class Program
    {
        static uint GetLength(string message)
        {
            bool isValid = false;
            uint len = 1;

            while (true)
            {
                Console.Write(message);
                isValid = uint.TryParse(Console.ReadLine().Trim(), out len);

                if (isValid && len > 0)
                {
                    break;
                }

                Console.WriteLine("Input must be a number greater than 0. Try Again!\n");
            }

            return len;
        }

        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isValid = false;
                int num = 0;

                while (!isValid)
                {
                    Console.Write($"Enter N{i + 1}: ");
                    isValid = int.TryParse(Console.ReadLine(), out num);

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Input! Try Again!\n");
                    }
                }

                arr[i] = num;
            }
        }

        static void FillArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string word;
                while (true)
                {
                    Console.Write($"Enter N{i + 1}: ");
                    word = Console.ReadLine().Trim();

                    if (!string.IsNullOrEmpty(word))
                    {
                        break;
                    }

                    Console.WriteLine("Input cannot be empty!\n");
                }

                arr[i] = word;
            }

        }


        static void Main(string[] args)
        {

            #region Task_1
            //uint len = GetLength("Enter The Amount Of Students: ");

            //int[][] students = new int[len][];

            //bool isValid = false;

            //for (int i = 0; i < students.Length; i++)
            //{
            //    uint scoresAmount = GetLength($"Enter The Amount Of Scores For Student N{i + 1}:");
            //    students[i] = new int[scoresAmount];
            //    FillArray(students[i]);
            //    Console.WriteLine();
            //}

            //StringBuilder avgScores = new StringBuilder();

            //for (int i = 0; i < students.Length; i++)
            //{
            //    avgScores.Append($"Student N{i + 1}: ");
            //    int sum = 0;
            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        sum += students[i][j];
            //    }

            //    double avg = (double)sum / students[i].Length;
            //    avgScores.Append(avg.ToString("F1") + "\n");
            //}

            //Console.WriteLine(avgScores.ToString());
            #endregion


            #region Task_2
            //string[] arr = new string[10];

            //Random r = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sb.Append(r.Next(0, 10));
            //    }

            //    arr[i] = sb.ToString();
            //}

            ////The Codes
            ////foreach (string s in arr)
            ////{
            ////    Console.WriteLine(s);
            ////}

            //bool isCorrect = false;

            //while (!isCorrect)
            //{
            //    Console.Write("Enter Your Code: ");
            //    string code = Console.ReadLine().Trim();

            //    foreach (string item in arr)
            //    {
            //        if (code == item)
            //        {
            //            Console.WriteLine("Correct!");
            //            isCorrect = true;
            //            break;
            //        }
            //    }

            //    if (!isCorrect)
            //    {
            //        Console.WriteLine("Wrong! Try Again!\n");
            //    }
            //}
            #endregion


            #region Task_3
            //uint len = GetLength("Enter The Length Of The Numbers Array: ");

            //int[] numbers = new int[len];

            //FillArray(numbers);

            //int max = int.MinValue;
            //int min = int.MaxValue;

            //foreach (int num in numbers)
            //{
            //    if (max < num)
            //    {
            //        max = num;
            //    }

            //    if (min > num)
            //    {
            //        min = num;
            //    }
            //}

            //Console.WriteLine($"Max Value: {max}\nMin Value: {min}");
            #endregion


            #region Task_4
            //uint len = GetLength("Enter The Length Of String Array: ");

            //string[] arr = new string[len];

            //FillArray(arr);

            //foreach (string word in arr)
            //{
            //    Console.Write($"{word}: ");
            //    foreach (char c in word)
            //    {
            //        Console.Write($"{c} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Task_5
            //uint len = GetLength("Enter The Length Of Emails Array: ");

            //string[] emails = new string[len];

            //FillArray(emails);

            //bool isValid = false;
            //foreach (string email in emails)
            //{
            //    isValid = false;

            //    foreach (char e in email)
            //    {
            //        if (e == '@')
            //        {
            //            isValid = true;
            //            break;
            //        }
            //    }

            //    if (!isValid)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine(isValid ? "All Email is Valid" : "Not All Email Is Valid!");
            #endregion

        }
    }
}
