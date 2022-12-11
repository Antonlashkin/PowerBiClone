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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(236, 10);
            this.dataTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataTable.Size = new System.Drawing.Size(356, 306);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableView_CellContentClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(488, 321);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(104, 35);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // showTable
            // 
            this.showTable.Location = new System.Drawing.Point(9, 10);
            this.showTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(139, 40);
            this.showTable.TabIndex = 2;
            this.showTable.Text = "Show Table";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 55);
            this.button1.Name = "showChart";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showChart_Click);
            // 
            // TableVisualizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
    }
}