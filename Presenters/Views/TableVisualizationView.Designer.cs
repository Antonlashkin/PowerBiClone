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
            this.close = new System.Windows.Forms.Button();
            this.showTable = new System.Windows.Forms.Button();
            this.showChar = new System.Windows.Forms.Button();
            this.removeRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(315, 12);
            this.dataTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataTable.Size = new System.Drawing.Size(475, 377);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableView_CellContentClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(651, 395);
            this.close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(139, 43);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // showTable
            // 
            this.showTable.Location = new System.Drawing.Point(12, 12);
            this.showTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(185, 49);
            this.showTable.TabIndex = 2;
            this.showTable.Text = "Show Table";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // showChar
            // 
            this.showChar.Location = new System.Drawing.Point(12, 68);
            this.showChar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showChar.Name = "showChar";
            this.showChar.Size = new System.Drawing.Size(185, 46);
            this.showChar.TabIndex = 3;
            this.showChar.Text = "Show Chart";
            this.showChar.UseVisualStyleBackColor = true;
            this.showChar.Click += new System.EventHandler(this.showChart_Click);
            // 
            // removeRow
            // 
            this.removeRow.Location = new System.Drawing.Point(12, 121);
            this.removeRow.Name = "removeRow";
            this.removeRow.Size = new System.Drawing.Size(185, 49);
            this.removeRow.TabIndex = 4;
            this.removeRow.Text = "Remove Last Row";
            this.removeRow.UseVisualStyleBackColor = true;
            this.removeRow.Click += new System.EventHandler(this.removeRow_Click);
            // 
            // TableVisualizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeRow);
            this.Controls.Add(this.showChar);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableVisualizationView";
            this.Text = "TableVisualizationView";
            this.Load += new System.EventHandler(this.TableVizualiztionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button showChar;
        private System.Windows.Forms.Button removeRow;
    }
}