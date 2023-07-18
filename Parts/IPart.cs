using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Parts
{
    public interface IPart
    {
        public float GetPrice();
        public int GetWattage();
    }
}
