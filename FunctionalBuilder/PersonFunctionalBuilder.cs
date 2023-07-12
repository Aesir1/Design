namespace FunctionalBuilder;

public sealed class PersonFunctionalBuilder : FunctionalBuilder<Person, PersonFunctionalBuilder>
{
    public PersonFunctionalBuilder Called(string name)
        => Do(p => p.Name = name);
    
    public PersonFunctionalBuilder WorkAs(string position)
        => Do(p => p.Position = position);
}