namespace ImageProcessing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBSeperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxFilters = new System.Windows.Forms.GroupBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.radbtnUnsharpFilter = new System.Windows.Forms.RadioButton();
            this.radbtnSharpFilter = new System.Windows.Forms.RadioButton();
            this.radbtnAverageFilter = new System.Windows.Forms.RadioButton();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.picBoxSource = new System.Windows.Forms.PictureBox();
            this.picBoxFilterdImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.grpBoxFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFilterdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem,
            this.rGBSeperationToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // rGBSeperationToolStripMenuItem
            // 
            this.rGBSeperationToolStripMenuItem.Name = "rGBSeperationToolStripMenuItem";
            this.rGBSeperationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rGBSeperationToolStripMenuItem.Text = "RGB seperation";
            this.rGBSeperationToolStripMenuItem.Click += new System.EventHandler(this.rGBSeperationToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // grpBoxFilters
            // 
            this.grpBoxFilters.Controls.Add(this.btnApplyFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnUnsharpFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnSharpFilter);
            this.grpBoxFilters.Controls.Add(this.radbtnAverageFilter);
            this.grpBoxFilters.Location = new System.Drawing.Point(364, 44);
            this.grpBoxFilters.Name = "grpBoxFilters";
            this.grpBoxFilters.Size = new System.Drawing.Size(342, 83);
            this.grpBoxFilters.TabIndex = 3;
            this.grpBoxFilters.TabStop = false;
            this.grpBoxFilters.Visible = false;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(261, 14);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(75, 63);
            this.btnApplyFilter.TabIndex = 1;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // radbtnUnsharpFilter
            // 
            this.radbtnUnsharpFilter.AutoSize = true;
            this.radbtnUnsharpFilter.Location = new System.Drawing.Point(6, 57);
            this.radbtnUnsharpFilter.Name = "radbtnUnsharpFilter";
            this.radbtnUnsharpFilter.Size = new System.Drawing.Size(92, 17);
            this.radbtnUnsharpFilter.TabIndex = 0;
            this.radbtnUnsharpFilter.TabStop = true;
            this.radbtnUnsharpFilter.Text = "Unsharp Filter";
            this.radbtnUnsharpFilter.UseVisualStyleBackColor = true;
            // 
            // radbtnSharpFilter
            // 
            this.radbtnSharpFilter.AutoSize = true;
            this.radbtnSharpFilter.Location = new System.Drawing.Point(6, 34);
            this.radbtnSharpFilter.Name = "radbtnSharpFilter";
            this.radbtnSharpFilter.Size = new System.Drawing.Size(106, 17);
            this.radbtnSharpFilter.TabIndex = 0;
            this.radbtnSharpFilter.TabStop = true;
            this.radbtnSharpFilter.Text = "Sharpening Filter";
            this.radbtnSharpFilter.UseVisualStyleBackColor = true;
            // 
            // radbtnAverageFilter
            // 
            this.radbtnAverageFilter.AutoSize = true;
            this.radbtnAverageFilter.Location = new System.Drawing.Point(7, 11);
            this.radbtnAverageFilter.Name = "radbtnAverageFilter";
            this.radbtnAverageFilter.Size = new System.Drawing.Size(93, 17);
            this.radbtnAverageFilter.TabIndex = 0;
            this.radbtnAverageFilter.TabStop = true;
            this.radbtnAverageFilter.Text = "Average Filter";
            this.radbtnAverageFilter.UseVisualStyleBackColor = true;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(364, 133);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(342, 23);
            this.btnLoadImage.TabIndex = 4;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Visible = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // picBoxSource
            // 
            this.picBoxSource.Location = new System.Drawing.Point(4, 162);
            this.picBoxSource.Name = "picBoxSource";
            this.picBoxSource.Size = new System.Drawing.Size(460, 385);
            this.picBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSource.TabIndex = 5;
            this.picBoxSource.TabStop = false;
            // 
            // picBoxFilterdImage
            // 
            this.picBoxFilterdImage.Location = new System.Drawing.Point(516, 162);
            this.picBoxFilterdImage.Name = "picBoxFilterdImage";
            this.picBoxFilterdImage.Size = new System.Drawing.Size(460, 385);
            this.picBoxFilterdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFilterdImage.TabIndex = 6;
            this.picBoxFilterdImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 571);
            this.Controls.Add(this.picBoxFilterdImage);
            this.Controls.Add(this.picBoxSource);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.grpBoxFilters);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxFilters.ResumeLayout(false);
            this.grpBoxFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFilterdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBSeperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxFilters;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.RadioButton radbtnUnsharpFilter;
        private System.Windows.Forms.RadioButton radbtnSharpFilter;
        private System.Windows.Forms.RadioButton radbtnAverageFilter;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox picBoxSource;
        private System.Windows.Forms.PictureBox picBoxFilterdImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

