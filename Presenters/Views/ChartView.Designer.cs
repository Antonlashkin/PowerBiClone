
namespace Presenters.Views
{
    partial class ChartView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XcolumnBox = new System.Windows.Forms.ComboBox();
            this.YColumnBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(168, 26);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(422, 329);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackStripMenuItem,
            this.TableStripMenuItem,
            this.VisualMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackStripMenuItem
            // 
            this.BackStripMenuItem.Name = "BackStripMenuItem";
            this.BackStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.BackStripMenuItem.Text = "Back";
            this.BackStripMenuItem.Click += new System.EventHandler(this.BackStripMenuItem_Click);
            // 
            // TableStripMenuItem
            // 
            this.TableStripMenuItem.Name = "TableStripMenuItem";
            this.TableStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.TableStripMenuItem.Text = "Table";
            this.TableStripMenuItem.Click += new System.EventHandler(this.TableStripMenuItem_Click);
            // 
            // VisualMenuItem
            // 
            this.VisualMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateStripMenuItem});
            this.VisualMenuItem.Name = "VisualMenuItem";
            this.VisualMenuItem.Size = new System.Drawing.Size(85, 22);
            this.VisualMenuItem.Text = "Visualization";
            this.VisualMenuItem.Click += new System.EventHandler(this.VisualMenuItem_Click);
            // 
            // UpdateStripMenuItem
            // 
            this.UpdateStripMenuItem.Name = "UpdateStripMenuItem";
            this.UpdateStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.UpdateStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.UpdateStripMenuItem.Text = "Save";
            this.UpdateStripMenuItem.Click += new System.EventHandler(this.UpdateStripMenuItem_Click);
            // 
            // XcolumnBox
            // 
            this.XcolumnBox.FormattingEnabled = true;
            this.XcolumnBox.Location = new System.Drawing.Point(9, 49);
            this.XcolumnBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.XcolumnBox.Name = "XcolumnBox";
            this.XcolumnBox.Size = new System.Drawing.Size(58, 21);
            this.XcolumnBox.TabIndex = 2;
            this.XcolumnBox.SelectedIndexChanged += new System.EventHandler(this.XcolumnBox_SelectedIndexChanged);
            // 
            // YColumnBox
            // 
            this.YColumnBox.FormattingEnabled = true;
            this.YColumnBox.Location = new System.Drawing.Point(86, 49);
            this.YColumnBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.YColumnBox.Name = "YColumnBox";
            this.YColumnBox.Size = new System.Drawing.Size(61, 21);
            this.YColumnBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 83);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Line";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 178);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pie";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YColumnBox);
            this.Controls.Add(this.XcolumnBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChartView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartView";
            this.Load += new System.EventHandler(this.ChartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VisualMenuItem;
        private System.Windows.Forms.ComboBox XcolumnBox;
        private System.Windows.Forms.ComboBox YColumnBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem UpdateStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}