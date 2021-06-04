using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Coffee_House
{
    public partial class Coffee : UserControl
    {
        public string lblName
        {
            get
            {
                return lblCoffee.Text;
            }
            set
            {
                lblCoffee.Text = value;
            }
        }
        public Coffee()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            string message = this.lblName + Environment.NewLine;
            
            if(radioButtonSmall.Checked)
            {
                message += "Size: Small" + Environment.NewLine;
            }

            else if (radioButtonMedium.Checked)
            {
                message += "Size: Medium" + Environment.NewLine;
            }

            else
            {
                message += "Size: Large" + Environment.NewLine;
            }

            message += "Sugar: " + numericUpDownSugar.Value.ToString() + Environment.NewLine;
            message += "Cream: " + numericUpDownCream.Value.ToString() + Environment.NewLine;

            message += "Whipped Cream: " + (checkBoxWhipCream.Checked ? "Yes" : "No") + Environment.NewLine;
            return message;
        }
        private void Coffee_Load(object sender, EventArgs e)
        {

        }
    }
}
