using OpenClosed.Specification;

namespace OpenClosed;

public class FilterProducts : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
    {
        foreach (var item in items)
        {
            if (specification.IsSatisfied(item))
            {
                yield return item;
            }
        }
    }
}