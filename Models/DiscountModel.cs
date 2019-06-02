using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// To store discount information
    /// </summary>
    public class DiscountModel
    {
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public double Discount { get; set; }

        public DiscountValidationModel Validation { get; set; }
    }


}
