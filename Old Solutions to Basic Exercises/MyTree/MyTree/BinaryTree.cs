using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    class BinaryTree<T>
    {
        private TreeNode<T> root;

        public BinaryTree(T value,BinaryTree<T> leftChild,BinaryTree<T> rightChild)
        {
            TreeNode<T> leftNode = leftChild == null ? null : leftChild.root;
            TreeNode<T> rightNode = rightChild == null ? null : rightChild.root;
            this.root = new TreeNode<T>(value, leftNode, rightNode);
                       
        }

        public BinaryTree(T value) : this(value, null, null)
        {

        }
        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public void PrintRecursive(TreeNode<T> root)
        {
            if(root == null)
            {
                return;
            }
            PrintRecursive(root.LeftChild);
            Console.WriteLine(root.Value);
            PrintRecursive(root.RightChild);
        }
        public void Print()
        {
            PrintRecursive(this.root);
        }

        


    }


    class TreeNode<T>
    {
        private T value;
        private bool hasParent;
        private TreeNode<T> leftChild;
        private TreeNode<T> rightChild;

        public TreeNode(T value)
        {
            this.value = value;
            this.leftChild = null;
            this.rightChild = null;
          
        }

        public TreeNode(T value, TreeNode<T> leftChild, TreeNode<T> rightChild)
        {
            this.value = value;
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
        }

        public TreeNode<T> LeftChild
        {
            get
            {
                return this.leftChild;
            }
        }

        public TreeNode<T> RightChild
        {
            get
            {
                return this.rightChild;
            }
        }


    }
}
