using Domain.Models.Lists;
using PartitionLinkedList;

Console.WriteLine("Hello, World!");

Random rand = new Random();

var head = new Node<int>(0);
// Initialize the matrix with random values
for (int i = 0; i < 20; i++)
{
    head.AppendToTail(rand.Next(0, 10));
}

head.PrintList();

var newHead = Partitioning.Partition(head, 5);

Console.WriteLine("--------------");
newHead.PrintList();
