using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_House
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            userControlContainer.AddCoffee();
        }

        private void btnDonut_Click(object sender, EventArgs e)
        {
            userControlContainer.AddDonuts();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            txtOrder.Text = userControlContainer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrder.Text = string.Empty;
            userControlContainer.Clear();
        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Image.FromFile("coffee.png"));
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.Image = bitmap;
        }
    }
}
