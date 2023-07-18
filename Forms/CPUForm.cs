using Microsoft.VisualBasic.Devices;
using PCBuilder.Observer;
using PCBuilder.Parts;
using Computer = PCBuilder.Parts.Computer;
using PCBuilder.AbsFactory;
using PCBuilder.Wrapper;

namespace PCBuilder
{
    public partial class CPUForm : AbsForm
    {

        private IPart cooler;
        private IPart paste;

        public CPUForm(Computer computer, Inventory inventory, MainForm mainform) : base(mainform, computer, inventory)
        {
            InitializeComponent();
            Socketlabel.Text = computer.Socket == Socket.INTEL ? "Socket: Intel" : "Socket: AMD";

            SetupDropDowns();
        }

        async void SetupDropDowns()
        {
            IFactory factory = CPUMotherboardFactory.CreateFactory(computer.Socket, inventory);
            List<IPart> cpuParts = await GetParts(factory.CreateCPUs());

            partFutureDic.Add(typeof(CPU),cpuParts);
            Console.WriteLine(cpuParts.Count);
            CPUDropDown.Items.AddRange(cpuParts.Select(x => x.ToString()).ToArray());

            List<IPart> moboParts = await GetParts(factory.CreateMotherboards());

            partFutureDic.Add(typeof(Motherboard), moboParts);
            MOBODropDown.Items.AddRange(moboParts.Select(x => x.ToString()).ToArray());


            List<IPart> thermalPaste = await GetParts(inventory.GetPartsFromDatabase(typeof(ThermalPaste)));
            partFutureDic.Add(typeof(ThermalPaste), thermalPaste);
            ThermDropDown.Items.AddRange(thermalPaste.Select(x => x.ToString()).ToArray());

            List<IPart> coolers = await GetParts(inventory.GetPartsFromDatabase(typeof(CPUCooler)));
            partFutureDic.Add(typeof(CPUCooler), coolers);
            CoolerDropDown.Items.AddRange(coolers.Select(x => x.ToString()).ToArray());

        }

        private void CPUDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> cpus = partFutureDic.GetValueOrDefault(typeof(CPU));
            computer.CPU = cpus[CPUDropDown.SelectedIndex];
        }


        private void MOBODropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> mobos = partFutureDic.GetValueOrDefault(typeof(Motherboard));
            computer.Mobo = mobos[MOBODropDown.SelectedIndex];
        }

        private void CoolerDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> coolers = partFutureDic.GetValueOrDefault(typeof(CPUCooler));
            cooler = coolers[CoolerDropDown.SelectedIndex];
        }

        private void PastesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> pastes = partFutureDic.GetValueOrDefault(typeof(ThermalPaste));
            paste = pastes[ThermDropDown.SelectedIndex];
        }

        void GotoBuilder(object sender, EventArgs e)
        {
            if(computer.Mobo != null && computer.CPU != null)
            {
                if(cooler != null)
                {
                    computer.CPU = new PartWrapper((BasePart)computer.CPU, (PartAccessory)cooler);
                }

                if(paste != null)
                {
                    computer.CPU = new PartWrapper(computer.CPU, (PartAccessory)paste);

                }

                mainform.OpenBuilderForm();
                Close();
                Dispose();
            }
        }
    }
}
