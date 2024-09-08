namespace BuildOrder;

public class Project(string name)
{
    public string Name { get; set; } = name;

    public BuildState BuildState { get; set; }

    public List<Project> Dependencies { get; set; } = [];
}