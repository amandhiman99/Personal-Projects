using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_House
{
    public partial class Container : UserControl
    {
        List<UserControl> userControlsList;
        private int coffeeCount = 0;
        private int donutCount = 0;

        private int y = 0;
        
        public Container()
        {
            InitializeComponent();
        }

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Clear()
        {
            while(pnlControl.Controls.Count > 0)
            {
                pnlControl.Controls.RemoveAt(0);
            }

            userControlsList = new List<UserControl>();
            y = donutCount = coffeeCount = 0;
        }

     

        private void Container_Load_1(object sender, EventArgs e)
        {
            pnlControl.AutoScroll = true;
            userControlsList = new List<UserControl>();
        }
        

        public void AddCoffee()
        {
            coffeeCount++;

            Coffee coffee = new Coffee();

            coffee.lblName = "Cofee" + coffeeCount.ToString();

            coffee.Name = "Coffee" + coffeeCount.ToString();
            coffee.Location = new Point(0, y - pnlControl.VerticalScroll.Value);

            userControlsList.Add(coffee);

            pnlControl.Controls.Add(coffee);
            y += 222;


        }

        public void AddDonuts()
        {
            donutCount++;

            Donut donut = new Donut();

            donut.lblName = "Donut" + donutCount.ToString();

            donut.Name = "Donut" + donutCount.ToString();

            donut.Location = new Point(0, y - pnlControl.VerticalScroll.Value);

            y += 150;
            userControlsList.Add(donut);

            pnlControl.Controls.Add(donut);

        }

        public override string ToString()
        {
            string message = string.Empty;

            foreach(UserControl userControl in userControlsList)
            {
                message += userControl.ToString();
            }
            return message;
        }
    }
}
