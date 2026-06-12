using System.Text;

namespace Homework_11
{
    internal class Array : IOutput2, ICalc2
    {
        private int[] numbers;

        public Array(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool foundBefore = false;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        foundBefore = true;
                        break;
                    }
                }

                if (!foundBefore)
                {
                    count++;
                }
            }

            return count;

        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;

            foreach (int num in numbers)
            {
                if (num == valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        public void ShowEven()
        {
            Console.Write("Even numbers: ");
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Odd numbers: ");
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
