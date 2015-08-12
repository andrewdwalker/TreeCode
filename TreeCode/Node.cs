using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    public class Node<T>
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
            set { _right = value; }
        }
    }
}
