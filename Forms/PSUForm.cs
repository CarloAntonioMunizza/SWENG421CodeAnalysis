using PCBuilder.Observer;
using PCBuilder.Parts;
using Computer = PCBuilder.Parts.Computer;
using PCBuilder.Filter;
using PCBuilder.Wrapper;

namespace PCBuilder
{
    public partial class PSUForm : AbsForm
    {


        public PSUForm(Computer computer, Inventory inventory, MainForm mainform) : base(mainform, computer, inventory)
        {
            InitializeComponent();
            SetupPSU();

            SocketDisp.Text = computer.Socket == Socket.INTEL ? "Socket: Intel" : "Socket: AMD";
            CaseDisp.Text = "Case: " + computer.Case.ToString();
            StorageDisp.Text = "Storage: " + computer.Storage.ToString();
            RAMDisp.Text = "RAM: " + computer.RAM.ToString();
            GPUDisp.Text = "GPU: " + computer.GPU.ToString();
            MOBODisp.Text = "MotherBoard: " + computer.Mobo.ToString();
            CPUDisp.Text = "CPU: " + computer.CPU.ToString();


            IPart cpu = computer.CPU;
            while(cpu is PartWrapper wrapper)
            {
                if(wrapper.accessory is ThermalPaste)
                {
                    ThermalDisp.Text = "Thermal Paste: " + wrapper.accessory.ToString();
                }
                else if (wrapper.accessory is CPUCooler)
                {
                    CoolerDisp.Text = "CPU Cooler: " + wrapper.accessory.ToString();
                }

                cpu = wrapper.part;
            }

        }

        async void SetupPSU()
        {

            List<IPart> psuParts = await GetParts(inventory.GetPartsFromDatabase(typeof(PSU)));
            psuParts = PartFilter.FilterParts(psuParts, new PSUWattageSpec(computer.GetTotalWattage()));

            partFutureDic.Add(typeof(PSU), psuParts);
            PSUDropDown.Items.AddRange(psuParts.Select(x => x.ToString()).ToArray());
        }

        private void PSUDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> parts = partFutureDic.GetValueOrDefault(typeof(PSU));
            computer.PSU= parts[PSUDropDown.SelectedIndex];
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            if(computer.PSU != null)
            {
                mainform.OpenDisplayForm();

            }
        }
    }
}
