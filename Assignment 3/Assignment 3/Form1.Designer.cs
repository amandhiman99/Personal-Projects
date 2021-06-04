
namespace Assignment_3
{
    partial class Form1
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.SelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.GBStatistics = new System.Windows.Forms.GroupBox();
            this.lblAssists = new System.Windows.Forms.Label();
            this.lblGoals = new System.Windows.Forms.Label();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.selectedPictureBox2 = new System.Windows.Forms.PictureBox();
            this.GBStatistics2 = new System.Windows.Forms.GroupBox();
            this.labelAssists = new System.Windows.Forms.Label();
            this.labelGoals = new System.Windows.Forms.Label();
            this.labelMatches = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnStats2 = new System.Windows.Forms.Button();
            this.btnStats1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPictureBox)).BeginInit();
            this.GBStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox2)).BeginInit();
            this.GBStatistics2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(348, 381);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(528, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(727, 381);
            this.dgvData.TabIndex = 1;
            // 
            // SelectedPictureBox
            // 
            this.SelectedPictureBox.Location = new System.Drawing.Point(17, 515);
            this.SelectedPictureBox.Name = "SelectedPictureBox";
            this.SelectedPictureBox.Size = new System.Drawing.Size(343, 306);
            this.SelectedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectedPictureBox.TabIndex = 2;
            this.SelectedPictureBox.TabStop = false;
            // 
            // GBStatistics
            // 
            this.GBStatistics.Controls.Add(this.lblAssists);
            this.GBStatistics.Controls.Add(this.lblGoals);
            this.GBStatistics.Controls.Add(this.lblMatches);
            this.GBStatistics.Controls.Add(this.lblCountry);
            this.GBStatistics.Controls.Add(this.lblName);
            this.GBStatistics.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBStatistics.Location = new System.Drawing.Point(396, 515);
            this.GBStatistics.Name = "GBStatistics";
            this.GBStatistics.Size = new System.Drawing.Size(247, 314);
            this.GBStatistics.TabIndex = 4;
            this.GBStatistics.TabStop = false;
            this.GBStatistics.Text = "Statistics";
            // 
            // lblAssists
            // 
            this.lblAssists.AutoSize = true;
            this.lblAssists.ForeColor = System.Drawing.Color.Red;
            this.lblAssists.Location = new System.Drawing.Point(16, 191);
            this.lblAssists.Name = "lblAssists";
            this.lblAssists.Size = new System.Drawing.Size(73, 24);
            this.lblAssists.TabIndex = 4;
            this.lblAssists.Text = "label5";
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.ForeColor = System.Drawing.Color.Red;
            this.lblGoals.Location = new System.Drawing.Point(16, 156);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(75, 24);
            this.lblGoals.TabIndex = 3;
            this.lblGoals.Text = "label4";
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.ForeColor = System.Drawing.Color.Red;
            this.lblMatches.Location = new System.Drawing.Point(16, 118);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(73, 24);
            this.lblMatches.TabIndex = 2;
            this.lblMatches.Text = "label3";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.Red;
            this.lblCountry.Location = new System.Drawing.Point(16, 79);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(74, 24);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(16, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(12, 409);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(157, 37);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(192, 409);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 37);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // selectedPictureBox2
            // 
            this.selectedPictureBox2.Location = new System.Drawing.Point(683, 523);
            this.selectedPictureBox2.Name = "selectedPictureBox2";
            this.selectedPictureBox2.Size = new System.Drawing.Size(343, 306);
            this.selectedPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedPictureBox2.TabIndex = 7;
            this.selectedPictureBox2.TabStop = false;
            // 
            // GBStatistics2
            // 
            this.GBStatistics2.Controls.Add(this.labelAssists);
            this.GBStatistics2.Controls.Add(this.labelGoals);
            this.GBStatistics2.Controls.Add(this.labelMatches);
            this.GBStatistics2.Controls.Add(this.labelCountry);
            this.GBStatistics2.Controls.Add(this.labelName);
            this.GBStatistics2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBStatistics2.Location = new System.Drawing.Point(1067, 523);
            this.GBStatistics2.Name = "GBStatistics2";
            this.GBStatistics2.Size = new System.Drawing.Size(247, 314);
            this.GBStatistics2.TabIndex = 8;
            this.GBStatistics2.TabStop = false;
            this.GBStatistics2.Text = "Statistics";
            // 
            // labelAssists
            // 
            this.labelAssists.AutoSize = true;
            this.labelAssists.ForeColor = System.Drawing.Color.Red;
            this.labelAssists.Location = new System.Drawing.Point(16, 191);
            this.labelAssists.Name = "labelAssists";
            this.labelAssists.Size = new System.Drawing.Size(79, 27);
            this.labelAssists.TabIndex = 4;
            this.labelAssists.Text = "label5";
            // 
            // labelGoals
            // 
            this.labelGoals.AutoSize = true;
            this.labelGoals.ForeColor = System.Drawing.Color.Red;
            this.labelGoals.Location = new System.Drawing.Point(16, 156);
            this.labelGoals.Name = "labelGoals";
            this.labelGoals.Size = new System.Drawing.Size(81, 27);
            this.labelGoals.TabIndex = 3;
            this.labelGoals.Text = "label4";
            // 
            // labelMatches
            // 
            this.labelMatches.AutoSize = true;
            this.labelMatches.ForeColor = System.Drawing.Color.Red;
            this.labelMatches.Location = new System.Drawing.Point(16, 118);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(79, 27);
            this.labelMatches.TabIndex = 2;
            this.labelMatches.Text = "label3";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.ForeColor = System.Drawing.Color.Red;
            this.labelCountry.Location = new System.Drawing.Point(16, 79);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(79, 27);
            this.labelCountry.TabIndex = 1;
            this.labelCountry.Text = "label2";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Red;
            this.labelName.Location = new System.Drawing.Point(16, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 27);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // btnStats2
            // 
            this.btnStats2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats2.Location = new System.Drawing.Point(1067, 462);
            this.btnStats2.Name = "btnStats2";
            this.btnStats2.Size = new System.Drawing.Size(124, 37);
            this.btnStats2.TabIndex = 9;
            this.btnStats2.Text = "Stats 2\r\n";
            this.btnStats2.UseVisualStyleBackColor = true;
            this.btnStats2.Click += new System.EventHandler(this.btnStats2_Click);
            // 
            // btnStats1
            // 
            this.btnStats1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats1.Location = new System.Drawing.Point(396, 462);
            this.btnStats1.Name = "btnStats1";
            this.btnStats1.Size = new System.Drawing.Size(124, 37);
            this.btnStats1.TabIndex = 10;
            this.btnStats1.Text = "Stats 1\r\n";
            this.btnStats1.UseVisualStyleBackColor = true;
            this.btnStats1.Click += new System.EventHandler(this.btnStats1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(105, 472);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 37);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.GenerateCards);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 861);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStats1);
            this.Controls.Add(this.btnStats2);
            this.Controls.Add(this.GBStatistics2);
            this.Controls.Add(this.selectedPictureBox2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.GBStatistics);
            this.Controls.Add(this.SelectedPictureBox);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "Form1";
            this.Text = "Football Players Stats";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPictureBox)).EndInit();
            this.GBStatistics.ResumeLayout(false);
            this.GBStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureBox2)).EndInit();
            this.GBStatistics2.ResumeLayout(false);
            this.GBStatistics2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.PictureBox SelectedPictureBox;
        private System.Windows.Forms.GroupBox GBStatistics;
        private System.Windows.Forms.Label lblAssists;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox selectedPictureBox2;
        private System.Windows.Forms.GroupBox GBStatistics2;
        private System.Windows.Forms.Label labelAssists;
        private System.Windows.Forms.Label labelGoals;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnStats2;
        private System.Windows.Forms.Button btnStats1;
        private System.Windows.Forms.Button btnStart;
    }
}

