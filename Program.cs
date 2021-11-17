using System;

namespace StackAssignment
{
    class Program
    {
        public class Node
        {
            public static readonly object UC6;
            public int data;
            public int prev_node;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }
        static void Main(string[] args)
        {
            StackFunctions obj = new StackFunctions();
            obj.Push(70);
            obj.Push(30);
            obj.Push(56);
            obj.Display();
            //obj.Peek();
            //obj.Pop();
            obj.isEmpty();
            obj.Display();
        }
    }
}
