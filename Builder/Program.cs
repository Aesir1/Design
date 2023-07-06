// See https://aka.ms/new-console-template for more information

using Builder;

Console.WriteLine("Hello, World!");

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "Hello").AddChild("li", "World");
Console.WriteLine(builder.ToString());