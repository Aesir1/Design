namespace FluentBuilder;

public class Person
{
    public string Name, Position;
    public static Builder New => new();

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
}