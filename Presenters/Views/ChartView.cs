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
    public partial class ChartView : Form, IChartView
    {
        private IInitView _parentForm;
        private ChartPresenter _presenter;
        public ChartView(IInitView form)
        {
            DataTransformService dvs = new DataTransformService();
            _presenter = new ChartPresenter(dvs,this);
            _parentForm = form;
            InitializeComponent();
            if (_parentForm is TableVisualizationView)
                TableStripMenuItem.Enabled = false;
        }

        public ComboBox ComboBoxX => XcolumnBox;

        public ComboBox ComboBoxY => YColumnBox;

        private void ChartView_Load(object sender, EventArgs e)
        {
            //_presenter.DisplayChart(this.chart1);
            _presenter.SetComboBoxX();
            _presenter.SetComboBoxY();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void BackStripMenuItem_Click(object sender, EventArgs e)
        {
            _parentForm.MakeVisible();
            this.Hide();
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
            TableVisualizationView _tableView = new TableVisualizationView(_parentForm);
            this.Hide();
            _tableView.ShowDialog();
        }

        private void VisualMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void XcolumnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void UpdateStripMenuItem_Click(object sender, EventArgs e)
        {
            /*try
            {
                int X = XcolumnBox.SelectedIndex;
                int Y = YColumnBox.SelectedIndex;
                _presenter.DisplayChart(this.chart1, X, Y);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select columns, please");
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int X = XcolumnBox.SelectedIndex;
                int Y = YColumnBox.SelectedIndex;
               // _presenter.DisplayChart(this.chart1, X, Y);
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton1.Checked = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select columns, please");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int X = XcolumnBox.SelectedIndex;
            int Y = YColumnBox.SelectedIndex;
            chart1.Series[0].ChartType = SeriesChartType.Line;
           // _presenter.DisplayChart(this.chart1, X, Y);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int X = XcolumnBox.SelectedIndex;
            int Y = YColumnBox.SelectedIndex;
            chart1.Series[0].ChartType = SeriesChartType.Bar;
           // _presenter.DisplayChart(this.chart1, X, Y);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int X = XcolumnBox.SelectedIndex;
            int Y = YColumnBox.SelectedIndex;
            chart1.Series[0].ChartType = SeriesChartType.Pie;
           // _presenter.DisplayChart(this.chart1, X, Y);
        }
    }
}
