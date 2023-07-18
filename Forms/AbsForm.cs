using Microsoft.VisualBasic.Devices;
using PCBuilder.Future;
using PCBuilder.Observer;
using PCBuilder.Parts;
using Computer = PCBuilder.Parts.Computer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PCBuilder
{
    public class AbsForm : Form
    {

        protected MainForm mainform;
        protected Computer? computer;
        protected Inventory? inventory;
        public Dictionary<Type, List<IPart>> partFutureDic = new Dictionary<Type, List<IPart>>();

        public AbsForm(MainForm mainForm, Computer computer, Inventory inventory)
        {
            this.mainform = mainForm;
            this.computer = computer;
            this.inventory = inventory;
        }

        protected async Task<List<IPart>> GetParts(PartsFuture future)
        {
            while (!future.IsCompleted())
            {
                await Task.Delay(10);
            }
            return future.GetParts();
        }

    }
}
