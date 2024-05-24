using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Queue<T>
    {
        public T[] array;
        private int Count;
        public void Enqueue(T item)
        {
            Array.Resize(ref array, Count+1);
            array[Count++] = item;
        }
        public bool Contain(T item)
        {
            if (Count == 0) { return false; }
            foreach(T val  in array)
            {
                if(val.Equals(item)) return true;
            }
            return false;
        }
        public void Dequeue()
        {
            for(int i = 0; i < Count-1; i++)
            {
                array[i] = array[i+1];
            }
            array[--Count] = default(T);
        }
        public T Peek()
        {
            return array[0];
        }
        public int Size() { return Count; }
    }
}
