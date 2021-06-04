namespace Assignment_2___Pie_Chart
{
    partial class PieChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pieChartCreation1 = new Assignment_2___Pie_Chart.PieChartCreation();
            this.SuspendLayout();
            // 
            // pieChartCreation1
            // 
            this.pieChartCreation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartCreation1.Location = new System.Drawing.Point(0, 0);
            this.pieChartCreation1.Name = "pieChartCreation1";
            this.pieChartCreation1.Size = new System.Drawing.Size(740, 405);
            this.pieChartCreation1.TabIndex = 0;
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(740, 405);
            this.Controls.Add(this.pieChartCreation1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PieChart";
            this.Text = "Pie Chart";
            this.ResumeLayout(false);

        }

        #endregion

        private PieChartCreation pieChartCreation1;
    }
}

