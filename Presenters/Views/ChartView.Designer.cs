﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewChartStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XcolumnBox = new System.Windows.Forms.ComboBox();
            this.YColumnBox = new System.Windows.Forms.ComboBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioBar = new System.Windows.Forms.RadioButton();
            this.radioPie = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackStripMenuItem
            // 
            this.BackStripMenuItem.Name = "BackStripMenuItem";
            this.BackStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.BackStripMenuItem.Text = "File";
            this.BackStripMenuItem.Click += new System.EventHandler(this.BackStripMenuItem_Click);
            // 
            // TableStripMenuItem
            // 
            this.TableStripMenuItem.Name = "TableStripMenuItem";
            this.TableStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.TableStripMenuItem.Text = "Table";
            this.TableStripMenuItem.Click += new System.EventHandler(this.TableStripMenuItem_Click);
            // 
            // VisualMenuItem
            // 
            this.VisualMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewChartStripMenuItem,
            this.saveButton});
            this.VisualMenuItem.Name = "VisualMenuItem";
            this.VisualMenuItem.Size = new System.Drawing.Size(107, 24);
            this.VisualMenuItem.Text = "Visualization";
            this.VisualMenuItem.Click += new System.EventHandler(this.VisualMenuItem_Click);
            // 
            // NewChartStripMenuItem
            // 
            this.NewChartStripMenuItem.Name = "NewChartStripMenuItem";
            this.NewChartStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NewChartStripMenuItem.Text = "New Chart";
            this.NewChartStripMenuItem.Click += new System.EventHandler(this.NewChartStripMenuItem_Click);
            // 
            // XcolumnBox
            // 
            this.XcolumnBox.FormattingEnabled = true;
            this.XcolumnBox.Location = new System.Drawing.Point(12, 245);
            this.XcolumnBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.XcolumnBox.Name = "XcolumnBox";
            this.XcolumnBox.Size = new System.Drawing.Size(57, 24);
            this.XcolumnBox.TabIndex = 2;
            this.XcolumnBox.SelectedIndexChanged += new System.EventHandler(this.XcolumnBox_SelectedIndexChanged);
            // 
            // YColumnBox
            // 
            this.YColumnBox.FormattingEnabled = true;
            this.YColumnBox.Location = new System.Drawing.Point(12, 293);
            this.YColumnBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YColumnBox.Name = "YColumnBox";
            this.YColumnBox.Size = new System.Drawing.Size(58, 24);
            this.YColumnBox.TabIndex = 3;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(34, 225);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(18, 16);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(34, 273);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(16, 16);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(6, 20);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(73, 28);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Display";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Checked = true;
            this.radioLine.Location = new System.Drawing.Point(20, 173);
            this.radioLine.Margin = new System.Windows.Forms.Padding(4);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(53, 20);
            this.radioLine.TabIndex = 8;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.CheckedChanged += new System.EventHandler(this.radioLine_CheckedChanged);
            // 
            // radioBar
            // 
            this.radioBar.AutoSize = true;
            this.radioBar.Location = new System.Drawing.Point(20, 145);
            this.radioBar.Margin = new System.Windows.Forms.Padding(4);
            this.radioBar.Name = "radioBar";
            this.radioBar.Size = new System.Drawing.Size(49, 20);
            this.radioBar.TabIndex = 9;
            this.radioBar.TabStop = true;
            this.radioBar.Text = "Bar";
            this.radioBar.UseVisualStyleBackColor = true;
            this.radioBar.CheckedChanged += new System.EventHandler(this.radioBar_CheckedChanged);
            // 
            // radioPie
            // 
            this.radioPie.AutoSize = true;
            this.radioPie.Location = new System.Drawing.Point(20, 201);
            this.radioPie.Margin = new System.Windows.Forms.Padding(4);
            this.radioPie.Name = "radioPie";
            this.radioPie.Size = new System.Drawing.Size(48, 20);
            this.radioPie.TabIndex = 10;
            this.radioPie.Text = "Pie";
            this.radioPie.UseVisualStyleBackColor = true;
            this.radioPie.CheckedChanged += new System.EventHandler(this.radioPie_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.chartListBox);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.radioPie);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.YColumnBox);
            this.groupBox1.Controls.Add(this.radioLine);
            this.groupBox1.Controls.Add(this.radioBar);
            this.groupBox1.Controls.Add(this.XcolumnBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 1500);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chartListBox
            // 
            this.chartListBox.FormattingEnabled = true;
            this.chartListBox.ItemHeight = 16;
            this.chartListBox.Location = new System.Drawing.Point(6, 53);
            this.chartListBox.Name = "chartListBox";
            this.chartListBox.Size = new System.Drawing.Size(73, 84);
            this.chartListBox.TabIndex = 11;
            this.chartListBox.SelectedIndexChanged += new System.EventHandler(this.chartListBox_SelectedIndexChanged);
            this.chartListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.removeChart_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(224, 26);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChartView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartView";
            this.Load += new System.EventHandler(this.ChartView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TableStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VisualMenuItem;
        private System.Windows.Forms.ComboBox XcolumnBox;
        private System.Windows.Forms.ComboBox YColumnBox;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.RadioButton radioBar;
        private System.Windows.Forms.RadioButton radioPie;
        private System.Windows.Forms.ToolStripMenuItem NewChartStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox chartListBox;
        private ToolStripMenuItem saveButton;
    }
}