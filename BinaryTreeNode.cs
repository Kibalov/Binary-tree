using System;

namespace _7.Binary_tree
{
    class BinaryTreeNode<T> where T : IComparable<T>
    {
        public T value;
        public BinaryTreeNode<T> left;
        public BinaryTreeNode<T> right;
        public BinaryTreeNode<T> parent;
        public int count =1;
        public BinaryTreeNode(T value)
        {
            this.value = value;
        }
    }
}
