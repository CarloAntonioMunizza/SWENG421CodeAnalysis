using PCBuilder.Parts;

namespace PCBuilder.Filter;

public class PartFilter
{
    public static List<IPart> FilterParts(List<IPart> parts, ISpecification specification)
    {
        List<IPart> filteredParts = new List<IPart>();
        foreach (var part in parts)
        {
            if (specification.IsSatisfied(part))
                filteredParts.Add(part);
        }
        return filteredParts;
    }
    
}