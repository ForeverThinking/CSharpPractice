using System;

namespace CSharpPractice.Data_Structures.Stack
{
    public class Stack
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data) {
                this.data = data;
            }
        }

        public Node top = null;

        void Push(Node toAdd)
        {
            toAdd.next = top;
            top = toAdd;
        }

        void Pop()
        {
            top = top.next;
        }

        int Peek()
        {
            return top.data;
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(new Node(1));
            stack.Push(new Node(2));
            stack.Push(new Node(3));

            Console.WriteLine(stack.Peek());

            stack.Pop();

            Console.WriteLine(stack.Peek());
        }
    }
}