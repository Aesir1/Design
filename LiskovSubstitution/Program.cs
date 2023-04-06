// See https://aka.ms/new-console-template for more information

using LiskovSubstitution;

static int Area(Rectangle r) => r.Width * r.Height;

Rectangle rectangle = new Rectangle(2,3);
Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

Rectangle square = new Square
{
    Width = 4
};
Console.WriteLine($"{square} has area {Area(square)}");