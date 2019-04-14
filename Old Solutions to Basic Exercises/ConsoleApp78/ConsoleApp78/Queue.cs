using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Queue <T>
    {
        private T []array;
        private int count;
        private int front = 0;
        
        public int Count
        {
            get { return count; }
        }
        public Queue()
        {
            array = new T[4096];
            count = 0;
        }
        public Queue(int capacity)
        {
            array = new T[capacity];
            count = 0;
        }
        
        public void Enqueue(T item)
        {
            if (count >= array.Length)
            {
                throw new ArgumentOutOfRangeException("The queue is full");
            }
            else
            {
                array[count] = item;
                count++;
            }


        }
        public T Peek()
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("The queue is empty");
            }
            return array[front];
            
        }
        public T Dequeue()
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("The queue is empty");
            }
            T item = array[front];
            array[front] = default;
            front++;
            return item;
            

        }
        public T[] ToArray()
        {
            return array;
        }









    }
}
