namespace SortingStacks;

public static class StackSortImproved<T> where T : IComparable<T>
{
    public static void SortStack(Stack<T> stack)
    {
        var buffer = new Stack<T>();

        while (stack.Count > 0)
        {
            var temp = stack.Pop();
            while (buffer.Count > 0 && temp.CompareTo(buffer.Peek()) < 0)
            {
                stack.Push(buffer.Pop());
            }
            
            buffer.Push(temp);
        }

        while (buffer.Count > 0)
        {
            stack.Push(buffer.Pop());
        }
    }
}