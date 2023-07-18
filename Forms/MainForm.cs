using Microsoft.VisualBasic.Devices;
using PCBuilder.Forms;
using PCBuilder.Observer;
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
    public partial class MainForm : Form, IObserver
    {
        internal Parts.Socket socket;
        internal Inventory? inventory;
        internal Parts.Computer? computer;

        MainForm? mainform;
        WishListForm? wishlistform;
        SocketForm? socketform;
        CPUForm? cpuform;
        BuilderForm? builderform;
        PSUForm? psuform;
        DisplayForm? displayform;
        private Wishlist wishlist;

        public MainForm()
        {
            InitializeComponent();
            inventory = new Inventory();
            computer = new Parts.Computer();
            wishlist = new Wishlist();
            wishlist.AddObserver(this);
            wishlist.SetInventory(inventory);
        }

        private void WishListButton_Click(object sender, EventArgs e)
        {
            OpenWishListForm();
        }

        private void Choosebutton_Click(object sender, EventArgs e)
        {
            OpenSocketForm();
        }

        internal void OpenSocketForm()
        {
            Console.WriteLine("Socket");
            socketform = new SocketForm(this, computer, inventory);
            socketform.Show();
            Hide();
        }

        internal void OpenCPUForm()
        {
            cpuform = new CPUForm(computer, inventory, this);
            cpuform.Show();
            socketform.Close();
        }

        internal void OpenBuilderForm()
        {
            builderform = new BuilderForm(computer, inventory, this);
            builderform.Show();
            cpuform.Close();
        }

        internal void OpenPSUForm()
        {
            psuform = new PSUForm(computer, inventory, this);
            psuform.Show();
            builderform.Close();
        }

        internal void OpenDisplayForm()
        {
            displayform = new DisplayForm(computer, inventory, this);
            displayform.Show();
            psuform.Close();
        }

        internal void OpenWishListForm()
        {
            wishlistform = new WishListForm(this, inventory, wishlist);

            wishlistform.Show();
            Hide();
        }

        internal void OpenMainFormFromWish()
        {
            Show();
            wishlistform.Close();
        }

        internal void OpenMainFormFromDisp()
        {
            Show();
            displayform.Close();
        }

        public void Notify()
        {
            Form popup = new InStockPopup(wishlist);
            popup.Show();
        }

        void ImportButton_Click(object s, EventArgs e)
        {
            inventory.ImportNewParts();
        }
    }
}
