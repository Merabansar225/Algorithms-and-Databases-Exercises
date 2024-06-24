namespace Ex2TaskC;
class Program
{
    static void Main(string[] args)
    {
        BinTree tree = new BinTree();
        tree.InsertItem("applessssss");
        tree.InsertItem("banana");
        tree.InsertItem("cherry");
        tree.InsertItem("grape");
        tree.InsertItem("kiwi");
        tree.InsertItem("mango");

        Console.Write("InOrder: ");
        tree.InOrder();
        Console.WriteLine();

        // Test Longest method
        Console.WriteLine("Longest string: " + tree.Longest());

        Console.ReadLine();
    }
}


