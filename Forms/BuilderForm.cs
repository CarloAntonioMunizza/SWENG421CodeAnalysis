using PCBuilder.AbsFactory;
using PCBuilder.Future;
using PCBuilder.Observer;
using PCBuilder.Parts;
using PCBuilder.Wrapper;
using System.Net.Sockets;
using Socket = PCBuilder.Parts.Socket;

namespace PCBuilder
{
    public partial class BuilderForm : AbsForm
    {


        public BuilderForm(Computer computer, Inventory inventory, MainForm mainform) : base(mainform, computer, inventory)
        {
            InitializeComponent();

            MOBODisp.Text = "MotherBoard: " + computer.Mobo.ToString();
            CPUDisp.Text = "CPU: " + computer.CPU.ToString();
            SocketDisp.Text = computer.Socket == Socket.INTEL ? "Socket: Intel" : "Socket: AMD";

            IPart cpu = computer.CPU;
            while (cpu is PartWrapper wrapper)
            {
                if (wrapper.accessory is ThermalPaste)
                {
                    ThermalDisp.Text = "Thermal Paste: " + wrapper.accessory.ToString();
                }
                else if (wrapper.accessory is CPUCooler)
                {
                    CoolerDisp.Text = "CPU Cooler: " + wrapper.accessory.ToString();
                }

                cpu = wrapper.part;
            }

            SetupDropDowns();
        }


        async void SetupDropDowns()
        {


            SetupDropDown(GPUDropDown, typeof(GPU));
            SetupDropDown(CaseDropDown, typeof(Case));
            SetupDropDown(RAMDropDown, typeof(RAM));
            SetupDropDown(StoreDropDown, typeof(Storage));


        }

        async void SetupDropDown(ComboBox box, Type type) 
        {
            List<IPart> parts = await GetParts(inventory.GetPartsFromDatabase(type));

            partFutureDic.Add(type, parts);
            box.Items.AddRange(parts.Select(x => x.ToString()).ToArray());
        }

        private void StorageDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> storages = partFutureDic.GetValueOrDefault(typeof(Storage));
            computer.Storage = storages[StoreDropDown.SelectedIndex];
        }
        private void GPUDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> gpus = partFutureDic.GetValueOrDefault(typeof(GPU));
            computer.GPU = gpus[GPUDropDown.SelectedIndex];
        }
        private void RAMDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> rams = partFutureDic.GetValueOrDefault(typeof(RAM));
            computer.RAM = rams[RAMDropDown.SelectedIndex];
        }
        private void CaseDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IPart> cases = partFutureDic.GetValueOrDefault(typeof(Case));
            computer.Case = cases[CaseDropDown.SelectedIndex];
        }


        private void NextButton_Click(object sender, EventArgs e)
        { 
            if(computer.Case != null && computer.RAM != null && computer.GPU != null && computer.Storage != null)
            {
                mainform.OpenPSUForm();
                Close();
                Dispose();
            }
        }
    }
}