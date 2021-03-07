using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    class Program
    {
        static void Main(string[] args)
        {

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.AddValue(5);
            for (int i = 0; i < 10; i++)
            {
               binarySearchTree.AddValue(i + 3);
            }

            binarySearchTree.AddValue(2);
            binarySearchTree.AddValue(20);
         binarySearchTree.AddValue(-1);
         binarySearchTree.AddValue(1);

            binarySearchTree.PrintOutTree();
        }
    }
}
