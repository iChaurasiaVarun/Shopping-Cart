using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Provider
{
    /// <summary>
    /// to provide interface for discount
    /// </summary>
    abstract class Discounts : IDiscounts
    {
        double cartPrice = 0;
        protected IDiscountHandler discountHandler = null;
        public Discounts(List<CartItem> cartItems)
        {
            cartItems.ForEach(item => this.cartPrice += (item.ItemPrice * item.ItemCount));
            this.discountHandler = new DiscountHandler();
        }
        public virtual double GetDiscount(string discount = "")
        {
            return 0;
        }
    }
}
