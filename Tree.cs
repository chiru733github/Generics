using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class NodeTree
    {
        public int Data;
        public NodeTree Left;
        public NodeTree Right;
        public NodeTree(int value)
        {
            this.Data = value;
        }
    }
    class Tree
    {
        public NodeTree Root;
        public NodeTree ReturnRoot()
        {
            return Root;
        }
        public void Insert(int val)
        {
            if(Root == null)
            {
                Root = new NodeTree(val);
            }
            else
            {
                NodeTree Curr = Root;
                NodeTree Parent;
                while(true)
                {
                    Parent = Curr;
                    if(val < Curr.Data)
                    {
                        Curr = Curr.Left;
                        if(Curr == null)
                        {
                            Parent.Left = new NodeTree(val);
                            return;
                        }
                    }
                    else
                    {
                        Curr = Curr.Right;
                        if(Curr == null)
                        {
                            Parent.Right = new NodeTree(val);
                            return;
                        }
                    }
                }
            }
        }
        public void PreOrder(NodeTree Root)
        {
            if(Root != null)
            {
                Console.Write(Root.Data+" ");
                PreOrder(Root.Left);
                PreOrder(Root.Right);
            }
        }
        public void Inorder(NodeTree Root)
        {
            if(Root != null)
            {
                Inorder(Root.Left);
                Console.Write(Root.Data+" ");
                Inorder(Root.Right);
            }
        }
    }
}
