using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS
{
    public enum TraverseOrder
    {
        InOrder,
        PreOrder,
        PostOrder
    }

    public class ADSTree
    {
        private ADSNode root;

        public sealed class ADSNode
        {
            public ADSNode left;
            public ADSNode right;
            public int key;
            public int cardinality;  //  Increment each time duplicates are added
            public int height;  // Height of this node
        }

        public ADSTree()
        {
            root = null;
        }

        // Return the node where value is located
        public ADSNode find(int value)
        {
            return null;
        }

        public void insert(ADSNode parent, int value)
        {
            if (value > parent.key)
            {
                if (parent.right == null)
                {
                    // Create a new node connected to parent.right   
                    ADSNode n = new ADSNode();
                    n.key = value;
                    parent.right = n;
                                
                }
                else
                {
                    insert(parent.right, value);

                    parent.height = Math.Max(parent.left == null ? 0 : parent.left.height,
                                             parent.right == null ? 0 : parent.right.height) + 1;

                }
            }
            else if (value < parent.key)
            {
                if (parent.left == null)
                {
                    // create a new node connected to parent.left
                    ADSNode n = new ADSNode();
                    n.key = value;
                    parent.left = n;

                }
                else
                {
                    insert(parent.left, value);

                    parent.height = Math.Max(parent.left == null ? 0 : parent.left.height,
                                             parent.right == null ? 0 : parent.right.height) + 1;

                }

            }
        }

        // Inserts a node into the tree and maintains it's balance
        public void insert(int value)
        {


            ADSNode n = new ADSNode();
            n.left = null;
            n.right = null;
            n.key = value;
            n.cardinality = 0;
            n.height = 0;

            ADSNode node = root;

            while (true)
            {


                if (value > node.key)
                {
                    if (node.right == null)
                    {
                        node.right = n;
                        break;
                    }
                    else
                        node = node.right;
                }
                else if (value == root.key)
                {
                    node.cardinality++;
                }
                else if (value < root.key)
                {
                    root.left = n;
                }
            }
        }

        public void printTree(ADSNode node, TraverseOrder order)
        {
            if (node == null) return;

            printTree(node.left, order);
            if (order == TraverseOrder.InOrder) Console.Write(node.key);
            printTree(node.right, order);
        }

        // Print the tree in a particular order
        public void printTree(TraverseOrder order)
        {
            printTree(root, order);
        }
    }
}
