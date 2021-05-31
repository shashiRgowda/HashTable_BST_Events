using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTreeDemo
{
    class BinarySearchTree
    {
        public T NodeData { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }
        public BinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.Left = null;
            this.Right = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.Left == null)
                    this.Left = new BinaryTree<T>(item);
                else
                    this.Left.Insert(item);
            }
            else
            {
                if (this.Right == null)
                    this.Right = new BinaryTree<T>(item);
                else
                    this.Right.Insert(item);
            }
        }
        public void Display()
        {
            if (this.Left != null)
            {
                this.leftCount++;
                this.Left.Display();
            }
            Console.WriteLine(this.NodeData);
            if (this.Right != null)
            {
                this.rightCount++;
                this.Right.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExist(T element, BinaryTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element is found in the Binary Search Tree" + " " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in the Binary Search Tree", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExist(element, node.Left);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExist(element, node.Right);
            }
            return result;
        }



    }
}
    
