namespace PCBuilder.Parts;

public class AMDMotherboard : Motherboard
{
    public AMDMotherboard(string name, float price, int wattsNeeded) : base(name, price, wattsNeeded)
    {
    }

    public override bool CanSupportSLI()
    {
        return false;
    }
}