using ShoppingCart.Models;
using ShoppingCart.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    /// <summary>
    /// To handle discount related validations
    /// </summary>
    class DiscountValidator : IDiscountValidation
    {
        private DiscountValidationModel validation = null;
        public DiscountValidator(string discount)
        {
            this.validation = new DiscountHandler().GetDiscountModel(discount).Validation;
        }

        public bool ValidateMinCartValue(double cartPrice)
        {
            return cartPrice >= validation.MinCartValue;
        }

        public bool ValidateMinCartItem(int cartItem)
        {
            return cartItem >= validation.MinCartItem;
        }
    }
}
