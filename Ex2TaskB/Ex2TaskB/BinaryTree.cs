﻿using System;
namespace Ex2TaskA
{
    public class BinTree
    {
        private Node root;

        public BinTree()
        {
            root = null;
        }

        public BinTree(Node node)
        {
            root = node;
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

        public void InsertItem(int item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(int item, ref Node tree)
        {
            if (tree == null)
            {
                tree = new Node(item);
            }
            else if (item < tree.Data)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item > tree.Data)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public Boolean Contains(int item)
        {
            return contains(item, root);
        }

        private Boolean contains(int item, Node tree)
        {
            if (tree == null)
            {
                return false;
            }
            else if (item < tree.Data)
            {
                return contains(item, tree.Left);
            }
            else if (item > tree.Data)
            {
                return contains(item, tree.Right);
            }
            else
            {
                return true; 
            }
        }
    }
}

// https://social.msdn.microsoft.com/Forums/vstudio/en-US/e7ca8f9a-e7aa-44c2-889f-38586dd74fe3/binary-search-tree-contains-method-stackoverflowexception?forum=csharpgeneral - Contains method 