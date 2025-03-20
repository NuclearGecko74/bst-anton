using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Source.DataStructures
{
    class BinarySearchTree
    {
        private Node root;

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
                if (value == temp.value) return false;
                if(value < temp.value)
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
                if(value < temp.value)
                {
                    temp = temp.left;
                }
                else if(value > temp.value)
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
            Console.Write(currentNode.value + " ");

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

            Console.Write(currentNode.value + " ");

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
            Console.Write(currentNode.value + " ");
        }

        public void PostOrder() { PostOrder(root); }

        private Node deleteNode(Node currentNode, int value)
        {
            if (currentNode == null) return null;

            if (value < currentNode.value) {
                currentNode.left = deleteNode(currentNode.left, value);
            }
            else if(value > currentNode.value) {
                currentNode.right = deleteNode(currentNode.right, value);
            }
            else {
                if(currentNode.left == null && currentNode.right == null) {
                    currentNode = null;
                    return null;
                }
                else if (currentNode.left == null) {
                    Node temp = currentNode.right;
                    currentNode = null;
                    return temp;
                }
                else if (currentNode.right == null) {
                    Node temp = currentNode.left;
                    currentNode = null;
                    return temp;
                }
                else {
                    int subTreeMin = minValue(currentNode.right);
                    currentNode.value = subTreeMin;
                    currentNode.right = deleteNode(currentNode.right, subTreeMin);
                }
            }
            return currentNode;
        }

        public void deleteNode(int value) { root = deleteNode(root, value); }

        public int minValue(Node currentNode)
        {
            while(currentNode.left != null)
            {
                currentNode = currentNode.left;
            }
            return currentNode.value;
        }

        public Node getRoot() { return root; }
    }
}