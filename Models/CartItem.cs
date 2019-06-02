using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// To store cart item
    /// </summary>
    public class CartItem
    {
        public string ItemTitle;
        public double ItemPrice;
        public int ItemCount;

        public CartItem(string itemTitle, double itemPrice, int itemCount)
        {
            this.ItemTitle = itemTitle;
            this.ItemPrice = itemPrice;
            this.ItemCount = itemCount;
        }
    }
}
