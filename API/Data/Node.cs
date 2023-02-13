using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class Node
    {
        public int Value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node(int value)
        {
            Value = value;
            Right = null;
            Left = null;
        }
    }

    public class BinarySearchTree
    {
        private Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertNode(root, value);
        }

        private Node InsertNode(Node node, int value)
        {
            if(node == null)
            {
                node = new Node(value);
                return node;
            }
            if(value < node.Value )
            {
                node.Left = InsertNode(node.Left, value);
            }
            else
            {
                node.Right = InsertNode(node.Right, value);
            }
            
            return node;
        }
    }
}