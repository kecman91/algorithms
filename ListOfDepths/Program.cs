using Utils.Tree;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var array = new int[]{-3,-2,0,1,4,6,7,7,8,12,24,25,26,27,28,30,55,56};

var tree = TreeUtils.CreateMinimalBinarySearchTree(array);

var listOfDepths = ListOfDepths.ListOfDepths<int>.CreateListOfDepths(tree!);

while (listOfDepths != null)
{
    foreach (var data in listOfDepths.Data)
    {
        Console.Write(data + ",");
    }
    Console.Write("\n");

    listOfDepths = listOfDepths.Next;
}