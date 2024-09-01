// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var stack = new Stack<int>();

stack.Push(1);
stack.Push(5);
stack.Push(-6);
stack.Push(9);
stack.Push(5);
stack.Push(2);
stack.Push(1);
stack.Push(0);
stack.Push(15);

SortingStacks.StackSortImproved<int>.SortStack(stack);

while (stack.Count > 0)
{
    var el = stack.Pop();
    Console.WriteLine(el);
}