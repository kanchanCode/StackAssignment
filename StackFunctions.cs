using System;
using System.Collections.Generic;
using System.Text;
using static StackAssignment.Program;

namespace StackAssignment
{
   
    class StackFunctions
    {
        public Node top; 
        

        public StackFunctions()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("pushed element is "+value);
        }

        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }

        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(this.top.data+" is the data in the top of the stack");
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Cannot Delete!! Stack is empty ");
                return;
            }
           // Console.WriteLine(this.top.data+"");
            this.top = this.top.next;
            
           
        }
        internal void isEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();

            }
        }
    }
}
