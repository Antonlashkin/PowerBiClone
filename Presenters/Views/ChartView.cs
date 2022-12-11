using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Presenters.Presenter;
using IDataSourcePerositories;
using DataServices;
using Presenters.Views;

namespace Presenters.Views
{
    public partial class ChartView : Form, IView
    {
        private TableVisualizationView _parentForm;
        private VisualizationPresenter _presenter;
        public ChartView(TableVisualizationView form)
        {
            DataTransformService dvs = new DataTransformService(form.Data);
            _presenter = new VisualizationPresenter(this, dvs);
            _parentForm = form;
            InitializeComponent();
        }

        public IDataSourceRep Data => ((IView)_parentForm).Data;

        private void ChartView_Load(object sender, EventArgs e)
        {
            _presenter.DisplayChart(this.chart1, _parentForm.dataTable);
        }
    }
}
