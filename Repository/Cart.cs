using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    /// <summary>
    /// To handle cart related operation
    /// </summary>
    public class Cart : ICart
    {
        private List<CartItem> CartItems = new List<CartItem>();

        public List<CartItem> GetCartItems()
        {
            return this.CartItems;
        }

        public void AddItem(CartItem item)
        {
            this.CartItems.Add(item);
        }

        public void RemoveItem(string itemTitle)
        {
            this.CartItems.RemoveAt(this.CartItems.FindIndex(e => e.ItemTitle == itemTitle));
        }

    }
}
