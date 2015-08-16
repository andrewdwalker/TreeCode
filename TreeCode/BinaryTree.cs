using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    public class BinaryTree<T> where T : IComparable<T> 
    {
        protected Node<T> _parent = null;

        public virtual bool AddValue(T value)
        {
            if (_parent == null)
            {
                _parent = new Node<T>();
                _parent.NodeValue = value;
            }
            else
            {
                Node<T> temp = _parent;
                while (temp.Left != null)
                {
                    temp = temp.Left;
                }

                temp.Left = new Node<T>(value);

            }

            return true; // could return false in derived classes if value already exists?
        }

        public void PrintOutTree()
        {
            PrintOutTree(_parent);
        }
        public void PrintOutTree(Node<T> node)
        {
            if (node == null)
                return;
            else
            {
                node.PrintNodeValue();
                PrintOutTree(node.Left);
                PrintOutTree(node.Right);
            }
        }

    }
}
