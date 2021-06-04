using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace Assignment_2___Pie_Chart
{
    public partial class PieChartCreation : UserControl
    {
        public PieChartCreation()
        {
            InitializeComponent();
        }

        float Total = 0.0f;
        int[] PieValues = null;
        int valueCount = 0;

        private void txtValues_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if(valueCount  < 6)
                {
                    listBoxValues.Items.Add(txtValues.Text);
                    txtValues.Text = "";
                    valueCount = listBoxValues.Items.Count;
                }
                else
                {
                    txtValues.Text = "";

                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                createPieChart();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createPieChart()
        {
            PieValues = new int[valueCount];

            for(int i = 0; i < valueCount; i++)
            {
               PieValues[i] = int.Parse(listBoxValues.Items[i].ToString());
                Total += PieValues[i];
            }

            Color[] colors = { Color.Aquamarine, Color.CornflowerBlue, Color.DodgerBlue, Color.Red, Color.Green };
            Rectangle rectangle = new Rectangle(30, 10, 130, 130);

            Graphics graphics = pBoxPieChart.CreateGraphics();
            graphics.Clear(pBoxPieChart.BackColor);

            float degSum = 0.0f;
            float degValue = 0.0f;

            for(int i = 0; i < PieValues.Length; i++)
            {
                degValue = (PieValues[i] / Total) * 360;

                Brush brush = new SolidBrush(colors[i]);

                graphics.FillPie(brush, rectangle, degSum, degValue);
                degSum += degValue;
                

            }

        }

       
    }
}
