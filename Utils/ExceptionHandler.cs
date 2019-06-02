using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Utils
{
    /// <summary>
    /// Exception Handler to throw generic error
    /// </summary>
    public class ExceptionHandler
    {
        public Exception GetMinCartValueException()
        {
            throw new Exception("MinCartValueError");
        }

        public Exception GetMinItemException()
        {
            throw new Exception("MinCartItemError");
        }

        public Exception GetInvalidDiscountException()
        {
            throw new Exception("InvalidDiscount");
        }
    }
}
