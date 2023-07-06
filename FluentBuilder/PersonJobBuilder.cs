namespace FluentBuilder;

// Recursive generics
public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF : PersonJobBuilder<SELF>
{
    public SELF WorkAsA(string position)
    {
        person.Position = position;
        return (SELF) this;
    }
}