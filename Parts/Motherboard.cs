using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Parts
{
    public abstract class Motherboard : BasePart
    {
        int wattsNedded = 0;

        public Motherboard(string name, float price, int wattsNeeded) : base(name, price)
        {
            this.wattsNedded = wattsNeeded;
        }

        public abstract bool CanSupportSLI();

        public override int GetWattage()
        {
            return wattsNedded;
        }
    }
}
