using Domain.Models.Lists;

namespace PartitionLinkedList;

public static class Partitioning
{
    public static Node<T> Partition<T>(Node<T> linkedList, T target) where T : IComparable<T>
    {
        var head = linkedList;
        var iterator = head;

        while (iterator.Next != null)
        {
            if (iterator.Next.Data.CompareTo(target) < 0)
            {
                var temp = iterator.Next;
                iterator.Next = iterator.Next.Next;
                temp.Next = head;
                head = temp;
            }
            else
            {
                iterator = iterator.Next;
            }
        }

        return head;
    }
}