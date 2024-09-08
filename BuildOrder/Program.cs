// See https://aka.ms/new-console-template for more information
using BuildOrder;

Console.WriteLine("Hello, World!");

var projects = new string[6] {"a", "b", "c", "d", "e", "f"};
var dependencies = new string[5][] { ["a", "d"], ["f", "b"], ["b", "d"], ["f", "a"], ["d", "c"]};

var graph = BuildGraphFactory.CreateBuildGraph(projects, dependencies);

var buildOrder = graph.GetBuildOrder();

Console.WriteLine("The projects should be built in the following order:");
foreach (var project in buildOrder)
{
    Console.Write(project.Name + ", ");
}