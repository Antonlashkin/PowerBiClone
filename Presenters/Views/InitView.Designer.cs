namespace Presenters.Views
{
    partial class InitView
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
            this.loadFile = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.ToTableVizualization = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(39, 106);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(185, 43);
            this.loadFile.TabIndex = 0;
            this.loadFile.Text = "Load File";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(39, 55);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(185, 45);
            this.select.TabIndex = 1;
            this.select.Text = "Select File";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // ToTableVizualization
            // 
            this.ToTableVizualization.Location = new System.Drawing.Point(12, 12);
            this.ToTableVizualization.Name = "ToTableVizualization";
            this.ToTableVizualization.Size = new System.Drawing.Size(34, 26);
            this.ToTableVizualization.TabIndex = 3;
            this.ToTableVizualization.Text = "T";
            this.ToTableVizualization.UseVisualStyleBackColor = true;
            this.ToTableVizualization.Click += new System.EventHandler(this.toTableVizualization_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(39, 155);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(185, 42);
            this.saveToFile.TabIndex = 5;
            this.saveToFile.Text = "Save to File";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // InitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ToTableVizualization);
            this.Controls.Add(this.select);
            this.Controls.Add(this.loadFile);
            this.Name = "InitView";
            this.Text = "InitView";
            this.Load += new System.EventHandler(this.InitView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button ToTableVizualization;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveToFile;
    }
}