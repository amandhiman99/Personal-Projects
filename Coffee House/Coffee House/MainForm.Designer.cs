namespace Coffee_House
{
    partial class CoffeeShop
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
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnDonut = new System.Windows.Forms.Button();
            this.pnlReciept = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.userControlContainer = new Coffee_House.Container();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlReciept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoffee
            // 
            this.btnCoffee.Location = new System.Drawing.Point(34, 22);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(149, 49);
            this.btnCoffee.TabIndex = 0;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnDonut
            // 
            this.btnDonut.Location = new System.Drawing.Point(189, 22);
            this.btnDonut.Name = "btnDonut";
            this.btnDonut.Size = new System.Drawing.Size(149, 49);
            this.btnDonut.TabIndex = 1;
            this.btnDonut.Text = "Donut";
            this.btnDonut.UseVisualStyleBackColor = true;
            this.btnDonut.Click += new System.EventHandler(this.btnDonut_Click);
            // 
            // pnlReciept
            // 
            this.pnlReciept.Controls.Add(this.txtOrder);
            this.pnlReciept.Controls.Add(this.pnlLine);
            this.pnlReciept.Controls.Add(this.pictureBoxLogo);
            this.pnlReciept.Location = new System.Drawing.Point(769, 12);
            this.pnlReciept.Name = "pnlReciept";
            this.pnlReciept.Size = new System.Drawing.Size(223, 475);
            this.pnlReciept.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(46, 14);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 72);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlLine.Location = new System.Drawing.Point(5, 113);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(217, 14);
            this.pnlLine.TabIndex = 1;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(11, 141);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(201, 319);
            this.txtOrder.TabIndex = 2;
            // 
            // userControlContainer
            // 
            this.userControlContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlContainer.Location = new System.Drawing.Point(33, 102);
            this.userControlContainer.Margin = new System.Windows.Forms.Padding(8);
            this.userControlContainer.Name = "userControlContainer";
            this.userControlContainer.Size = new System.Drawing.Size(657, 399);
            this.userControlContainer.TabIndex = 5;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(344, 22);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(149, 49);
            this.btnPurchase.TabIndex = 6;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(499, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 49);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 510);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.userControlContainer);
            this.Controls.Add(this.pnlReciept);
            this.Controls.Add(this.btnDonut);
            this.Controls.Add(this.btnCoffee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.CoffeeShop_Load);
            this.pnlReciept.ResumeLayout(false);
            this.pnlReciept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnDonut;
        private System.Windows.Forms.Panel pnlReciept;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Container userControlContainer;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnClear;
    }
}

