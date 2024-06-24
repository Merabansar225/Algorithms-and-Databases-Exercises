namespace Ex1TaskC;
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. Remove customer");
            Console.WriteLine("3. Display total number of customers");
            Console.WriteLine("4. Display customer queue");
            Console.WriteLine("5. Reverse the order of the first k elements");
            Console.WriteLine("6. Exit");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    string name;
                    int age;
                    Console.Write("Enter customer name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter customer age: ");
                    age = int.Parse(Console.ReadLine());
                    queue.Enqueue(new Customer(name, age));
                    break;
                case 2:
                    Customer removedCustomer = queue.Dequeue();
                    if (removedCustomer != null)
                    {
                        Console.WriteLine($"Removed customer: {removedCustomer.GetName()} ({removedCustomer.GetAge()} years old)");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Total number of customers: {queue.Count()}");
                    break;
                case 4:
                    queue.Peek();
                    break;
                case 5:
                    Console.Write("Enter the value of k: ");
                    int k = int.Parse(Console.ReadLine());
                    queue.Reverse(k);
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}