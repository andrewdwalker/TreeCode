using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
    public class BinaryTree
    {
        Node<int> _parent = null;

        public bool AddValue(int value)
        {
            if (_parent == null)
            {
                _parent = new Node<int>();
                _parent.NodeValue = value;
            }
            else
            {
                Node<int> temp = _parent;
                while (temp.Left != null)
                {
                    temp = temp.Left;
                }

                temp.Left = new Node<int>(value);

            }

        }
    }
}
