using Domain.Models.Lists;

namespace RemoveDuplicates;

public static class RemoveDupes<T>
{
    public static void RemoveDuplicates(Node<T> linkedList)
    {
        var reader = linkedList;

        while (reader != null)
        {
            var remover = reader;
            while (remover.Next != null)
            {
                if (remover.Next.Data?.Equals(reader.Data) == true)
                {
                    remover.Next = remover.Next.Next;
                }
                else
                {
                    remover = remover.Next;
                }
            }

            reader = reader.Next;
        }
    }
}