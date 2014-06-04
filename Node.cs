namespace ReverseLinkedList
{
    public class Node
    {
        public Node(string value)
        {
            Value = value;
        }

        public Node Next { get; set; }
        public string Value { get; private set; }
    }
}