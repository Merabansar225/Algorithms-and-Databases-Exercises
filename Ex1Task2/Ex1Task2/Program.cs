namespace Ex1Task2;
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        int choice = 0;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Customer Queue Application");
            Console.WriteLine("1. Add Name");
            Console.WriteLine("2. Remove Name");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Display Queue Count");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Write("Enter customer name: ");
                    string name = Console.ReadLine();
                    queue.Enqueue(name);
                    Console.WriteLine("Name added to the queue.");
                    Console.ReadKey();
                    break;

                case 2:
                    string removedName = queue.Dequeue();
                    if (removedName != null)
                    {
                        Console.WriteLine($"Removed name: {removedName}");
                    }
                    Console.ReadKey();
                    break;

                case 3:
                    if (!queue.IsEmpty())
                    {
                        Console.WriteLine("Customer Queue:");
                        int itemCount = queue.Count();
                        for (int i = 1; i <= itemCount; i++)
                        {
                            Console.WriteLine($"{i}. {queue.Peek()}");
                            queue.Enqueue(queue.Dequeue());
                        }
                    }
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine($"Total names in queue: {queue.Count()}");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}