namespace DependencyInversion;

public class Research
{
    public Research(IRelationshipBrowser browser, string name)
    {
        foreach (var person in browser.FindAllChildrenOf(name))
        {
            Console.WriteLine(name + " has a child called " + person.Name);
        }
    }
}