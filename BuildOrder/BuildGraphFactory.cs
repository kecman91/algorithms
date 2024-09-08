namespace BuildOrder;

public static class BuildGraphFactory
{
    public static BuildGraph CreateBuildGraph(string[] projects, string[][] dependencies)
    {
        var graph = new BuildGraph();

        foreach (var project in projects)
        {
            graph.AddProject(new Project(project));
        }

        foreach (var dependency in dependencies)
        {
            var project = graph.GetProject(dependency[0]);
            project.Dependencies.Add(graph.GetProject(dependency[1]));
        }

        return graph;
    }
}