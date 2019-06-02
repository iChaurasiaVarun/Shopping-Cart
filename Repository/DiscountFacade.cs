using ShoppingCart.Models;
using ShoppingCart.Utils;
using ShoppingCartPricing.Provider.DiscountFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    /// <summary>
    /// Facade layer for handling discount validations and Fetching discount on the basis of applied discount
    /// </summary>
    public class DiscountFacade
    {
        
        DiscountProvider discountProvider = null;
        private List<CartItem> cartItems = null;
        private string discount;


        public DiscountFacade(List<CartItem> cartItems, string discount = "")
        {
            this.cartItems = cartItems;
            this.discount = discount;
            
        }

        public double GetDiscount()
        {
            double discount = 0;
            try
            {
                this.ValidateDiscount();
                return this.GetDiscountPercent();

            }
            catch (Exception ex)
            {
                throw;
            }
            return discount;
        }

        private double GetDiscountPercent()
        {
            this.discountProvider = new DiscountProvider();
            return this.discountProvider.GetDiscountFactory(!String.IsNullOrWhiteSpace(this.discount)).Create(this.cartItems).GetDiscount(this.discount);
        }

        private bool ValidateDiscount()
        {
            if (String.IsNullOrWhiteSpace(this.discount))
                return true;
            IDiscountValidation discountValidation = new DiscountValidator(discount);
            double cartPrice = 0;
            this.cartItems.ForEach(item => cartPrice += (item.ItemCount * item.ItemPrice));
            int cartItem = 0;
            this.cartItems.ForEach(item => cartItem += item.ItemCount);

            if (!discountValidation.ValidateMinCartItem(cartItem))
            {
                throw new ExceptionHandler().GetMinItemException();
            }

            if(!discountValidation.ValidateMinCartValue(cartPrice))
            {
                throw new ExceptionHandler().GetMinCartValueException();
            }

            return true;
        }

    }
}
