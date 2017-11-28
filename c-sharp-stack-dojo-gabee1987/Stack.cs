using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_stack_dojo_gabee1987
{
    class Stack<T>
    {
        private T[] items = null;
        private int index = 0;

        public Stack(int size)
        {
            items = new T[size];
        }

        public void Push(T item)
        {
            if (index >= items.Length) { throw new StackOverflowException(); }
            items[index] = item;
            index++;
        }

        public T Pop()
        {
            if (index <= 0) { throw new InvalidOperationException(); }
            T removedItem = items[--index];
            items[index] = default(T);
            return removedItem;

        }

        public T Peek()
        {
            if (index <= 0) { throw new InvalidOperationException(); }
            return items[items.Length - 1];
        }

        public override string ToString()
        {
            if (index<= 0) { throw new InvalidOperationException(); }
            string outPut = "";
            for (int i = 0; i < items.Count(); i++)
            {
                outPut += items[i] + ", ";
            }
            return outPut;
        }

    }
}
