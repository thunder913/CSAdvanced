using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Problem1
{
    class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> list { get; set; } = new List<T>();
        public int index { get; set; } = 0;

        public ListyIterator(List<T> input) 
        {
            this.list = input;
        }

        public ListyIterator() 
        {
        
        }

        public bool Move() 
        {
            if (this.HasNext())
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext() 
        {
            var newIndex = this.index + 1;
            if (newIndex < list.Count)
            {
                return true;
            }
            return false;
        }
        public string Print() 
        {
            if (this.list.Any() && this.list[index] != null)
            {
                return list[index].ToString();
            }
            return $"Invalid Operation!";
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
