using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main()
        {
            var a = new Node("A");
            var b = new Node("B");
            var c = new Node("C");
            var d = new Node("D");
            
            a.Next = b;
            b.Next = c;
            c.Next = d;

            var input = a;

            Console.Write("Input:\t");
            SingleLinkedList.Traverse(input);
            Console.WriteLine();

            Node output = SingleLinkedList.Reverse(input);

            Console.Write("Output:\t");
            SingleLinkedList.Traverse(output);
            Console.WriteLine();
        }
    }
}
