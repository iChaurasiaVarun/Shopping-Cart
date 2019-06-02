using ShoppingCart.Models;
using ShoppingCartPricing.Provider.DiscountProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPricing.Provider.DiscountFactory
{
    /// <summary>
    /// Discount factory
    /// </summary>
    internal class DiscountFactory : DiscountsFactory
    {
        internal override IDiscounts Create(List<CartItem> cartItems) => new Discount(cartItems);
    }
}
