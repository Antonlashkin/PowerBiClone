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
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(290, 48);
            this.dataTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataTable.Size = new System.Drawing.Size(498, 374);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableView_CellContentClick);
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
            this.BackStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.BackStripMenuItem.Text = "Back";
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
            // TableVisualizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}