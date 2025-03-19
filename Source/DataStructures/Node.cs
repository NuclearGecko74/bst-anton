using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Source.DataStructures
{
    class Node
    {
        public int value;
        public Node left, right;

        public Node(int value, Node left, Node right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public Node(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
}
