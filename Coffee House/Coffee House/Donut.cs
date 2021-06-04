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
    public partial class Donut : UserControl
    {
        public Donut()
        {
            InitializeComponent();
        }

        public string lblName       
        {
            get
            {
                return lblDonut.Text;
            }
            set
            {
                lblDonut.Text = value;
            }
        }

        public override string ToString()
        {
            return this.lblName + Environment.NewLine + "Donuts: " + numericUpDownDonut.Value.ToString() + Environment.NewLine;
        }

        private void numericUpDownDonut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            if (numericUpDown.Value.Equals(0))
            {
                numericUpDown.Value = 1;
            }

            else if (numericUpDown.Value.Equals(2))
            {
                numericUpDown.Value = 6;
            }

            else if (numericUpDown.Value.Equals(7))
            {
                numericUpDown.Value = 12;
            }
            else if (numericUpDown.Value.Equals(13))
            {
                numericUpDown.Value = 24;
            }
            else if (numericUpDown.Value.Equals(25))
            {
                numericUpDown.Value = 24;
            }
            else if (numericUpDown.Value.Equals(23))
            {
                numericUpDown.Value = 12;
            }
            else if (numericUpDown.Value.Equals(11))
            {
                numericUpDown.Value = 6;
            }
            else if (numericUpDown.Value.Equals(5))
            {
                numericUpDown.Value = 1;
            }
        }

        private void Donut_Load(object sender, EventArgs e)
        {
            numericUpDownDonut.Value = 1; 
        }
    }
}
