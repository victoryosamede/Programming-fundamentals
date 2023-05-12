using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_16
{
    public class MyArrayList<T>
    {
        private T[] array;
        private int count;
        private const int initialLength = 8;
        
        public int Count
        {
            get { return this.count; }
        }
        public MyArrayList()
        {
            this.array = new T[initialLength];
            this.count = 0;
        }
        
        public int Add(T item)
        {
            GrowIfArrayIsFull();
            this.array[this.count++] = item;
            this.count++;
            return this.count;

        }
        public void Insert(int index, T item)
        {
            GrowIfArrayIsFull();
            this.array[this.count] = item;
            this.count++;
        }
        public void Clear()
        {
            this.count = 0;
            this.array = new T[initialLength];

        }
        public bool Contains(T item)
        {
            bool contains = false;
            foreach (T items in this.array) 
            {
                if (item.Equals(items))
                {
                    contains = true;
                    break;
                }
               
            }
            return contains;
        }
        public void Remove(T item)
        {
             
        }
        public void Reverse()
        {
            for(int i = this.count -1; i >= 0; i--)
            {
                T[] reversedArray = new T[this.count];
                reversedArray[this.count - i - 1] = this.array[i];
                Console.WriteLine(reversedArray);
            }
        }
        public void AddRange()
        {

        }
        private void GrowIfArrayIsFull()
        {
            if(this.count == this.array.Length)
            {
                T[] newArray = new T[this.count];
                Array.Copy(this.array, newArray, this.count);
                this.array = newArray;
            }
            Equals(this);
        }
    }
}
