using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// To handler discount relation operation
    /// </summary>
    interface IDiscountHandler
    {
        List<KeyValuePair<string, int>> GetDiscountsName();
        DiscountModel GetDiscountModel(string discountName);
    }
}
