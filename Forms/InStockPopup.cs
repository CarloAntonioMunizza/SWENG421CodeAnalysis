using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBuilder.Observer;

namespace PCBuilder.Forms
{
    public partial class InStockPopup : Form
    {
        public InStockPopup(Wishlist wishlist)
        {
            InitializeComponent();

            string itemsInStock = "";

            wishlist.WishListInStock.ForEach(x => itemsInStock += x.ToString() + "\n");

            label2.Text = itemsInStock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
