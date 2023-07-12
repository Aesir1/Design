// See https://aka.ms/new-console-template for more information

using FacetedBuilder;

var personBuilder = new PersonBuilder();
personBuilder.Lives.At("Main Street 35").In("Hamburg").PostCode("20000").Works.At("Cargonerds").AsA("SoftDev").Earning(4000);
Person person = personBuilder;
Console.WriteLine(person);