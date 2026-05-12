namespace lecture_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_1

            //while (true)
            //{
            //    Console.Write("Enter Your Age: ");
            //    bool isValid = int.TryParse(Console.ReadLine(), out int age);

            //    if (isValid)
            //    {
            //        Console.WriteLine(age >= 18 ? "Valid Age!" : "Invalid Age!");
            //        break;
            //    }

            //    Console.WriteLine("Invalid Input! Try Again!\n");
            //}

            #endregion

            #region Task_2

            //int i = 1;
            //int maxIndex = 0;
            //int max = int.MinValue;
            //while (i <= 3)
            //{
            //    Console.Write($"Enter Number {i}: ");
            //    bool isNum = int.TryParse(Console.ReadLine(), out int newNum);

            //    if (isNum)
            //    {
            //        if(newNum > max)
            //        {
            //            max = newNum;
            //            maxIndex = i;
            //        }

            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Input! Try Again!\n");
            //    }
            //}

            //Console.WriteLine($"\nMax is N{maxIndex}: {max}");

            #endregion


            #region Task_3

            int sum = 0;
            int i = 1;

            while (i <= 2)
            {
                Console.Write($"Enter Number {i}: ");
                bool isValid = int.TryParse(Console.ReadLine(), out int num);

                if (!isValid)
                {
                    Console.WriteLine("Invalid Input! Try Again!\n");
                    continue;
                }

                if (i == 2 && sum == num)
                {
                    sum += num;
                    sum *= 3;
                }
                else
                {
                    sum += num;
                }

                i++;
            }

            Console.WriteLine($"The Result: {sum}");
            #endregion
        }
    }
}

