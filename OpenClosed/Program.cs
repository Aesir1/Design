// See https://aka.ms/new-console-template for more information

using OpenClosed;
using OpenClosed.Enums;
using OpenClosed.Specification;

Product apple = new Product("Apple", Color.Green, Size.Small);
Product tree = new Product("Tree", Color.Green, Size.Large);
Product house = new Product("House", Color.Blue, Size.Large);
Product[] products = {apple, tree, house};

FilterProducts filterProducts = new FilterProducts();
foreach (var product in filterProducts.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($"Product: {product.Name} is green");
}

foreach (var product in filterProducts.Filter(products, new AndSpecification<Product>(
             new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
{
    Console.WriteLine($"Product: {product.Name} is large and blue");
}