using System;
using System.Windows.Forms;

namespace Presenters.Views
{
    partial class TableVisualizationView
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
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.showTable = new System.Windows.Forms.Button();
            this.removeRow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisualStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.ValueMoreThen = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.ValueLessThen = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.RemoveColoumnButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.AddColoumnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(203, 37);
            this.dataTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataTable.Size = new System.Drawing.Size(585, 402);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableView_CellContentClick);
            this.dataTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.changeValue_click);
            // 
            // showTable
            // 
            this.showTable.Location = new System.Drawing.Point(12, 37);
            this.showTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(185, 49);
            this.showTable.TabIndex = 2;
            this.showTable.Text = "Show Table";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // removeRow
            // 
            this.removeRow.Location = new System.Drawing.Point(12, 91);
            this.removeRow.Name = "removeRow";
            this.removeRow.Size = new System.Drawing.Size(185, 49);
            this.removeRow.TabIndex = 4;
            this.removeRow.Text = "Remove  Row";
            this.removeRow.UseVisualStyleBackColor = true;
            this.removeRow.Click += new System.EventHandler(this.removeRow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackStripMenuItem,
            this.TableStripMenuItem,
            this.VisualStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
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
            // VisualStripMenuItem2
            // 
            this.VisualStripMenuItem2.Name = "VisualStripMenuItem2";
            this.VisualStripMenuItem2.Size = new System.Drawing.Size(107, 24);
            this.VisualStripMenuItem2.Text = "Visualization";
            this.VisualStripMenuItem2.Click += new System.EventHandler(this.VisualStripMenuItem2_Click);
            // 
            // removeTableButton
            // 
            this.removeTableButton.Location = new System.Drawing.Point(12, 204);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(185, 48);
            this.removeTableButton.TabIndex = 6;
            this.removeTableButton.Text = "Remove table";
            this.removeTableButton.UseVisualStyleBackColor = true;
            this.removeTableButton.Click += new System.EventHandler(this.removeTableButton_Click);
            // 
            // ValueMoreThen
            // 
            this.ValueMoreThen.Location = new System.Drawing.Point(114, 256);
            this.ValueMoreThen.Name = "ValueMoreThen";
            this.ValueMoreThen.Size = new System.Drawing.Size(50, 25);
            this.ValueMoreThen.TabIndex = 7;
            this.ValueMoreThen.Text = "more";
            this.ValueMoreThen.UseVisualStyleBackColor = true;
            this.ValueMoreThen.Click += new System.EventHandler(this.ValueMoreThen_Click);
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(75, 259);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(33, 22);
            this.ValueBox.TabIndex = 8;
            // 
            // ValueLessThen
            // 
            this.ValueLessThen.Location = new System.Drawing.Point(20, 256);
            this.ValueLessThen.Name = "ValueLessThen";
            this.ValueLessThen.Size = new System.Drawing.Size(49, 25);
            this.ValueLessThen.TabIndex = 9;
            this.ValueLessThen.Text = "less";
            this.ValueLessThen.UseVisualStyleBackColor = true;
            this.ValueLessThen.Click += new System.EventHandler(this.ValueLessThen_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(170, 256);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(28, 25);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "X";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Visible = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // RemoveColoumnButton
            // 
            this.RemoveColoumnButton.Location = new System.Drawing.Point(12, 146);
            this.RemoveColoumnButton.Name = "RemoveColoumnButton";
            this.RemoveColoumnButton.Size = new System.Drawing.Size(185, 49);
            this.RemoveColoumnButton.TabIndex = 11;
            this.RemoveColoumnButton.Text = "Remove  Coloumn";
            this.RemoveColoumnButton.UseVisualStyleBackColor = true;
            this.RemoveColoumnButton.Click += new System.EventHandler(this.RemoveColoumnButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(12, 307);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(87, 48);
            this.AddRowButton.TabIndex = 12;
            this.AddRowButton.Text = "Add row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // AddColoumnButton
            // 
            this.AddColoumnButton.Location = new System.Drawing.Point(114, 307);
            this.AddColoumnButton.Name = "AddColoumnButton";
            this.AddColoumnButton.Size = new System.Drawing.Size(80, 48);
            this.AddColoumnButton.TabIndex = 13;
            this.AddColoumnButton.Text = "Add col";
            this.AddColoumnButton.UseVisualStyleBackColor = true;
            this.AddColoumnButton.Click += new System.EventHandler(this.AddColoumnButton_Click);
            // 
            // TableVisualizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddColoumnButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.RemoveColoumnButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.ValueLessThen);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.ValueMoreThen);
            this.Controls.Add(this.removeTableButton);
            this.Controls.Add(this.removeRow);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableVisualizationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableVisualizationView";
            this.Load += new System.EventHandler(this.TableVizualiztionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        public System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button removeRow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TableStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VisualStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem BackStripMenuItem;
        private System.Windows.Forms.Button removeTableButton;
        private System.Windows.Forms.Button ValueMoreThen;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button ValueLessThen;
        private System.Windows.Forms.Button returnButton;
        private Button RemoveColoumnButton;
        private Button AddRowButton;
        private Button AddColoumnButton;
    }
}