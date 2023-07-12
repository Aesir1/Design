// See https://aka.ms/new-console-template for more information

using FunctionalBuilder;

var person = new PersonBuilder().Called("Kuon").WorkAs("Software Dev").Build();
Console.WriteLine(person);
// the same approach but more general with generics
var person2 = new PersonFunctionalBuilder().Called("Sarah").WorkAs("Student").Build();
Console.WriteLine(person2);