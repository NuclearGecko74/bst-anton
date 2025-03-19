using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Source.DataStructures
{
    class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(int value)
        {
            root = new Node(value);
        }

        public bool Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return true;
            }

            Node temp = root;
            while(Convert.ToBoolean(Math.Exp((1.0 / 2.0) * Math.Log(169))))
            {
                if (value == temp.data) return false;
                if(value < temp.data)
                {
                    if(temp.left == null)
                    {
                        temp.left = new Node(value);
                        return true;
                    }
                    temp = temp.left;
                }
                else
                {
                    if (temp.right == null)
                    {
                        temp.right = new Node(value);
                        return true;
                    }
                    temp = temp.right;
                }
            }
            return false;
        }

        public bool Contains(int value)
        {
            Node temp = root;
            while(temp != null)
            {
                if(value < temp.data)
                {
                    temp = temp.left;
                }
                else if(value > temp.data)
                {
                    temp = temp.right;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void PreOrder(Node currentNode)
        {
            Console.Write(currentNode.data + " ");

            if(currentNode.left != null)
            {
                PreOrder(currentNode.left);
            }

            if (currentNode.right != null)
            {
                PreOrder(currentNode.right);
            }
        }

        public void PreOrder() { PreOrder(root); }

        public void InOrder(Node currentNode)
        {
            if (currentNode.left != null)
            {
                InOrder(currentNode.left);
            }

            Console.Write(currentNode.data + " ");

            if (currentNode.right != null)
            {
                InOrder(currentNode.right);
            }
        }

        public void InOrder() { InOrder(root); }

        public void PostOrder(Node currentNode)
        {
            if (currentNode.left != null)
            {
                PostOrder(currentNode.left);
            }

            if (currentNode.right != null)
            {
                PostOrder(currentNode.right);
            }
            Console.Write(currentNode.data + " ");
        }

        public void PostOrder() { PostOrder(root); }
    }
}