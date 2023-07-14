using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference
{
    #region Using linked list implementation
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    /// <summary>
    /// Stack implementation using linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackLst<T>
    {
        private Node<T> top;

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = top;
            top = newNode;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("StackLst is empty");
            }

            T data = top.Data;
            top = top.Next;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("StackLst is empty");
            }

            return top.Data;
        }
    }

    #endregion

    #region Using Array implementation

    /// <summary>
    /// Stack implementation using array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackArr<T>
    {
        private T[] stackArray;
        private int top;
        private int capacity;

        public StackArr(int capacity)
        {
            stackArray = new T[capacity];
            this.capacity = capacity;
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == capacity - 1;
        }

        public void Push(T data)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("StackArr is full");
            }

            stackArray[++top] = data;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("StackArr is empty");
            }

            T data = stackArray[top--];
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("StackArr is empty");
            }

            return stackArray[top];
        }
    }


    #endregion

}
