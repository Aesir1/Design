// See https://aka.ms/new-console-template for more information

using Builder;

Console.WriteLine("Hello, World!");

//var builder = new HtmlBuilder("ul");
//builder.AddChild("li", "Hello").AddChild("li", "World");
//Console.WriteLine(builder.ToString());

static void Increment(ref int i)
{
    i = i + 1;
} 

int x = 1;
  
Increment(ref x);

Console.WriteLine($"The value of x is: {x}");

Console.Read(); 