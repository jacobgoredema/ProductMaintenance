using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance.Models
{
    public class CustomList<T>:IEnumerable<T>
    {
        private List<T> list = new List<T>();

        // an Add Method that keeps the list sorted
        public void Add(T item)
        {
            if (list.Count==0)
            {
                list.Add(item);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    T currentItem = list[i];
                    T nextItem = null;
                    if (i<list.Count-1)
                    {
                        nextItem = list[i + 1];
                    }

                    int currentCompare = currentItem.CompareTo(item);
                    if (nextItem==null)
                    {
                        list.Insert(i, item); //insert before current item
                        break;
                    }
                }
            }
        }

        // a readonly indexer
        public T this[int i]=>list[i];

        // a read-only property
        public int Count => list.Count;

        // the ToString method
        public override string ToString()
        {
            string listString = "";
            for (int i = 0; i < list.Count; i++)
            {
                listString += list[i].ToString() + "\n";
            }

            return listString;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
