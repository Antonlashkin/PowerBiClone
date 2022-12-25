using Presenters.Presenter;
using System;
using System.Windows.Forms;
using IServices;
using DataServices;
using IDataSourcePerositories;
using IDataCacheStorage;

namespace Presenters.Views
{
    public partial class InitView : Form, IInitView
    {
        private InitPresenter presenter;
        private ITableView tableView;
        public InitView()
        {
            presenter = new InitPresenter(this);
            InitializeComponent();
            SaveToolStripMenuItem.Enabled = false;
            TableStripMenuItem.Enabled = false;
        }

        IDataCache IInitView.Data { get => presenter.Cache; }

        public ListBox FileNames => listBoxFileLoaded;

        private void InitView_Load(object sender, EventArgs e)
        {

        }
        private void toTableVizualization_Click(object sender, EventArgs e)
        {
            if (tableView == null)
            {
                TableVisualizationView tvzv = new TableVisualizationView(this);
                tableView = tvzv;
                this.Hide();
                tvzv.ShowDialog();
            }
            else
            {
                this.Hide();
                tableView.MakeVisible();
            }
        }
        
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {   

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string file = presenter.SelectFile("txt files (*.txt)|*.txt|csv files (*.csv)|*.csv").ToString();
                presenter.Service.reader(file);
                TableStripMenuItem.Enabled = true;
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
                string file = presenter.SaveFile("txt files (*.txt)|*.txt|csv files (*.csv)|*.csv").ToString();
                presenter.Service.writer(file);
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
            if (tableView == null)
            {
                TableVisualizationView tvzv = new TableVisualizationView(this);
                this.Hide();
                tableView = tvzv;
                tvzv.ShowDialog();
            }
            else
            {
                this.Hide();
                tableView.MakeVisible();
            }


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


        private void loadedFileLable_Click(object sender, EventArgs e)
        {

        }
     
        private void listBoxFileLoaded_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddingFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.FileInfo file = presenter.SelectFile("txt files (*.txt)|*.txt|csv files (*.csv)|*.csv");
                presenter.Service.reader(file.FullName);
                TableStripMenuItem.Enabled = true;
                SaveToolStripMenuItem.Enabled = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("File not selected");
            }
        }
    }
}
