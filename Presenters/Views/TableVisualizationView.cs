using DataServices;
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
    public partial class TableVisualizationView : Form, IView
    {
        private IView _parentForm;
        private VisualizationPresenter _presenter;
       
        public TableVisualizationView(IView form)
        {
            DataTransformService dvs = new DataTransformService(form.Data);
            _presenter = new VisualizationPresenter(this,dvs);
            _parentForm = form; 
            InitializeComponent();
            if (_parentForm is ChartView)
                VisualStripMenuItem2.Enabled = false;
        }

        public IDataSourceRep Data => _presenter.Service.GetData();

        private void TableVizualiztionView_Load(object sender, EventArgs e)
        {
            _presenter.DisplayTable(dataTable);
        }

        private void dataTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void showTable_Click(object sender, EventArgs e)
        {
            _presenter.DisplayTable(dataTable);

            
        }

        private void removeRow_Click(object sender, EventArgs e)
        {
            _presenter.RemoveLastRow();
            _presenter.DisplayTable(dataTable);
        }

        private void BackStripMenuItem_Click(object sender, EventArgs e)
        {
            _parentForm.MakeVisible();
            this.Close();
        }

        private void VisualStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChartView chartView = new ChartView(this);
            this.Hide();
            chartView.ShowDialog();
        }

        public void HideView()
        {
            this.Hide();
        }

        public void MakeVisible()
        {
            this.Visible = true;
        }

        private void TableStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
