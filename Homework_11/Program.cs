namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 2, 4, 5, 3, 2, 6, 1 };
            Array arr = new Array(data);

            #region Task 1

            arr.ShowEven();
            arr.ShowOdd();

            #endregion

            #region Task 2

            Console.WriteLine("Distinct values: " + arr.CountDistinct());
            Console.WriteLine("Amount of element '6': " + arr.EqualToValue(6));

            #endregion

        }
    }
}
