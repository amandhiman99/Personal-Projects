namespace Assignment_2___Pie_Chart
{
    partial class PieChartCreation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValues = new System.Windows.Forms.TextBox();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxPieChart = new System.Windows.Forms.PictureBox();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPieChart)).BeginInit();
            this.groupBoxCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(11, 39);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(263, 44);
            this.txtValues.TabIndex = 0;
            this.txtValues.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValues_KeyDown);
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 30;
            this.listBoxValues.Location = new System.Drawing.Point(11, 100);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(251, 154);
            this.listBoxValues.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(11, 272);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(220, 60);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pBoxPieChart);
            this.panel1.Location = new System.Drawing.Point(331, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 340);
            this.panel1.TabIndex = 3;
            // 
            // pBoxPieChart
            // 
            this.pBoxPieChart.BackColor = System.Drawing.Color.NavajoWhite;
            this.pBoxPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxPieChart.Location = new System.Drawing.Point(0, 0);
            this.pBoxPieChart.Name = "pBoxPieChart";
            this.pBoxPieChart.Size = new System.Drawing.Size(369, 338);
            this.pBoxPieChart.TabIndex = 0;
            this.pBoxPieChart.TabStop = false;
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.btnCreate);
            this.groupBoxCreate.Controls.Add(this.listBoxValues);
            this.groupBoxCreate.Controls.Add(this.txtValues);
            this.groupBoxCreate.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCreate.Location = new System.Drawing.Point(3, 24);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(303, 362);
            this.groupBoxCreate.TabIndex = 4;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create Pie Chart";
            // 
            // PieChartCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCreate);
            this.Controls.Add(this.panel1);
            this.Name = "PieChartCreation";
            this.Size = new System.Drawing.Size(726, 459);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPieChart)).EndInit();
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBoxPieChart;
        private System.Windows.Forms.GroupBox groupBoxCreate;
    }
}
