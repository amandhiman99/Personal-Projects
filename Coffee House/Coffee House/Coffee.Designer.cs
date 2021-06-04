namespace Coffee_House
{
    partial class Coffee
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
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.groupBoxExtra = new System.Windows.Forms.GroupBox();
            this.numericUpDownCream = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWhipCream = new System.Windows.Forms.CheckBox();
            this.numericUpDownSugar = new System.Windows.Forms.NumericUpDown();
            this.lblCream = new System.Windows.Forms.Label();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.radioButtonLarge);
            this.groupBoxSize.Controls.Add(this.radioButtonMedium);
            this.groupBoxSize.Controls.Add(this.radioButtonSmall);
            this.groupBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSize.Location = new System.Drawing.Point(31, 60);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(226, 245);
            this.groupBoxSize.TabIndex = 0;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size:";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(6, 157);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(112, 40);
            this.radioButtonLarge.TabIndex = 2;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "Large";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(6, 103);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(141, 40);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(6, 49);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(109, 40);
            this.radioButtonSmall.TabIndex = 0;
            this.radioButtonSmall.TabStop = true;
            this.radioButtonSmall.Text = "Small";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // groupBoxExtra
            // 
            this.groupBoxExtra.Controls.Add(this.numericUpDownCream);
            this.groupBoxExtra.Controls.Add(this.checkBoxWhipCream);
            this.groupBoxExtra.Controls.Add(this.numericUpDownSugar);
            this.groupBoxExtra.Controls.Add(this.lblCream);
            this.groupBoxExtra.Controls.Add(this.lblSugar);
            this.groupBoxExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExtra.Location = new System.Drawing.Point(314, 60);
            this.groupBoxExtra.Name = "groupBoxExtra";
            this.groupBoxExtra.Size = new System.Drawing.Size(267, 205);
            this.groupBoxExtra.TabIndex = 1;
            this.groupBoxExtra.TabStop = false;
            this.groupBoxExtra.Text = "Extra:";
            // 
            // numericUpDownCream
            // 
            this.numericUpDownCream.Location = new System.Drawing.Point(149, 101);
            this.numericUpDownCream.Name = "numericUpDownCream";
            this.numericUpDownCream.Size = new System.Drawing.Size(83, 41);
            this.numericUpDownCream.TabIndex = 4;
            // 
            // checkBoxWhipCream
            // 
            this.checkBoxWhipCream.AutoSize = true;
            this.checkBoxWhipCream.Location = new System.Drawing.Point(10, 157);
            this.checkBoxWhipCream.Name = "checkBoxWhipCream";
            this.checkBoxWhipCream.Size = new System.Drawing.Size(251, 40);
            this.checkBoxWhipCream.TabIndex = 3;
            this.checkBoxWhipCream.Text = "Whipped Cream";
            this.checkBoxWhipCream.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSugar
            // 
            this.numericUpDownSugar.Location = new System.Drawing.Point(149, 47);
            this.numericUpDownSugar.Name = "numericUpDownSugar";
            this.numericUpDownSugar.Size = new System.Drawing.Size(83, 41);
            this.numericUpDownSugar.TabIndex = 2;
            // 
            // lblCream
            // 
            this.lblCream.AutoSize = true;
            this.lblCream.Location = new System.Drawing.Point(16, 103);
            this.lblCream.Name = "lblCream";
            this.lblCream.Size = new System.Drawing.Size(101, 36);
            this.lblCream.TabIndex = 1;
            this.lblCream.Text = "Cream";
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Location = new System.Drawing.Point(16, 49);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(95, 36);
            this.lblSugar.TabIndex = 0;
            this.lblSugar.Text = "Sugar";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(200, 13);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(132, 44);
            this.lblCoffee.TabIndex = 2;
            this.lblCoffee.Text = "Coffee";
            // 
            // Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.groupBoxExtra);
            this.Controls.Add(this.groupBoxSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Coffee";
            this.Size = new System.Drawing.Size(597, 291);
            this.Load += new System.EventHandler(this.Coffee_Load);
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxExtra.ResumeLayout(false);
            this.groupBoxExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.GroupBox groupBoxExtra;
        private System.Windows.Forms.NumericUpDown numericUpDownSugar;
        private System.Windows.Forms.Label lblCream;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.NumericUpDown numericUpDownCream;
        private System.Windows.Forms.CheckBox checkBoxWhipCream;
        private System.Windows.Forms.Label lblCoffee;
    }
}
