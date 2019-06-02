using ShoppingCart.Models;
using ShoppingCart.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPricing.Provider.Discounts
{
    /// <summary>
    /// No discount provider
    /// </summary>
    internal class NoDiscount: ShoppingCart.Provider.Discounts
    {
        internal NoDiscount(List<CartItem> cartItems): base(cartItems)
        {

        }
    }
}
