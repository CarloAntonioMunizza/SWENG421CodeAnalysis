using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Parts
{
    public class PSU : BasePart
    {
        public int Wattage;


        public PSU(string name, float price, int wattage) : base(name, price)
        {
            Wattage = wattage;
        }
    }
}
