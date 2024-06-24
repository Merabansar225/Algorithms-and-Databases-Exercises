using System;
namespace Ex1Task2
{
    class Queue
    {
        private readonly int maxsize = 20;
        private string[] customers;
        private int head = 0;
        private int tail = 0;
        private int numItems;
        
        public Queue()
        {
            customers = new string[maxsize];
        }

        public void Enqueue(string custName)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full.");
                return;
            }

            numItems++;
            customers[tail] = custName;
            tail++;

            if (tail == maxsize)
            {
                tail = 0;
            }
        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return null;
            }

            string headItem;
            numItems--;
            headItem = customers[head];
            head++;

            if (head == maxsize)
            {
                head = 0;
            }

            return headItem;
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

        public string Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return null;
            }

            return customers[head];
        }

    }

}



// https://www.tutorialspoint.com/data_structures_algorithms/dsa_queue.htm - isFull + isEmpty
// https://www.geeksforgeeks.org/basic-operations-for-queue-in-data-structure/ - enqueue + dequeue