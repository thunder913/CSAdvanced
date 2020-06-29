using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    class Box<T>
    {
        public T item;

        public T Add(T currentItem)
        {
            this.item = currentItem;
            return item; 
        }

        public override string ToString()
        {
            return $"{item.GetType()}: {this.item}";
        }
    }
}
