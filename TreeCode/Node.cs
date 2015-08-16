using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    public class Node<T> where T : IComparable<T> 
    {
       
      public  Node() {}
       public Node(T value)
        {
            _nodeValue = value;
        }
        T _nodeValue;

        public T NodeValue
        {
            get { return _nodeValue; }
            set { _nodeValue = value; }
        }
        Node<T> _left = null;
        Node<T> _right = null;
        Node<T> _parent = null;

        public Node<T> Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        public Node<T> Left
        {
            get { return _left; }
            set { _left = value;
            _left.Parent = this;
            }
        }
        
        public Node<T> Right
        {
            get { return _right; }
            set { _right = value;
            _right.Parent = this;
            }
        }

        public void PrintNodeValue()
        {
            Console.WriteLine("Node value is {0:d} and level is {1:d}", _nodeValue, Level);

        }

        public uint Level
        {
            get
            {
                uint level = 0;
                Node<T> temp = this;
                while (temp.Parent != null)
                {
                    level++;
                    temp = temp.Parent;
                }
                return level;

            }
        }
    }
}
