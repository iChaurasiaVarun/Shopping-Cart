using ShoppingCart.Models;
using ShoppingCartPricing.Provider.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPricing.Provider.DiscountFactory
{
    /// <summary>
    /// No discount factory
    /// </summary>
    internal class NoDiscountFactory : DiscountsFactory
    {
        internal override IDiscounts Create(List<CartItem> cartItems) => new NoDiscount(cartItems);
    }
}
