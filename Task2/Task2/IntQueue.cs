using System;
namespace Task2
{
	public class IntQueue
	{
        private readonly int maxsize = 20;
        private string[] customers;
        private int head = 0;
        private int tail = 0;
      

        public IntQueue()
		{
            customers = new string[maxsize];
		}
        public void Enqueue(string custName)
        {
            
            customers[tail] = custName;
            tail++;

            if (tail == maxsize)  //this code allows the queue to loop once it reaches the end of queue
            {
                tail = 0;
            }
        }


        public string Dequeue()
        {
            string headItem = customers[head];
            head++;

            if (head == maxsize) //check wrap around
            {
                head = 0;
            }

            return headItem;

        }
        
        public string Peek()
        {
            return customers[head - 1];
        }

        /*
        public bool IsEmpty()
        {
            return //insert code
        }
 
        public bool IsFull()
        {
            return // insert code
        }

        */

        public int totalNames()
        {
            //Console.WriteLine("Total number of Names in the queue are " + IntQueue.Count);
            if (tail >= head)
            {
                return tail - head;
            }
            else
            {
                return maxsize - head + tail;
            }
        }
    }
}

