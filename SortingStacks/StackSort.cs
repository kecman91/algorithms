namespace SortingStacks;

public static class StackSort<T> where T : IComparable<T>
{
    public static void SortStack(Stack<T> stack)
    {
        var buffer = new Stack<T>();

        var size = stack.Count;

        while (size > 0)
        {
            var max = stack.Pop();
            while (size - 1 > 0 )
            {
                var item = stack.Pop();
                if (item.CompareTo(max) > 0)
                {
                    buffer.Push(max);
                    max = item;
                }
                else
                {
                    buffer.Push(item);
                }

                size--;
            }
    
            stack.Push(max);
            size = buffer.Count;

            while (buffer.Count > 0)
            {
                stack.Push(buffer.Pop());
            }
        }
    }
}