namespace Ex2TaskA;
class Program
{
    static void Main(string[] args)
    {
        BinTree tree = new BinTree();

        tree.InsertItem(4);
        tree.InsertItem(3);
        tree.InsertItem(1);
        tree.InsertItem(7);
        tree.InsertItem(5);
        tree.InsertItem(9);

        Console.Write("InOrder: ");
        tree.InOrder();
        Console.WriteLine();

        // testing 2 values using the contains method 
        int testValue1 = 5;
        int testValue2 = 10;

        if (tree.Contains(testValue1))
        {
            Console.WriteLine("\nThe tree contains " + testValue1 +".");
        }
        else
        {
            Console.WriteLine("The tree does not contain " + testValue1 + ".");
        }

        if (tree.Contains(testValue2))
        {
            Console.WriteLine("The tree contains " + testValue2 + ".");
        }
        else
        {
            Console.WriteLine("The tree does not contain " + testValue2+ ".");
        }

        Console.ReadLine();
    }
}

