using System.ComponentModel.DataAnnotations;

namespace Homework_5
{
    internal class Program
    {


        static int[] CreateArray()
        {
            bool isValid = false;
            uint len = 1;

            while (!isValid || len == 0)
            {
                Console.Write("Enter The Length Of Your Array: ");
                isValid = uint.TryParse(Console.ReadLine(), out len);

                if (!isValid || len == 0)
                {
                    Console.WriteLine("Input must be a number greater than 0. Try Again!\n");
                }

            }

            return new int[len];
        }

        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isValid = false;
                int num = 0;

                while (!isValid)
                {
                    Console.Write($"Enter Element N{i + 1} In Array 1: ");
                    isValid = int.TryParse(Console.ReadLine(), out num);

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid Input! Try Again!\n");
                    }
                }

                arr[i] = num;
            }
        }


        static int[] Merge(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                result[a.Length + i] = b[i];

            }

            return result;
        }



        static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = arr[i];
                int k = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        k = j;
                    }
                }

                arr[k] = arr[i];
                arr[i] = min;
            }
        }
        static void Main(string[] args)
        {
            #region Task_1
            //int[] arr1 = CreateArray();
            //FillArray(arr1);

            //int[] arr2 = CreateArray();
            //FillArray(arr2);

            //int[] resultArr = Merge(arr1, arr2);


            //Console.Write("\nArray Elements: ");
            //foreach (int item in resultArr)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region Task_2
            int[] arr = CreateArray();
            FillArray(arr);
            SortArray(arr);

            List<(int, int)> pairs = new List<(int, int)>();
            int target = 7;

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];

                if (sum == target)
                {
                    pairs.Add((arr[left], arr[right]));
                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;   
                }
                else
                {
                    right--;  
                }
            }

            Console.Write("\nPairs: ");
            foreach (var pair in pairs)
            {
                Console.Write($"[{pair.Item1}, {pair.Item2}] ");
            }

            #endregion

        }
    }
}
