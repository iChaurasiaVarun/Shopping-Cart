using ShoppingCart.Models;
using ShoppingCart.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPricing.Provider.DiscountProvider
{
    /// <summary>
    /// Discount provider
    /// </summary>
    internal class Discount : ShoppingCart.Provider.Discounts
    {
        internal Discount(List<CartItem> cartItems): base(cartItems)
        {

        }
        public override double GetDiscount(string discount)
        {
            return base.discountHandler.GetDiscountModel(discount).Discount;
        }
    }
}
