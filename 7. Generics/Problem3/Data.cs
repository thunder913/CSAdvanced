using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    class Data<T>
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

        public void SwapIndexes<T>(List<T> list, int indexOne, int indexTwo)
        {
            var newItem = list[indexOne];
            list[indexOne] = list[indexTwo];
            list[indexTwo] = newItem;
        }
    }
}
