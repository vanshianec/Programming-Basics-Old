using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    class Program
    {
        static void Main(string[] args)
        {
          // Tree<int> tree =
          //     new Tree<int>(7,
          //         new Tree<int>(21,
          //             new Tree<int>(85,
          //                 new Tree<int>(100))),
          //         new Tree<int>(12),
          //         new Tree<int>(1));
          //
          // tree.Print();
            BinaryTree<int> binTree =
                new BinaryTree<int>(12,
                    new BinaryTree<int>(43,
                        new BinaryTree<int>(31),
                            new BinaryTree<int>(5555)),
                    new BinaryTree<int>(65));
            binTree.Print();
                 
        }
    }
}
