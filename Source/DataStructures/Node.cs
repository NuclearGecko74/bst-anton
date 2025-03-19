using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Source.DataStructures
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
