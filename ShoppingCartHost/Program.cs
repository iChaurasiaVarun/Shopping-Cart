using ShoppingCart.Models;
using ShoppingCart.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartHost
{
    /// <summary>
    /// Start Application for calculating the cart price
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter each CartItems in new line.");
            Console.WriteLine("e.g. ItemQuantity, ItemPrice");
            Console.WriteLine("e.g. 1, 100");
            int itemCount = 1;
            char input = 'm';
            ICart cart = new Cart();
            do
            {
                try
                {
                    Console.WriteLine("Enter {0} item details", itemCount);
                    string[] itemDetail = Console.ReadLine().Split(',');
                    cart.AddItem(new CartItem(1 + "", Convert.ToDouble(itemDetail[1]), Convert.ToInt32(itemDetail[0])));
                    itemCount += 1;
                    Console.WriteLine("Item Added to cart successfully. ");
                    Console.WriteLine("Enter m for more items and c checkout : ");
                    input = Convert.ToChar(Console.ReadLine());

                } catch (Exception ex)
                {
                    Console.WriteLine("Enter item details in correct format");
                }

            } while (input != 'c');

            Console.WriteLine("Available Offers - ");
            Console.WriteLine("Buy 2 Get 1 ( T&C - Min cart value is 200, and Min Item is 3)");
            Console.WriteLine("30% Off ( T&C - Min cart value is 500, and Min Item is 1)");
            Console.WriteLine("Buy 1 Get 1 ( T&C - Min cart value is 200, and Min Item is 2)");
            Console.WriteLine("Buy 2 Get 2 ( T&C - Min cart value is 200, and Min Item is 4)");
            Console.WriteLine("Enter offers (case sensitive)");
            string discount = Console.ReadLine();
            ICalculateCartPrice calculateCartPrice = new CalculateCartPrice(cart, discount);

            try
            {
                Console.WriteLine("Your cart price is {0}", calculateCartPrice.GetCartFinalPrice());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid discount applied.");
                Console.WriteLine("More Info - {0}", ex.Message);
            }

            Console.Read();
        }
    }
}
