using ProductMaintenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.ViewModels
{
    public class ProductList: List<Product>
    {
        // Modify the behaviour of the Add mothod of the List<Product class
        public new void Add(Product p) => base.Insert(0, p);
        
        // provide 2 additional methods
        public void Fill()
        {
            List<Product> products = ProductDb.GetProducts();
            foreach(Product product in products)
                base.Add(product);
        }

        public void Save() => ProductDb.SaveProducts(this);
    }
}
