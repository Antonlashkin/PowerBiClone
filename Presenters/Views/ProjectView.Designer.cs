namespace Presenters.Views
{
    partial class ProjectView
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.SaveAndExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(412, 23);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(146, 32);
            this.AddFileButton.TabIndex = 1;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveAndExitButton
            // 
            this.SaveAndExitButton.Location = new System.Drawing.Point(533, 302);
            this.SaveAndExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveAndExitButton.Name = "SaveAndExitButton";
            this.SaveAndExitButton.Size = new System.Drawing.Size(146, 38);
            this.SaveAndExitButton.TabIndex = 2;
            this.SaveAndExitButton.Text = "Save and exit";
            this.SaveAndExitButton.UseVisualStyleBackColor = true;
            this.SaveAndExitButton.Click += new System.EventHandler(this.SaveAndExitButton_Click);
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.SaveAndExitButton);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectView";
            this.Text = "ProjectView";
            this.Load += new System.EventHandler(this.ProjectView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button SaveAndExitButton;
    }
}