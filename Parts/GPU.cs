using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Parts
{
    public class GPU : BasePart
    {
        int wattsNeeded = 0;

        public GPU(string name, float price, int wattsNeeded) : base(name, price)
        {
            this.wattsNeeded = wattsNeeded;
        }

        public override int GetWattage()
        {
            return wattsNeeded;
        }
    }
}
