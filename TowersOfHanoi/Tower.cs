using System.Text;

namespace TowersOfHanoi;

public class Tower(Stack<int> disks)
{
    public Stack<int> Disks { get; private set; } = disks;

    public void Add(int disk)
    {
        if (Disks.Count > 0 && Disks.Peek() < disk)
        {
            throw new InvalidOperationException("Can't place disk: " + disk);
        }
        else
        {
            Disks.Push(disk);
        }
    }

    public void MoveTopTo(Tower t)
    {
        t.Add(Disks.Pop());
    }

    public void MoveDisks(int quantity, Tower destination, Tower buffer)
    {
        if (quantity == 1) return;

        MoveDisks(quantity - 1, buffer, destination);
        MoveTopTo(destination);
        buffer.MoveDisks(quantity - 1, destination, this);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var disk in Disks)
        {
            sb.Append(disk);
            sb.Append('\n');
        }

        return sb.ToString();
    }
}