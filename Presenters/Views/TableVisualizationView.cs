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
        }

        public DataGridView DataGridView { get => dataTable; }

        public IDataCache Storage => _presenter.Service.GetData();

        TextBox ITableView.ValueBox => ValueBox;

        private void TableVizualiztionView_Load(object sender, EventArgs e)
        {
            _presenter.DisplayTable();
        }
        private void changeValue_click(object sender, DataGridViewCellEventArgs e)
        {
            _presenter.ChangeElement();
           
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
            _presenter.ReturnData();
            this.Hide();
        }

        private void VisualStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_nextForm == null)
            {
                ChartView chartView = new ChartView(this);
                _nextForm = chartView;
                this.Hide();
                _nextForm.MakeVisible();
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

        private void removeTableButton_Click(object sender, EventArgs e)
        {
            _presenter.RemoveTable();
            _presenter.DisplayTable();
        }

        private void ValueMoreThen_Click(object sender, EventArgs e)
        {
            _presenter.SelectMoreThen();
            _presenter.DisplayTable();
            this.returnButton.Visible = true;
        }

        private void ValueLessThen_Click(object sender, EventArgs e)
        {
            _presenter.SelectLessThen();
            _presenter.DisplayTable();
            this.returnButton.Visible = true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            _presenter.ReturnData();
            _presenter.DisplayTable();
        }

        public IInitView ReturnInitView()
        {
            return _parentForm;
        }

        private void RemoveColoumnButton_Click(object sender, EventArgs e)
        {
            _presenter.RemoveColoumn();
            _presenter.DisplayTable();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            _presenter.AddRow();
            _presenter.DisplayTable();
        }

        private void AddColoumnButton_Click(object sender, EventArgs e)
        {
            _presenter.AddColoumn();
            _presenter.DisplayTable();
        }
    }
}
