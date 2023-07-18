namespace PCBuilder.Parts
{
    public class IntelMotherboard : Motherboard
    {
        public IntelMotherboard(string name, float price, int wattsNeeded) : base(name, price, wattsNeeded)
        {
        }

        public override bool CanSupportSLI()
        {
            return true;
        }
    }
}