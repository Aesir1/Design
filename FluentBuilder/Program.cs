// See https://aka.ms/new-console-template for more information

using FluentBuilder;


var person = Person.New.Called("Alain").WorkAsA("Software Dev").Build();
Console.WriteLine(person);
