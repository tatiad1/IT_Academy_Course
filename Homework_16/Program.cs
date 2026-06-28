using Homework_16.Services;

namespace Homework_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                5, 2, 8, 2, 10, 5, 1
            };

            Console.WriteLine("===== WHERE =====");
            var evenNumbers = Algorithms.Where(numbers, x => x % 2 == 0);

            foreach (var item in evenNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("===== ORDER BY =====");
            var sorted = Algorithms.OrderBy(numbers, x => x);

            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("===== FIRST =====");
            Console.WriteLine(Algorithms.First(numbers, x => x > 4));

            Console.WriteLine();

            Console.WriteLine("===== FIRST OR DEFAULT =====");
            Console.WriteLine(Algorithms.FirstOrDefault(numbers, x => x > 100));

            Console.WriteLine();

            Console.WriteLine("===== SINGLE =====");

            try
            {
                Console.WriteLine(Algorithms.Single(numbers, x => x == 10));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("===== SINGLE OR DEFAULT =====");

            try
            {
                Console.WriteLine(Algorithms.SingleOrDefault(numbers, x => x == 100));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("===== ANY =====");
            Console.WriteLine(Algorithms.Any(numbers, x => x > 8));

            Console.WriteLine();

            Console.WriteLine("===== ALL =====");
            Console.WriteLine(Algorithms.All(numbers, x => x > 0));

            Console.WriteLine();

            Console.WriteLine("===== COUNT =====");
            Console.WriteLine(Algorithms.Count(numbers, x => x == 5));

            Console.WriteLine();

            Console.WriteLine("===== DISTINCT =====");
            var unique = Algorithms.Distinct(numbers);

            foreach (var item in unique)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}