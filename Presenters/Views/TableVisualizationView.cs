using DataServices;
using IDataCacheStorage;
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
    public partial class TableVisualizationView : Form, ITableView
    {
        private IInitView _parentForm;
        private IChartView _nextForm;
        private VisualizationPresenter _presenter;
       
        public TableVisualizationView(IInitView form)
        {
            DataTransformService dvs = new DataTransformService(form.Data);
            _presenter = new VisualizationPresenter(this,dvs);
            _parentForm = form;
            InitializeComponent();
            if (_parentForm is ChartView)
                VisualStripMenuItem2.Enabled = false;
        }
        public TableVisualizationView(TableVisualizationView tvv)
        {
        }

        public IDataCache Data => _presenter.Service.GetData();

        public DataGridView DataGridView { get => dataTable; }

        private void TableVizualiztionView_Load(object sender, EventArgs e)
        {
            _presenter.DisplayTable();
        }

        private void dataTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void showTable_Click(object sender, EventArgs e)
        {
            _presenter.DisplayTable();

            
        }

        private void removeRow_Click(object sender, EventArgs e)
        {
            _presenter.RemoveRow();
            _presenter.DisplayTable();
        }

        private void BackStripMenuItem_Click(object sender, EventArgs e)
        {
            _parentForm.MakeVisible();
            this.Close();
        }

        private void VisualStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_nextForm == null)
            {
                ChartView chartView = new ChartView(this);
                _nextForm = chartView;
                this.Hide();
                chartView.ShowDialog();
            }
            else
            {
                this.Hide();
                _nextForm.MakeVisible();
            }
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
