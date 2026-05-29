namespace Homework_7
{
    internal class Product
    {
        public Product()
        {
            reviews = new string[0];
        }

        public Product(int id, string name, string description, decimal price, int quantity, string brand, string category, decimal rating, bool isAvailable, decimal discountPercent)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
            this.Brand = brand;
            this.Category = category;
            this.Rating = rating;
            this.IsAvailable = isAvailable;
            this.DiscountPercent = discountPercent;
            reviews = new string[0];
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Rating { get; set; }
        public bool IsAvailable { get; set; }
        public decimal DiscountPercent { get; set; }

        private string[] reviews;
        public string[] Reviews
        {
            get { return reviews; }
        }

        public void WriteReview(string review)
        {
            int newLen = reviews.Length + 1;
            Array.Resize(ref reviews, newLen);
            reviews[newLen - 1] = review;
            Console.WriteLine($"Review \"{review}\" Added!");
        }

        public void DisplayReviews()
        {
            Console.WriteLine("Reviews:");
            Console.WriteLine("------------------");
            foreach (var review in Reviews)
            {
                Console.WriteLine(review);
            }
            Console.WriteLine("------------------");
        }

        public decimal GetDiscountedPrice()
        {
            decimal discountAmount = Price * (DiscountPercent / 100);
            return Price - discountAmount;
        }

        public void DisplayInfo()
        {
            decimal total = GetDiscountedPrice() * Quantity;
            Console.WriteLine($"ID: {Id}\nName: {Name}\nDescription: {Description}\nBrand: {Brand}\nQuantity: {Quantity}\nTotal: {total}");
            DisplayReviews();
        }
    }
}
