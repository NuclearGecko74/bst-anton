using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree.Source.DataStructures;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree(47);
            tree.Insert(21);
            tree.Insert(18);
            tree.Insert(27);

            tree.Insert(76);
            tree.Insert(52);
            tree.Insert(82);

            tree.InOrder();
        }
    }
}
