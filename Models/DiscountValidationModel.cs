using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// To store discount validation data
    /// </summary>
    public class DiscountValidationModel
    {
        public double MinCartValue { get; set; }
        public int MinCartItem { get; set; }
    }
}
