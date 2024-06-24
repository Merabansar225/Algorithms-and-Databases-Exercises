using System;
namespace Ex2TaskC
{
    public class BinTree
    {
        private Node root;

        public BinTree()
        {
            root = null;
        }

        public BinTree(Node root)
        {
            this.root = root;
        }

        public void InOrder()
        {
            inOrder(root);
        }

        private void inOrder(Node tree)
        {
            if (tree != null)
            {
                inOrder(tree.Left);
                Console.Write(tree.Data + ",");
                inOrder(tree.Right);
            }
        }

        public void PostOrder()
        {
            postOrder(root);
        }

        private void postOrder(Node tree)
        {
            if (tree != null)
            {
                postOrder(tree.Left);
                postOrder(tree.Right);
                Console.Write(tree.Data + ",");
            }
        }

        public void PreOrder()
        {
            preOrder(root);
        }

        private void preOrder(Node tree)
        {
            if (tree != null)
            {
                Console.Write(tree.Data + ",");
                preOrder(tree.Left);
                preOrder(tree.Right);
            }
        }

        public void InsertItem(string item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(string item, ref Node tree)
        {
            if (tree == null)
            {
                tree = new Node(item);
            }
            else if (string.Compare(item, tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (string.Compare(item, tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public bool Contains(string item)
        {
            return contains(item, root);
        }

        private bool contains(string item, Node tree)
        {
            if (tree == null)
            {
                return false;
            }
            else if (string.Compare(item, tree.Data) < 0)
            {
                return contains(item, tree.Left);
            }
            else if (string.Compare(item, tree.Data) > 0)
            {
                return contains(item, tree.Right);
            }
            else
            {
                return true; 
            }
        }

        // Longest() string function 

        public string Longest()
        {
            return longest(root);
        }

        private string longest(Node tree)
        {
            if (tree == null)
            {
                return "";
            }

            string leftBranch;
            string rightBranch;
            string longestSubBranchInBranch;

            leftBranch = longest(tree.Left);
            rightBranch = longest(tree.Right);

            if (leftBranch.Length > rightBranch.Length)
            {
                longestSubBranchInBranch = leftBranch;
            }
            else
            {
                longestSubBranchInBranch = rightBranch;
            }

            if (tree.Data.Length > longestSubBranchInBranch.Length)
            {
                return tree.Data;
            }
            else
            {
                return longestSubBranchInBranch;
            }
        }

    }
}

