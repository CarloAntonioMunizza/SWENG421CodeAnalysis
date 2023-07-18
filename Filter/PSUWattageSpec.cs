using PCBuilder.Parts;

namespace PCBuilder.Filter;

public class PSUWattageSpec : ISpecification
{
    private readonly int _wattsNeeded;

    public PSUWattageSpec(int wattsNeeded)
    {
        _wattsNeeded = wattsNeeded;
    }

    public bool IsSatisfied(IPart part)
    {
        return part is PSU psu && psu.Wattage >= _wattsNeeded;
    }
}