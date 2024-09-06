// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using DynamicProgramming;
using Utils.Matrix;

Console.WriteLine("Hello, World!");

var sw = new Stopwatch();
sw.Start();

/* Console.WriteLine(Fibonacci.FibonacciInefficient(50));
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

sw.Restart();
Console.WriteLine(Fibonacci.FibonacciMemo(50));
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

sw.Restart();
Console.WriteLine(Fibonacci.FibonacciTopDown(50));
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

Console.WriteLine(Staircase.CountStepsMemo(5)); */

/* int[,] matrix = {
    { 0, 0, 1, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 1, 0 },
    { 0, 1, 0, 0, 1, 0 },
    { 0, 0, 1, 0, 1, 0 }
};

var (thereIsAWay, result) = RobotInAGrid.FindWayMemo(matrix);

Console.WriteLine(thereIsAWay);

MatrixUtils.Print(result); */

/* var array = new int[11] {-15, -12, -10, -5, -3, 0, 1, 4, 6, 9, 11};
Console.WriteLine("The magic index is: " + MagicIndex.FindMagicIndexBinariSearch(array));

var arrayDupes = new int[11] {-5, -4, -4, 5, 5, 5, 5, 6, 6, 9, 10};
Console.WriteLine("The magic index is: " + MagicIndex.FindMagicIndexBinariSearch(arrayDupes)); */

/* var a = 5;
var b = 7;
Console.WriteLine($"{a} * {b} = {RecursiveMultiply.MultiplyImproved(a, b)}"); */

var permutations = PermutationsWithoutDups.FindPermutations("abc");
foreach (var str in permutations)
{
    Console.WriteLine(str);
}

sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);
