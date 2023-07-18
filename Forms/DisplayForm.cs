using Microsoft.VisualBasic.Devices;
using PCBuilder.Observer;
using PCBuilder.Parts;
using PCBuilder.Wrapper;
using System;
using Computer = PCBuilder.Parts.Computer;
using Socket = PCBuilder.Parts.Socket;

namespace PCBuilder
{
    public partial class DisplayForm : AbsForm
    {
        PartAccessory part;

        public DisplayForm(Computer computer, Inventory inventory, MainForm mainform) : base(mainform, computer, inventory)
        {
            InitializeComponent();

            if (computer.Socket == Socket.AMD)
                SocketDisp.Text = "Socket: AMD";
            if (computer.Socket == Socket.INTEL)
                SocketDisp.Text = "Socket: INTEL";

            PSUDisp.Text = "PSU: " + computer.PSU;
            CPUDisp.Text = "CPU: " + computer.CPU;
            GPUlabel.Text = "GPU: " + computer.GPU;

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

            RAMlabel.Text = "RAM: " + computer.RAM;



            Storelabel.Text = "Store: " + computer.Storage;
            MOBODisp.Text = "Motherboard: " + computer.Mobo;
            Caselabel.Text = "Case: " + computer.Case;

            if (computer.Socket == Socket.INTEL)
                SLIlabel.Text = "Can Support SLI: No";
            if (computer.Socket == Socket.AMD)
                SLIlabel.Text = "Can Support SLI: Yes";

            PriceDisp.Text = "Price: " + computer.GetTotalCost();
            WattDisp.Text = "Wattage: " + computer.GetTotalWattage();

        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            mainform.OpenMainFormFromDisp();
            Close();
            Dispose();
        }
    }
}
