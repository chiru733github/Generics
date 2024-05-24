using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
namespace Generics
{
    //Single Responsibility Principle
    //Taking bank example
    class Account
    {
        public string OwnerName { get; set; }
        public long AccountNumber { get; set; }
        public long PhoneNumber { get; set; }
        public int Balance { get; set; }
    }
    class Bank : Account
    {
        public void Deposit(Account account, int amount)
        {
            account.Balance += amount;
            CheckBalance(account);
        }
        public void WithDraw(Account account, int amount)
        {
            if (account.Balance < amount)
            {
                Console.WriteLine("Insuffient balance");
                return;
            }
            account.Balance -= amount;
            Console.WriteLine("you have Withdraw amount is {0}", amount);
            CheckBalance(account);
        }
        public void CheckBalance(Account account)
        {
            Console.WriteLine("Your account balance is {0}", account.Balance);
        }
    }
    //Open Closed Principle
    //taking example of area of different shape.
    //interface Ishape
    //{
    //    public double Area();
    //}
    //class Rectangle : Ishape
    //{
    //    public int length { get; set; }
    //    public int breadth { get; set; }

    //    public double Area()
    //    {
    //        double area = this.length * this.breadth;
    //        return area;
    //    }
    //}
    //class Circle : Ishape
    //{
    //    public int Radius { get; set; }
    //    public double Area()
    //    {
    //        return this.Radius * this.Radius * Math.PI;
    //    }
    //}
    //class Triangle : Ishape
    //{
    //    public double Base { get; set;}
    //    public double Height { get; set; }
    //    public double Area()
    //    {
    //        return 0.5 * this.Height * this.Base;
    //    }
    //}
    //Liskov Substitution Principle
    abstract class Shape
    {
        public abstract double GetArea();
    }


    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public override double GetArea()
        {
            return Width * Height;
        }
    }


    class Square : Rectangle
    {
        public double SQWidth
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public double SQHeight
        {
            get { return base.Height; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
    internal class Program
    {
        static void Print<T>(T val)
        {
            Console.WriteLine(val);
            Console.WriteLine(typeof(T));
        }

        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            for (int i = 0; i < queue.Size(); i++)
            {
                Console.WriteLine(queue.array[i]);
            }
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            Console.WriteLine("---------------");
            var shapes = new List<Shape> { new Rectangle { Width = 10, Height = 5 }
            , new Square { Width = 8,Height = 6} };
            foreach (var shape in shapes)
            {
                Console.WriteLine("Area: " + shape.GetArea());
            }

            Console.WriteLine("---------------");
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");
            ht.Remove("cs");
            ht.Add("C#", "C-sharp");
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
            IDictionaryEnumerator en = ht.GetEnumerator();
            while (en.MoveNext())
            {
                Console.WriteLine(en.Value);
            }
            
            Console.WriteLine("---------------");
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");
            sl.Add("c#", "C-Sharp");

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
            //Console.ReadKey();
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(1);
            ll.AddLast(2);
            ll.AddLast(3);
            ll.AddLast(4);
            ll.Add(6);
            ll.AddAfter(5, 4);
            ll.Traverse();
            Console.WriteLine("--------------");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("--------------");
            Tree tree = new Tree();
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(3);
            Console.WriteLine("PreOrder method of tree.");
            tree.PreOrder(tree.ReturnRoot());
            Console.WriteLine("\nInorder of tree.");
            tree.Inorder(tree.ReturnRoot());
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //int[] arr = new int[5];
            //for(int i=0;i<list.Count;i++)
            //{
            //    arr[i] = list[i];
            //    Console.WriteLine($"list element {i} is {list[i]}");
            //}
            //foreach (int i in list) Console.WriteLine(i);
            //Console.WriteLine($"Size of list is {list.Count}");
            //LinkedList<int> l = new LinkedList<int>();
            //Queue<int> q = new Queue<int>();
            //Stack<int> s = new Stack<int>();
            //ArrayList arrayList = new ArrayList();
            //q.Enqueue(1);
            //q.Enqueue(2);
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Peek());
            Print(4);
            //print(5l);
            
        }
    }
}
