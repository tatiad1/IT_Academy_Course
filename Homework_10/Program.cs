namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument[] instruments =
                 {
            new Violin(),
            new Ukulele(),
            new Trombone(),
            new Cello()
            };

            foreach (MusicalInstrument instrument in instruments)
            {
                instrument.Show();
                instrument.Sound();
                instrument.Desc();
                instrument.History();

                Console.WriteLine("----------------------------------");
            }



            Worker[] workers =
                {
            new President("Giorgi", 45, 5000, "Georgia"),
            new Security("Lasha", 30, 1200, "Night"),
            new Manager("Nino", 35, 3000, 10),
            new Engineer("Davit", 28, 2500, "Software")
            };

            foreach (Worker w in workers)
            {
                w.Print();
            }
        }
    }
}
