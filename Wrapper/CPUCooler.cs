namespace PCBuilder.Wrapper;

public class CPUCooler : PartAccessory
{
    int wattageRequired;
    public CPUCooler(string name, float price, int wattageRequired) : base(name, price)
    {
        this.wattageRequired = wattageRequired;
    }

    public override int GetWattage()
    {
        return base.GetWattage();
    }
}