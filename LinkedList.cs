using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Node<T>
    {
        public T Data {  get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            this.Data = data;
        }
    }
    public class LinkedList<T>
    {
        private Node<T> First {  get; set; }
        private Node<T> Last { get; set; }
        private int Count;
        public void AddFirst(T Data)
        {
            if(First == null)
            {
                First = Last = new Node<T>(Data);
            }
            else
            {
                Node<T> curr = this.First;
                First = new Node<T>(Data);
                First.Next = curr;
            }
            Count++;
        }
        public void Add(T Data)
        {
            AddLast(Data);
        }
        public void AddLast(T Data)
        {
            if(Last == null)
            {
                First = Last = new Node<T>(Data);
            }
            else
            {
                Last.Next = new Node<T>(Data);
                Last = Last.Next;
            }
            Count++;
        }
        public Node<T> Find(T Data)
        {
            Node<T> curr = this.First;
            while (curr != null && !curr.Data.Equals(Data))
            {
                curr = curr.Next;
            }
            return curr;
        }
        public void AddAfter(T NewData,T ExistingData)
        {
            Node<T> curr = Find(ExistingData);
            Node<T> Next = curr.Next;
            curr.Next = new Node<T>(NewData);
            curr.Next.Next = Next;
        }
        public void RemoveFirst()
        {
            if(First == null)
            {
                return;
            }
            this.First = First.Next;
            Count--;
        }
        public void Remove(T Data)
        {
            if(First == null)
            {
                return ;
            }
            if(First.Data.Equals(Data))
            {
                this.RemoveFirst();
                return ;
            }
            Node<T> prev = this.First;
            Node<T> next = prev.Next;
            while (next != null && !next.Data.Equals(Data))
            {
                prev = next;
                next = next.Next;
            }
            if(next != null)
            {
                prev.Next = next.Next;
                Count--;
            }

        }
        public void Traverse()
        {
            Node<T> curr = First;
            while(curr != null)
            {
                Console.WriteLine(curr.Data);
                curr = curr.Next;
            }
        }
    }
}
