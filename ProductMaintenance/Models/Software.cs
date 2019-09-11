using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.Models
{
    public class Software:Product
    {
        private string version;

        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }

        public Software(string code,string description,string version, decimal price):base(code,description,price)
        {
            Version = version;
        }

        public override string GetDisplayText(string sep) =>
            base.GetDisplayText(sep) + ", Version " + Version;        
    }
}
