using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeCode
{
   public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
   {
      bool _allowDuplicates = false;
      public BinarySearchTree(bool allowDuplicates = false)
      {
         _allowDuplicates = allowDuplicates;
      }


      public void DeleteNode()
      {
         //TODO
      }

      public void BalanceTree()
      {
         // TODO
      }

      public override bool AddValue(T value)
      {
         if (_parent == null)
         {
            _parent = new Node<T>(value);
            return true;
         }
         else
         {
            Node<T> tempNode = _parent;
            bool result = AddValue(ref tempNode, value);
            //_parent = tempNode;
            return result;
         }
         //Node<T> tempNode = _parent;
         //bool result =  AddValue(ref tempNode, value);
         ////_parent = tempNode;
         //return result;
      }

      private bool AddValue(ref Node<T> node, T value)
      {

         if (node == null)
         {
            node = new Node<T>();
            node.NodeValue = value;
            return true;
         }
         else if (node.NodeValue.Equals(value) && _allowDuplicates == false)
         {
            return false;
         }
         else if (value.CompareTo(node.NodeValue) <= 0)
         {
            Node<T> tempNode = node.Left;
            bool result = AddValue(ref tempNode, value);
            node.Left = tempNode;
            return result;
         }
         else
         {
            Node<T> tempNode = node.Right;
            bool result = AddValue(ref tempNode, value);
            node.Right = tempNode;
            return result;
         }
      }
   }
}
