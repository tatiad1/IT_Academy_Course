namespace Homework_15.Helpers
{
    public static class InputHelper
    {
        // Reads and validates an integer input from the user.
        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Please enter a valid number.");
            }
        }

        // Reads a string input from the user.
        public static string ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}