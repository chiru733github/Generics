using System;


namespace Generics
{
    class Stack<T>
    {
        private T[] array;
        private int Count {  get; set; }
        public Stack()
        {
            array = new T[0];
        }
        public void Push(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[Count++] = item;
        }
        public T Peek() { return array[Count - 1]; }
        public T Pop()
        {
            return array[--Count];
        }
        public bool IsEmpty() { return Count == 0; }
        public int Size() { return Count; }

    }
}
