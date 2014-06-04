using System;

namespace ReverseLinkedList
{
    public class SingleLinkedList
    {
        public static void Traverse(Node head)
        {
            if (head == null)
                return;

            Console.Write("{0}->", head.Value);
            Traverse(head.Next);
        }

        public static Node Reverse(Node head)
        {
            var input = new Stack(head);
            var output = new Stack(null);
            while (!input.IsEmpty())
            {
                output.Push(input.Pop());
            }

            return output.Head;
        }
    }
}