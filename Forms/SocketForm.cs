using PCBuilder.Observer;
using PCBuilder.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBuilder
{
    public partial class SocketForm : AbsForm
    {

        public SocketForm(MainForm mainform, Computer computer, Inventory inventory) : base(mainform, computer, inventory)
        {
            InitializeComponent();
            computer.Socket = IntelButton.Checked ? Socket.INTEL : Socket.AMD;
        }

        private void radioButtonChanged(object sender, EventArgs e)
        {
            computer.Socket = IntelButton.Checked ? Socket.INTEL : Socket.AMD;
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            mainform.OpenCPUForm();
        }
    }
}
