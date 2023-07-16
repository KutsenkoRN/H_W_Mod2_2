using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_2
{
    public class ShoppingCard
    {
        private int Count;
        private Product[] products;

        public ShoppingCard()
        {
            products = new Product[10];
            Count = 0;
        }
        public void AddProduct(Product product)
        {
            if (Count < 10)
            {
                products[Count] = product;
                Count++;
                Console.WriteLine("Your item has been added to your cart.");
            }
            else
            {
                Console.WriteLine("Shopping cart is full. Cannot add more products.");
            }
        }

        
        public void Order()
        {
            if (Count > 0)
            {
                Console.WriteLine("Your order:");
                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine($"{products[i].Id} :  {products[i].Name} - {products[i].Price}");
                }
            }
            else
            {
                Console.WriteLine("Cart is empty.");
            }

        }
    }
}
