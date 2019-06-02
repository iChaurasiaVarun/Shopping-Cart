using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    /// <summary>
    /// To handler cart related operation
    /// </summary>
    public interface ICart
    {
        List<CartItem> GetCartItems();
        void AddItem(CartItem item);
        void RemoveItem(string itemTitle);
    }
}
