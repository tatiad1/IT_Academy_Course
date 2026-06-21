namespace Homework_13.Helpers
{
    internal class Logger : IDisposable
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }

        public void Dispose()
        {
            Console.WriteLine("Logger disposed.");
        }
    }
}