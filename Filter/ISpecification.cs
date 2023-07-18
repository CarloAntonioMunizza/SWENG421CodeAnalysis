using PCBuilder.Parts;

namespace PCBuilder.Filter;

public interface ISpecification
{
    bool IsSatisfied(IPart part);
}