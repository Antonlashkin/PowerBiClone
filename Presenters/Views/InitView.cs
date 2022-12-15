using Presenters.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IServices;
using DataServices;
using IDataSourcePerositories;

namespace Presenters.Views
{
    public partial class InitView : Form, IView
    {
        private InitPresenter presenter;
        public InitView()
        {
            presenter = new InitPresenter(this);
            InitializeComponent();
            SaveToolStripMenuItem.Enabled = false;
            TableStripMenuItem.Enabled = false;
            VisualStripMenuItem.Enabled = false;
        }

        public IDataSourceRep Data { get => presenter.Service.GetData(); }

        private void InitView_Load(object sender, EventArgs e)
        {

        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            presenter.Service.reader(textBox1.Text);
            //ToTableVizualization.Enabled = true;
            //saveToFile.Enabled = true;
        }

        private void select_Click(object sender, EventArgs e)
        {
            textBox1.Text = presenter.SelectFile().ToString();
            //loadFile.Enabled = true;
        }

        private void toTableVizualization_Click(object sender, EventArgs e)
        {
            TableVisualizationView tvzv = new TableVisualizationView(this);
            this.Hide();
            tvzv.ShowDialog();

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }       
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = presenter.SelectFile().ToString();
                presenter.Service.reader(textBox1.Text);
                TableStripMenuItem.Enabled = true;
                VisualStripMenuItem.Enabled = true;
                SaveToolStripMenuItem.Enabled = true;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("File not selected");
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.Service.writer(presenter.SelectFile());
                MessageBox.Show("The file has been saved");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("File not selected");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("File not selected");
            }
        }

        private void TableStripMenuItem_Click(object sender, EventArgs e)
        {
            TableVisualizationView tvzv = new TableVisualizationView(this);
            this.Hide();
            tvzv.ShowDialog();
        }

        private void VisualStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartView chartView = new ChartView(this);
            this.Hide();
            chartView.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void HideView()
        {
            this.Hide();
        }

        public void MakeVisible()
        {
            this.Visible = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
