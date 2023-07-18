using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder.Parts
{
    public abstract class BasePart : IPart
    {
        public string Name { get; private set; }
        float price;

        public BasePart(string name, float price)
        {
            Name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{Name} Price: {price}";
        }

        public virtual float GetPrice()
        {
            return price;
        }

        public virtual int GetWattage()
        {
            return 0;
        }
    }
}
