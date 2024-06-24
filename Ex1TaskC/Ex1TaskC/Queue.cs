using System;
namespace Ex1TaskC
{
    class Queue
    {
        private readonly int maxsize = 10;
        private Customer[] customers;
        private int head = 0;
        private int tail = 0;
        private int numItems;

        public Queue()
        {
            customers = new Customer[maxsize];
        }

        public void Enqueue(Customer customer)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full.");
                return;
            }

            numItems++;
            customers[tail] = customer;
            tail++;

            if (tail == maxsize)
            {
                tail = 0;
            }
        }

        public Customer Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return null;
            }

            numItems--;
            Customer headCustomer = customers[head];
            head++;

            if (head == maxsize)
            {
                head = 0;
            }

            return headCustomer;
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }

        public int Count()
        {
            return numItems;
        }

        public Customer Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return null;
            }

            return customers[head];
        }

        // use array + for loop instead!
        public void Reverse(int k)
        {
            if (k > numItems)
            {
                Console.WriteLine("k is greater than the number of items in the queue.");
                return;
            }

            Stack stack = new Stack(maxsize);
            Queue tempQueue = new Queue();

            // condition for k items
            for (int i = 0; i < k; i++)
            {
                stack.Push(Dequeue());
            }

            while (!stack.IsEmpty())
            {
                Enqueue(stack.Pop());
            }

            // condition for non k items
            int remainingNonkItems;
            remainingNonkItems = numItems - k;
            for (int i = 0; i < remainingNonkItems; i++)
            {
                tempQueue.Enqueue(Dequeue());
            }

            while (!tempQueue.IsEmpty())
            {
                Enqueue(tempQueue.Dequeue());
            }
        }
    }
}