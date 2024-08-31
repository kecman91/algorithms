// See https://aka.ms/new-console-template for more information
using Domain.Models.Lists;

Console.WriteLine("Hello, World!");

Random rand = new Random();

var head = new Node<int>(0);
// Initialize the matrix with random values
for (int i = 0; i < 20; i++)
{
    head.AppendToTail(rand.Next(0, 10));
}

head.PrintList();

RemoveDuplicates.RemoveDupes<int>.RemoveDuplicates(head);

Console.WriteLine("--------------");
head.PrintList();
