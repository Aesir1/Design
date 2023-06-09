﻿using OpenClosed.Enums;

namespace OpenClosed.Specification;

public class ColorSpecification : ISpecification<Product>
{
    private readonly Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }
    public bool IsSatisfied(Product t)
    {
        return t.Color == _color;
    }
}