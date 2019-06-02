using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// to provide layer for discount validation
    /// </summary>
    interface IDiscountValidation
    {
        bool ValidateMinCartValue(double cartPrice);
        bool ValidateMinCartItem(int cartItem);
    }
}
