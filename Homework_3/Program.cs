using System;
using System.Text;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //    }
            //    Console.WriteLine($"----------");
            //}

            #endregion

            #region Task_2
            //uint num = 0;
            //bool isValid = false;

            //while (!isValid)
            //{
            //    Console.Write("Enter Your Number: ");
            //    isValid = uint.TryParse(Console.ReadLine(), out num);

            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid Input! Try Again!\n");
            //    }
            //}


            //for (uint i = 0; i <= num; i++)
            //{
            //    for (uint j = 0; j < num - i; j++)
            //    {
            //        Console.Write(' ');
            //    }

            //    for (uint j = 0; j < i; j++) 
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}


            #endregion

            #region Task_3
            //uint num = 0;
            //bool isValid = false;
            //uint sum = 0;

            //while (!isValid)
            //{
            //    Console.Write("Enter Your Number: ");
            //    isValid = uint.TryParse(Console.ReadLine(), out num);

            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid Input! Try Again!\n");
            //    }
            //}

            //for (uint i = 2; i <= num; i += 2)
            //{
            //    sum += i;
            //}

            //Console.WriteLine($"\nThe Sum Of Even Numbers from 0 to {num}: {sum}");

            #endregion

            #region Task_4
            //Random r = new Random();
            //int num = r.Next(0, 11);

            //int inputNum;

            //while (true)
            //{
            //    Console.Write("Enter Number From 0 - 10: ");
            //    bool isValid = int.TryParse(Console.ReadLine(), out inputNum);

            //    if (!isValid || inputNum > 10 || inputNum < 0)
            //    {
            //        Console.WriteLine("Invalid Input! Try Again!\n");
            //        continue;
            //    }


            //    if (num == inputNum)
            //    {
            //        Console.WriteLine("It is Correct! Congratulations!");
            //        break;
            //    }

            //    Console.WriteLine("Incorrect! Try Again!\n");
            //}
            #endregion

        }
    }
}
