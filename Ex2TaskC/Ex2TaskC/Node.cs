using System;
namespace Ex2TaskC
{
    public class Node
    {
        private string data;
        public Node Left, Right;

        public Node(string item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public string Data
        {
            set { data = value; }
            get { return data; }
        }
    }

}

