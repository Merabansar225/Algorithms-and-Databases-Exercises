using System;
namespace Ex1TaskC
{
    class Stack
    {
        private int maxsize;
        private int top = 0;
        private Customer[] array;

        public Stack(int maxSize)
        {
            maxsize = maxSize;
            array = new Customer[maxSize];
        }

        public void Push(Customer value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full.");
                return;
            }

            array[top] = value;
            top++;
        }

        public Customer Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return null;
            }

            top--;
            return array[top];
        }

        public Customer Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return null;
            }

            return array[top - 1];
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == maxsize;
        }
    }
}
