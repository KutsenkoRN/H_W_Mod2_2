namespace H_W_Mod2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[15]
        {
            new Product { Id = 1, Name = "Product 1", Price = 10 },
            new Product { Id = 2, Name = "Product 2", Price = 12 },
            new Product { Id = 3, Name = "Product 3", Price = 20 },
            new Product { Id = 4, Name = "Product 4", Price = 16 },
            new Product { Id = 5, Name = "Product 5", Price = 84 },
            new Product { Id = 6, Name = "Product 6", Price = 22 },
            new Product { Id = 7, Name = "Product 7", Price = 198},
            new Product { Id = 8, Name = "Product 8", Price = 76 },
            new Product { Id = 9, Name = "Product 9", Price = 19 },
            new Product { Id = 10, Name = "Product 10", Price = 95 },
            new Product { Id = 11, Name = "Product 11", Price = 12 },
            new Product { Id = 12, Name = "Product 12", Price = 13 },
            new Product { Id = 13, Name = "Product 13", Price = 35 },
            new Product { Id = 14, Name = "Product 14", Price = 16 },
            new Product { Id = 15, Name = "Product 15", Price = 86 }
        };

            var card = new ShoppingCard();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                card.AddProduct(products[rand.Next(0, products.Length)]);
            }

            card.Order();
            Console.ReadLine();
         
        }
    }
}