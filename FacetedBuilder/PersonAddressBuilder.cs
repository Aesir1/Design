namespace FacetedBuilder;

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person)
    {
        Person = person;
    }

    public PersonAddressBuilder At(string streetAddress)
    {
        Person.StreetAddress = streetAddress;
        return this;
    }
    
    public PersonAddressBuilder In(string city)
    {
        Person.City = city;
        return this;
    }
    
    public PersonAddressBuilder PostCode(string postCode)
    {
        Person.PostCode = postCode;
        return this;
    }
}