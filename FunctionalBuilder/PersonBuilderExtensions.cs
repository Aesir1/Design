namespace FunctionalBuilder;

public static class PersonBuilderExtensions
{
    public static PersonBuilder WorkAs(this PersonBuilder builder, string position)
        => builder.Do(p => p.Position = position);
}