namespace SingleResponsability;

public class Journal
{
    private static int count;
    private readonly List<string> entries = new();

    public int AddEntry(string text)
    {
        entries.Add($"{++count}: {text}");
        return count;
    }

    public void RemoveEntry(int index)
    {
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
}