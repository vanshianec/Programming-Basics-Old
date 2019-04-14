using System;
using System.Collections.Generic;
using System.Text;

namespace CustomArrayList
{
    class CustomArrayList
    {
        private object[] arr;

        private int count;

        public int Count
        {

        get { return count; }

        }

        private static readonly int INITIAL_CAPACITY = 4;

        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(object item)
        {
            Insert(count, item);
        }

        public void Insert(int index,object item)
        {
            if (index>count||index<0)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }
            object[] extendetArr = arr;
            if (count+1==arr.Length)
            {
                extendetArr = new object[arr.Length * 2];
            }
            Array.Copy(arr, extendetArr, index);
            count++;
            Array.Copy(arr, index, extendetArr, index + 1, count - index - 1);
            extendetArr[index] = item;
            arr = extendetArr;
        }
        public int IndexOf(object item)
        {
            for (int i=0; i<arr.Length;i++)
            {
                if (item==arr[i])
                {
                    return i;
                }
                
            }
            return -1;
        }

        public void Clear()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }
        
        public bool Contains(object item)
        {
            for (int i=0;i<arr.Length;i++)
            {
                if (item == arr[i])
                    return true;
            }
            return false;
        }

        public object this[int index]
        {
            get
            {
                if (index<0||index>=count)
                {
                    throw new ArgumentOutOfRangeException("" +
                        "Invalid index: " + index);
                }
                return arr[index];
            }
            set
            {
                if (index<0||index>=count)
                {
                    throw new ArgumentOutOfRangeException("" +
                        "Invalid index: " + index);
                }
                arr[index] = value;
            }
        }

        public object Remove(int index)
        {
            if (index>=count || index <0)
            {
                throw new ArgumentOutOfRangeException("" +
                    "Invalid index: " + index);
            }

            object item = arr[index];

            Array.Copy(arr, index + 1, arr, index, count - index + 1);
            arr[count - 1] = null;
            count--;
            return item;


        }

        public int Remove(object item)
        {
            int index = IndexOf(item);

            if(index==-1)
            {
                return index;
            }

            Array.Copy(arr, index + 1, arr,index, count - index + 1);
            count--;

            return index;


        }

        

    }
}
