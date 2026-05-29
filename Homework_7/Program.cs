namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Empty Constructor
            //Product p = new Product();
            //p1.Id = 1;
            //p1.Name = "Keyboard";
            //p1.Description = "Mechanical keyboard";
            //p1.Price = 120.50m;
            //p1.Quantity = 5;
            //p1.Brand = "Logitech";
            //p1.Category = "Electronics";
            //p1.Rating = 4.7m;
            //p1.IsAvailable = true;
            //p1.DiscountPercent = 15m;
            #endregion

            #region Constructor
            Product p = new Product(1, "Keyboard", "Mechanical keyboard", 120.50m, 5, "Logitech", "Electronics", 4.7m, true, 15m);

            p.WriteReview("Nice Looking");
            p.DisplayInfo();

            #endregion
        }
    }
}
