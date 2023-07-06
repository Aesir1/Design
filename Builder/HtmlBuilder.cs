namespace Builder;

public class HtmlBuilder
{
    private HtmlElement root = new HtmlElement();
    private readonly string rootName;


    public HtmlBuilder(string rootName)
    {
        this.rootName = rootName;
        root.Name = this.rootName;
    }

    // Fluent builder or Fluent Interface
    public HtmlBuilder AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        root.Elements.Add(e);
        return this;
    }

    public override string ToString()
    {
        return root.ToString();
    }

    public void Clear()
    {
        root = new HtmlElement()
        {
            Name = rootName
        };
    } 
}