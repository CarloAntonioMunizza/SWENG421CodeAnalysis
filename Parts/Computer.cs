using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Parts
{
    public class Computer
    {
        public Socket Socket;
        public IPart CPU;
        public IPart Mobo;
        public IPart RAM;
        public IPart GPU;
        public IPart PSU;
        public IPart Storage;
        public IPart Case;

        public float GetTotalCost()
        {
            return CPU.GetPrice() +
            Mobo.GetPrice() +
            RAM.GetPrice() +
            GPU.GetPrice() +
            PSU.GetPrice() +
            Storage.GetPrice() +
            Case.GetPrice();
        }

        public int GetTotalWattage()
        {
            return CPU.GetWattage() +
            Mobo.GetWattage() +
            RAM.GetWattage() +
            GPU.GetWattage() +
            Storage.GetWattage();
        }
    }
}
