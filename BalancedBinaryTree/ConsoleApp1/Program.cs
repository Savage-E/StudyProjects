using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalancedBinaryTree;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<String> tree = new BinaryTree<string>("Влад");
            tree.Insert("Дима");
            tree.Insert("Олег");
            tree.Insert("Женя");
        }
    }
}
