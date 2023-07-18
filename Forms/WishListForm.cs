using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBuilder.Future;
using PCBuilder.Observer;
using PCBuilder.Parts;

namespace PCBuilder
{
    public partial class WishListForm : Form
    {
        MainForm mainForm;
        Inventory inventory;
        Wishlist wishlist;
        Dictionary<Type, List<IPart>> partFutureDic;
        public WishListForm(MainForm main, Inventory inventory, Wishlist wishlist)
        {
            InitializeComponent();
            mainForm = main;
            partFutureDic = new Dictionary<Type, List<IPart>>();
            this.inventory = inventory;
            this.wishlist = wishlist;
            InitializeBoxes();
        
        }

        async void InitializeBoxes()
        {


            InitializeBox(CPUListBox, typeof(IntelCPU));
            InitializeBox(CPUListBox, typeof(AMDCPU));
            InitializeBox(MOBOListBox, typeof(IntelMotherboard));
            InitializeBox(MOBOListBox, typeof(AMDMotherboard));
            InitializeBox(PSUListBox, typeof(PSU));
            InitializeBox(StorageListBox, typeof(Storage));
            InitializeBox(RAMListBox, typeof(RAM));
            InitializeBox(CaseListBox, typeof(Case));
            InitializeBox(GPUListBox, typeof(GPU));

        }

        async void InitializeBox(CheckedListBox box, Type type)
        {
            PartsFuture partFuture = inventory.GetPartsNotInStock(type);
            List<IPart> parts = await GetParts(partFuture);

            if (type.IsSubclassOf(typeof(CPU)))
            {
                if(!partFutureDic.TryAdd(typeof(CPU), parts))
                {
                    partFutureDic.GetValueOrDefault(typeof(CPU), null).AddRange(parts);
                }
            }
            else if (type.IsSubclassOf(typeof(Motherboard))) {
                if (!partFutureDic.TryAdd(typeof(Motherboard), parts))
                {
                    partFutureDic.GetValueOrDefault(typeof(Motherboard), null).AddRange(parts);
                }
            }
            else
            {
                partFutureDic.Add(type, parts);
            }
        
            box.Items.AddRange(parts.Select(x => x.ToString()).ToArray());
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
            Dispose();
        }

        async Task<List<IPart>> GetParts(PartsFuture future)
        {
            while (!future.IsCompleted())
            {
                await Task.Delay(10);
            }
            return future.GetParts();
        }

        void ItemCheck(object sender, ItemCheckEventArgs e)
        {

            HandleItemCheckAsync(sender, e);
        }

        async void HandleItemCheckAsync(object sender, ItemCheckEventArgs e)
        {
            Console.WriteLine("Handling Item check");
            CheckedListBox listbox = (CheckedListBox)sender;
            Type type = null;
            switch (listbox.Name)
            {
                case "CPUListBox":
                    type = typeof(CPU);
                    break;
                case "MOBOListBox":
                    type = typeof(Motherboard);
                    break;
                case "PSUListBox":
                    type = typeof(PSU);
                    break;
                case "StorageListBox":
                    type = typeof(Storage);
                    break;
                case "RAMListBox":
                    type = typeof(RAM);
                    break;
                case "CaseListBox":
                    type = typeof(Case);
                    break;
                case "GPUListBox":
                    type = typeof(GPU);
                    break;
            }

            List<IPart> parts = partFutureDic.GetValueOrDefault(type);

            IPart partChanged = parts[e.Index];

            if(e.NewValue == CheckState.Checked)
            {
                wishlist.AddToWishlist(partChanged);
            }
            else
            {
                wishlist.RemoveFromWishlist(partChanged);
            }
        }

    
    }
}
