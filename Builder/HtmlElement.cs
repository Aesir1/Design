using System.Text;

namespace Builder;

public class HtmlElement
{
    public string Name, Text;
    public List<HtmlElement> Elements = new();
    private const int IndentSize = 2;

    public HtmlElement()
    {
        
    }

    public HtmlElement(string name, string text)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
    }

    private string ToStringImplementation(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', IndentSize * indent);

        sb.AppendLine($"{i}<{Name}>");
        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', IndentSize * (indent + 1)));
            sb.AppendLine(Text);
        }

        foreach (var e in Elements)
        {
            sb.Append(e.ToStringImplementation(indent + 1));
        }
        sb.AppendLine($"{i}</{Name}>");
        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImplementation(0);
    }
}