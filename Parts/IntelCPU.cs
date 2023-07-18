

namespace PCBuilder.Parts
{
    public class IntelCPU : CPU
    {
        public IntelCPU(string name, float price, int wattsNeeded) : base(name, price, wattsNeeded)
        {
        }

        public override bool CanSupportSAM()
        {
            return false;
        }
    }
}