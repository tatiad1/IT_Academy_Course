namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\user\Desktop\IT_Academy_Course\IT_Academy_Course\Homework_8\CarsData.txt");

            Car[] cars = new Car[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                bool isValidYear = int.TryParse(data[2], out int year);
                bool isValidPrice = decimal.TryParse(data[3], out decimal price);

                if (data.Length == 5 && isValidYear && isValidPrice)
                {
                    cars[i] = new Car(
                        i + 1,
                        data[0],
                        data[1],
                        year,
                        price,
                        data[4]
                    );
                }
            }
            Console.WriteLine("All Cars:");

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].DisplayInfo();
            }

            Console.WriteLine("\nExample Methods:");
            Console.WriteLine();

            Console.WriteLine($"Full Name: {cars[0].GetFullName()}");
            Console.WriteLine($"Age: {cars[0].GetAge()}");
            Console.WriteLine($"Luxury: {cars[0].IsLuxury()}");

            cars[0].ChangeColor("Black");

            Console.WriteLine("\nAfter Color Change:");
            cars[0].DisplayInfo();
        }
    }
}
