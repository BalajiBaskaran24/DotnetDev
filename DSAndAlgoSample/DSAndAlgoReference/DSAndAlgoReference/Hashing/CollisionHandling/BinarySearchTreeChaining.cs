using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Hashing.CollisionHandling
{
    /// <summary>
    /// Generic BST node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BSTNode<T> where T : IComparable<T>
    {
        public T Key { get; set; }
        public BSTNode<T> Left { get; set; }
        public BSTNode<T> Right { get; set; }

        public BSTNode(T key)
        {
            Key = key;
            Left = Right = null;
        }
    }

    /// <summary>
    /// Generic BST made of BSTNode
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BSTNode<T> Root { get; private set; }

        public void Insert(T key)
        {
            Root = InsertRec(Root, key);
        }

        private BSTNode<T> InsertRec(BSTNode<T> root, T key)
        {
            if (root == null)
                return new BSTNode<T>(key);

            if (key.CompareTo(root.Key) < 0)
                root.Left = InsertRec(root.Left, key);
            else if (key.CompareTo(root.Key) > 0)
                root.Right = InsertRec(root.Right, key);

            return root;
        }

        public bool Search(T key)
        {
            return SearchRec(Root, key);
        }

        private bool SearchRec(BSTNode<T> root, T key)
        {
            if (root == null)
                return false;

            if (key.CompareTo(root.Key) == 0)
                return true;

            return key.CompareTo(root.Key) < 0 ? SearchRec(root.Left, key) : SearchRec(root.Right, key);
        }
    }

}
