using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Parts
{
    public abstract class CPU : BasePart
    {
        int wattsNeeded = 0;

        public CPU(string name, float price, int wattsNeeded) : base(name, price)
        {
            this.wattsNeeded = wattsNeeded;
        }

        public override int GetWattage()
        {
            return wattsNeeded;
        }

        public abstract bool CanSupportSAM();
    }
}
