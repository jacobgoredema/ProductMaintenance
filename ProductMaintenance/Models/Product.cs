using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.Models
{
    public class Product
    {
        //private string author;
        private string code;
        private string description;
        private decimal price;

        public Product()
        {

        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        
        public Product(string code, string description, decimal price)
        {
            Code = code;
            Description = description;
            Price = price;
        }

        public virtual string GetDisplayText(string sep) =>
            Code + sep + Description + sep + Price.ToString("c");    
    }
}
