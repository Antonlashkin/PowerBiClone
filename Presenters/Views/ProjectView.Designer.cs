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
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 384);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(464, 29);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(164, 40);
            this.AddFileButton.TabIndex = 1;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveAndExitButton
            // 
            this.SaveAndExitButton.Location = new System.Drawing.Point(600, 377);
            this.SaveAndExitButton.Name = "SaveAndExitButton";
            this.SaveAndExitButton.Size = new System.Drawing.Size(164, 47);
            this.SaveAndExitButton.TabIndex = 2;
            this.SaveAndExitButton.Text = "Save and exit";
            this.SaveAndExitButton.UseVisualStyleBackColor = true;
            this.SaveAndExitButton.Click += new System.EventHandler(this.SaveAndExitButton_Click);
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveAndExitButton);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.listBox1);
            this.Name = "ProjectView";
            this.Text = "ProjectView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button SaveAndExitButton;
    }
}