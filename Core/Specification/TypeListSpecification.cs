using System;
using Core.Entities;

namespace Core.Specification;

public class TypeListSpecification : BaseSpecification<Product, string>
{
    public TypeListSpecification()
    {
        ApplyDistinct();
        AddSelect(p => p.Type);
    }
}
