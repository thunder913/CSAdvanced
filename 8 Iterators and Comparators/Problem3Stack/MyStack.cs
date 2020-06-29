using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Problem3Stack
{
    class MyStack<T> : IEnumerable<T>
    {
        public List<T> stack { get; set; }

        public MyStack() 
        {
            this.stack = new List<T>();
        }

        public void Push(List<T> toInput) 
        {
            foreach (var item in toInput)
            {
                stack.Add(item);
            }
        }
        public T Pop()
        {
            if (stack.Any())
            {
                T item = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return item;
            }
            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
