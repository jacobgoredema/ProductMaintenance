using ProductMaintenance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.Models
{
    public class Customer : IGenericPersistable<Customer>
    {
        public bool HasChanges
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Customer Read(string id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
