namespace Coffee_House
{
    partial class Donut
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
            this.lblDonut = new System.Windows.Forms.Label();
            this.numericUpDownDonut = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDonut
            // 
            this.lblDonut.AutoSize = true;
            this.lblDonut.Location = new System.Drawing.Point(114, 14);
            this.lblDonut.Name = "lblDonut";
            this.lblDonut.Size = new System.Drawing.Size(121, 44);
            this.lblDonut.TabIndex = 0;
            this.lblDonut.Text = "Donut";
            // 
            // numericUpDownDonut
            // 
            this.numericUpDownDonut.Location = new System.Drawing.Point(192, 67);
            this.numericUpDownDonut.Name = "numericUpDownDonut";
            this.numericUpDownDonut.Size = new System.Drawing.Size(190, 49);
            this.numericUpDownDonut.TabIndex = 2;
            this.numericUpDownDonut.ValueChanged += new System.EventHandler(this.numericUpDownDonut_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 67);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(163, 44);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // Donut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numericUpDownDonut);
            this.Controls.Add(this.lblDonut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Donut";
            this.Size = new System.Drawing.Size(385, 145);
            this.Load += new System.EventHandler(this.Donut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDonut;
        private System.Windows.Forms.NumericUpDown numericUpDownDonut;
        private System.Windows.Forms.Label lblQuantity;
    }
}
