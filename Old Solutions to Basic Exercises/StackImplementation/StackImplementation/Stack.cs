using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class Stack<T>
    {
        private T[] stack;
        private const int DEFAULT_CAPACITY = 1000;
        private int count;

        public int Count { get; }
       
        
        public Stack()
        {
            stack = new T[DEFAULT_CAPACITY];
            count = 0;
            
        }
        public Stack(int capacity)
        {
            stack = new T[capacity];
            count = 0;
        }

        public void Push(T item)
        {
            if(count == stack.Length)
            {
                throw new ArgumentOutOfRangeException("Stack is full");
            }
            stack[count] = item;
            count++;

        }

        public T Peak()
        {
            if(count == 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty");
            }
            return stack[count-1];
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new ArgumentOutOfRangeException("Stack is empty");
            }
            T item = stack[count-1];
            count--;
            return item;
        }

        public bool Contains(T item)
        {
            for(int i=0; i<count; i++)
            {
                if (stack[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }




    }
}

