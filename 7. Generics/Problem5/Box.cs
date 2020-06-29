using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem5
{
    class Box<T>
         where T : IComparable<T>
    {
        public T item;
        public void Add(T currentItem)
        {
            this.item = currentItem;
        }

        public bool compare(string itemInList, string itemToCheck) 
        {
            if (itemToCheck.Sum(x=>x) < itemInList.Sum(x=>x))
            {
                return true;
            }
            return false;
        }

    }
}
