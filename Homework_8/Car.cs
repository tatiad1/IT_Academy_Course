namespace Homework_8
{
    internal class Car
    {
        private int id;
        private string brand;
        private string model;
        private int year;
        private decimal price;
        private string color;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    brand = value;
                }
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value;
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1886 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    color = value;
                }
            }
        }

        public Car(int id, string brand, string model, int year, decimal price, string color)
        {
            this.Id = id;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Color = color;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} | {Brand} {Model} | {Year} | {Price} | {Color}");
        }

        public string GetFullName()
        {
            return $"{Brand} - {Model}";
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Year;
        }

        public bool IsLuxury()
        {
            return Price >= 80000;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }

}
