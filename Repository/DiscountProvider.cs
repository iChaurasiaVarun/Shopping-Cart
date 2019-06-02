using ShoppingCart.Models;
using ShoppingCartPricing.Provider.DiscountFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    /// <summary>
    /// Abstract layer to provide object of concrete factory depends on discount
    /// </summary>
    public class DiscountProvider
    {
        public DiscountsFactory GetDiscountFactory(bool isDiscount)
        {
            if (isDiscount)
                return new DiscountFactory();
            else
                return new NoDiscountFactory();
        }
    }
}
