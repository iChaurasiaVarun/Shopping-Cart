using Newtonsoft.Json;
using ShoppingCart.Models;
using ShoppingCart.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Provider
{
    /// <summary>
    /// To handle discount related operation
    /// </summary>
    internal class DiscountHandler : IDiscountHandler
    {
        FileReader fileReader = null;
        private static string discountFilePath = "Discounts.json";
        protected List<DiscountModel> discounts = null;
        public DiscountHandler()
        {
            this.fileReader = new FileReader();
            this.GetDiscountModels();
        }

        private Dictionary<int, DiscountModel> GetDiscounts()
        {
            return discounts.ToDictionary(e => e.DiscountId, x => x);
        }

        public List<KeyValuePair<string, int>> GetDiscountsName()
        {
            return discounts.ConvertAll(d => new KeyValuePair<string, int>(d.DiscountName, d.DiscountId));
        }

        public DiscountModel GetDiscountModel(string discountName)
        {
            try
            {
                return this.GetDiscounts().Where(e => e.Key == GetDiscountsName().Find(x => x.Key == discountName).Value).Select(m => m.Value).First();
            }
            catch (Exception)
            {
                throw new ExceptionHandler().GetInvalidDiscountException();
            }
            
        }

        private void GetDiscountModels()
        {
            this.discounts = JsonConvert.DeserializeObject<List<DiscountModel>>(fileReader.GetFileContent(discountFilePath));
        }
    }
}
