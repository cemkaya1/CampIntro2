using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indirim oranina gore tuketicinin odeyecegi fiyati hesapla
            double LastPrice(double price, double discount)
            {
                double result = price - (price * discount);
                return result;
            }

            // Windows laptop'lar icin ozellikleri tanimla
            Product product1 = new Product();
            product1.ProductCategory = "Window Laptop";
            product1.Brand = "Lenovo";
            product1.Model = "IdeaPad L340";
            product1.Description = "Intel Core i5 9300H 8GB 256GB SSD GTX 1050";
            product1.Price = 6498.99;
            product1.DiscountRate = 0.12;
            product1.FinallPrice = LastPrice(product1.Price, product1.DiscountRate);

            // Apple laptop'lar icin ozellikleri tanimla
            Product product2 = new Product();
            product2.ProductCategory = "Apple Laptop";
            product2.Brand = "Apple";
            product2.Model = "Macbook Air";
            product2.Description = "M1 Çip 8GB 256GB macOS 13 QHD Taşınabilir Bilgisayar Uzay Grisi";
            product2.Price = 11100;
            product2.DiscountRate = 0.02;
            product2.FinallPrice = LastPrice(product2.Price, product2.DiscountRate);

            // Product sinifinda yer alan her bir nesneyi products isimli diziye aktar
            Product[] products = new Product[] { product1, product2 };

            // Dizideki elemanlari ekrana 3 farkli dongu yontemi ile yazdir
            Console.WriteLine("####### With for each loop #######");
            // for each dongusu ile her bir proporty'i ekrana yazdirma
            foreach (Product item in products)
            {
                Console.WriteLine(item.Brand + " " + item.Model + " " + item.Description + "\nPrice: " + item.Price + " TL, Discount Rate : " + item.DiscountRate.ToString("P") + "\nPrice in the basket : " + item.FinallPrice.ToString("0,0.00") + " TL");
                Console.WriteLine();
            }

            Console.WriteLine("####### With for loop #######");
            //for dongusu ile her bir property'i ekrana yazdirma
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Brand + " " + products[i].Model + " " + products[i].Description + "\nPrice: " + products[i].Price + " TL, Discount Rate : " + products[i].DiscountRate.ToString("P") + "\nPrice in the basket : " + products[i].FinallPrice.ToString("0,0.00") + " TL");
                Console.WriteLine();
            }

            Console.WriteLine("####### With while loop #######");
            //while dongusu ile her bir property'i ekrana yazdirma
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].Brand + " " + products[j].Model + " " + products[j].Description + "\nPrice: " + products[j].Price + " TL, Discount Rate : " + products[j].DiscountRate.ToString("P") + "\nPrice in the basket : " + products[j].FinallPrice.ToString("0,0.00") + " TL");
                Console.WriteLine();
                j++;
            }
        }
    }
    class Product
    {
        public string ProductCategory { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double DiscountRate { get; set; }
        public double FinallPrice { get; set; }
    }

}
