namespace PCBuilder.Parts
{
    public class AMDCPU : CPU
    {
        public AMDCPU(string name, float price, int wattsNeeded) : base(name, price, wattsNeeded)
        {
        }

        public override bool CanSupportSAM()
        {
            return true;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}