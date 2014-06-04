using System;

namespace ReverseLinkedList
{
    class Stack
    {
        public Node Head { get; set; }

        public Stack(Node head)
        {
            Head = head;
        }

        public Node Pop()
        {
            if (IsEmpty()) return null;

            Node node = Head;
            Head = Head.Next;
            return node;
        }

        public void Push(Node node)
        {
            if (node == null) throw new ArgumentNullException("node");

            node.Next = Head;
            Head = node;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}