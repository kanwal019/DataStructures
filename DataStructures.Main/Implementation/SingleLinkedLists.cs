using DataStructures.Library.LinkedLists.Single;

namespace DataStructures.Main.Implementation
{
    public class SingleLinkedLists
    {
        public static void DisplayResult()
        {
            List<int> linkedList = new List<int>();
            CreateList(ref linkedList);
            DisplayList(linkedList);
        }

        private static void CreateList(ref List<int> linkedList)
        {
            linkedList.Head = new Node<int>(10);
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);

            linkedList.Head.Next = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
        }

        private static void DisplayList(List<int> linkedList)
        {
            linkedList.Display();
        }
    }
}
