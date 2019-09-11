using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.Models
{
    public class Book:Product
    {
        private string author;

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public Book(string code, string description,string author, decimal price) 
            :base (code,description,price)
        {
            Author = author;
        }

        public override string GetDisplayText(string sep) =>
            base.GetDisplayText(sep) + "( " + Author + ")";
    }
}
