using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Product
    {
        private string code;
        private string dedcription;
        private decimal price;

        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public string Code { get; set; }
        public string Description { get; internal set; }
        public decimal Price { get; set; }

        internal object GetDisplayText(string v)
        {
            throw new NotImplementedException();
        }
    }
}
