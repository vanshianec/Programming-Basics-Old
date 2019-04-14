using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    class Tree<T>
    {
        private Node<T> root;
        
        public Tree(T value,params Tree<T>[] treeChildren)
        {
            this.root = new Node<T>(value);
            foreach (var treeChild in treeChildren)
            {
                this.root.addChild(treeChild.root);
            }
        }

        public void PrintRecursive(Node<T> root,int spacer)
        {
            Console.Write(new string(' ', spacer * 2));
            Console.WriteLine(root.Value);
            foreach (var nodeChild in root.getNodeChildren())
            {
                PrintRecursive(nodeChild, spacer + 1);
            }
        }

        public void Print()
        {
            PrintRecursive(this.root, 0);
        }
        

    }
    class Node<T>
    {
        private T value;
        private bool hasParent;
        private List<Node<T>> children;

        public Node(T value)
        {
            this.value = value;
            this.children = new List<Node<T>>();
            this.hasParent = false;

        }

        public T Value
        {
            get
            {
                return this.value;
            }
        }

        public void addChild(Node<T> nodeChild)
        {
            if (!nodeChild.hasParent)
            {
                nodeChild.hasParent = true;
                this.children.Add(nodeChild);
            }
        }
        
        public List<Node<T>> getNodeChildren()
        {
            return this.children;
        }
        
    }


}
