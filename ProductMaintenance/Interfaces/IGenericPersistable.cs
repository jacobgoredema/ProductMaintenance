using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.Interfaces
{
    interface IGenericPersistable<T>
    {
        T Read(string id);
        bool Save(T obj);
        bool HasChanges
        {
            get;
            set;
        }
    }
}
