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

        Console.Write("PostOrder: ");
        tree.PostOrder();
        Console.WriteLine();

        Console.Write("PreOrder: ");
        tree.PreOrder();
        Console.WriteLine();

        Console.ReadLine();
    }
}

