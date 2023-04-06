using OpenClosed.Enums;

namespace OpenClosed;

public class Product
{
    public Product(string name, Color color, Size size)
    {
        Name = name;
        Color = color;
        Size = size;
    }

    public string Name { get; set; }

    public Color Color { get; set; }

    public Size Size { get; set; }
}