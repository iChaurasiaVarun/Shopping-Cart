using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    /// <summary>
    /// To calculate cart price
    /// </summary>
    public class CalculateCartPrice : ICalculateCartPrice
    {
        DiscountFacade discountFacade = null;
        private ICart cart = null;
        private string discount = "";

        public CalculateCartPrice(ICart cart, string discount = "")
        {
            this.cart = cart;
            this.discount = discount;
            this.discountFacade = new DiscountFacade(this.cart.GetCartItems(), this.discount);
        }
        
        public double GetCartFinalPrice()
        {
            double cartPrice = 0;
            cart.GetCartItems().ForEach(item => cartPrice += (item.ItemPrice * item.ItemCount));
            return Math.Floor( cartPrice - (cartPrice * this.discountFacade.GetDiscount() / 100));
        }
    }
}
