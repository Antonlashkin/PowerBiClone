using IDataSourcePerositories;
using IServices;
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

namespace Presenters.Views
{
    public partial class ProjectView : Form
    {
        //TODO array of files
        //
        private ChartPresenter presenter;
        private IDataSourceAccessService _services;
       // public IDataSourceRep Data { get => presenter.Service.GetData(); }
        public ProjectView()
        {
         //   presenter = new ChartPresenter(this);
            InitializeComponent();
        }
        public void HideView()
        {
            this.Hide();
        }

        public void MakeVisible()
        {
            this.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // System.IO.FileInfo file = presenter.SelectFile("txt files (*.txt)|*.txt|csv files (*.csv)|*.csv");
               // listBox1.Items.Add(file.Name);

                //presenter.Service.reader(file);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("File not selected");
            }
        }

        private void SaveAndExitButton_Click(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectView_Load(object sender, EventArgs e)
        {

        }
    }
}
