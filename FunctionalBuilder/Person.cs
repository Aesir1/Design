namespace FunctionalBuilder;

public class Person
{
    public string Name, Position;

    public override string ToString()
    {
        return $"Person called {Name} works as {Position}";
    }
}