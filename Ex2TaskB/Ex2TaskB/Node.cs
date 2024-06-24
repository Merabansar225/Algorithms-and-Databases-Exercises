using System;
namespace Ex2TaskA
{
    public class Node
    {
        private int data;
        public Node Left, Right;

        public Node(int item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public int Data
        {
            set { data = value; }
            get { return data; }
        }
    }
}

