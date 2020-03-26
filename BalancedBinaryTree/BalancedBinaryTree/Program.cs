using System;

namespace BalancedBinaryTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(250);
            tree.Insert(200);
            tree.Insert(230);
            tree.Insert(240);
            tree.Insert(240);
            tree.Insert(1);
            tree.Insert(53);
            tree.Insert(41);
            tree.Insert(42);
            tree.Insert(24);
            tree.Erase(53);
            int a=0;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(tree.Search(a));

            Console.ReadKey();

        }
    }
}