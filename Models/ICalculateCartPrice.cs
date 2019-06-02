using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// To provide interface for calculating Cart price
    /// </summary>
    public interface ICalculateCartPrice
    {
        double GetCartFinalPrice();
    }
}
