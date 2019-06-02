using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// To provide layer for creation of Concrete Discounts Factory
    /// </summary>
    public abstract class DiscountsFactory
    {
        internal abstract IDiscounts Create(List<CartItem> cartItems);
    }
}
