namespace BuildOrder;

public class BuildGraph
{
    private Dictionary<string, Project> _nodes = [];

    public void AddProject(Project p)
    {
        _nodes.TryAdd(p.Name, p);
    }

    public Project GetProject(string name)
    {
        return _nodes[name];
    }

    public List<Project> GetBuildOrder()
    {
        var res = new List<Project>();
        foreach (var project in _nodes.Values)
        {
            if (project.BuildState == BuildState.NotBuilt)
            {
                if (!Build(res, project))
                {
                    break;
                }
            }
        }

        return res;
    }

    private static bool Build(List<Project> buildOrder, Project p)
    {
        if (p.BuildState == BuildState.Building)
        {
            // cycle
            return false;
        }

        if (p.BuildState == BuildState.NotBuilt)
        {
            p.BuildState = BuildState.Building;
            foreach (var dependency in p.Dependencies)
            {
                if (!Build(buildOrder, dependency))
                {
                    return false;
                }
            }

            p.BuildState = BuildState.Completed;
            buildOrder.Add(p);
        }

        return true;
    }
}