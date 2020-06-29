using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    class Froggy<T> : IEnumerable<T>
    {
        public List<T> list = new List<T>();

        public Froggy(List<T> list) 
        {
            this.list = list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i+=2)
            {
                    yield return list[i];
            }
            var count = list.Count-1;
            if (count%2==0)
            {
                count -= 1;
            }
            for (int i = count; i >= 0; i-=2)
            {
                if (i%2!=0)
                {
                    yield return list[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
