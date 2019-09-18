using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.Models
{
    public class Product:IComparable<Product>
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public Product()
        {
        }

        public Product(string code, string description, decimal price)
        {
            Code = code;
            Description = description;
            Price = price;
        }

        public virtual string GetDisplayText(string sep) =>
            Code + sep + Description + sep + Price.ToString("c");

        public object Clone()
        {
            Product p = new Product();
            p.Code = this.Code;
            p.Description = this.Description;
            p.Price = this.Price;

            return p;
        }

        public int CompareTo(Product other) => this.Code.CompareTo(other.Code);
    }
}
