// See https://aka.ms/new-console-template for more information

using DependencyInversion;

var parent = new Person(){ Name = "John"};
var child = new Person(){Name = "Tedy"};
var relationships = new Relationships();
relationships.AddParentAndChild(parent, child);

var unused = new Research(relationships, parent.Name);
