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
using System.Xml.Linq;

namespace Presenters.Views
{
    public partial class ChartView : Form, IChartView
    {
        private ITableView _parentForm;
        private IInitView _initForm;
        private ChartPresenter _presenter;
        private object CurrentObj;
        private List<Chart> charts = new List<Chart>();
        public ChartView(ITableView form)
        {
            DataVisualizationService dvs = new DataVisualizationService(form.Storage);
            _presenter = new ChartPresenter(dvs,this);
            _parentForm = form;
            _initForm = form.ReturnInitView();
            InitializeComponent();
        }

        public ComboBox ComboBoxX => XcolumnBox;

        public ComboBox ComboBoxY => YColumnBox;


        public ListBox ChartsBox => chartListBox;

        public List<Chart> Charts { get => charts; set => charts = value; }

        private void MouseRightClick(object sender, MouseEventArgs e)
        {
            if(CurrentObj != null)
                CurrentObj = null;
        }

        private void SelectChart(object sender, MouseEventArgs e)
        {
            if (CurrentObj == null)
            {
                CurrentObj = sender;
            }
        }

        private void ChartView_Load(object sender, EventArgs e)
        {
            _presenter.SetComboBoxX();
            _presenter.SetComboBoxY();


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void BackStripMenuItem_Click(object sender, EventArgs e)
        {
            _initForm.MakeVisible();
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
            this.Hide();
            _parentForm.MakeVisible();
        }

        private void VisualMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void XcolumnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioPie.Checked)
                    _presenter.DisplayPieChart();
                else if (radioLine.Checked)
                    _presenter.DisplayLineChart();
                else if (radioBar.Checked)
                    _presenter.DisplayBarChart();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Fill in all the fields");
            }
            catch (FormatException)
            {
                MessageBox.Show("Not all data is filled in correctly");
            }
        }

        private void radioLine_CheckedChanged(object sender, EventArgs e)
        {
            labelY.Visible = true;
            YColumnBox.Visible = true;
            labelX.Text = "X";
            _presenter.SetComboBoxX();
            _presenter.SetComboBoxY();
        }

        private void radioBar_CheckedChanged(object sender, EventArgs e)
        {
            labelX.Text = "Col";
            _presenter.SetComboBoxX();
            labelY.Visible = false;
            YColumnBox.Visible = false;
        }

        private void radioPie_CheckedChanged(object sender, EventArgs e)
        {
            labelX.Text = "Line";
            _presenter.SetComboBoxByLines(); 
            labelY.Visible = false;
            YColumnBox.Visible = false;
        }

        private void NewChartStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            try
            {
                Chart lastChart = Charts.Last();
                Point lastPosition = Charts.Last().Location;
                lastPosition.Y += 395;
                chart.Location= lastPosition;
            }
            catch(System.InvalidOperationException)
            {
                chart.Location = new Point(200, 32);
            }
            chart.Size = new Size(390, 300);
            this.Controls.Add(chart);
            Charts.Add(chart);
            chart.Titles.Add("Chart " + Charts.Count.ToString());
            chart.Series.Add("Series");
            chart.ChartAreas.Add("1");
            chartListBox.Items.Add("Chart " + Charts.Count.ToString());
            chart.MouseClick += new MouseEventHandler(SelectChart);
            chart.MouseWheel += new MouseEventHandler(ZoomChart);
            this.MouseMove += new MouseEventHandler(MovingChart);
            this.MouseClick += new MouseEventHandler(MouseRightClick);
        }
        private void MovingChart(object sender, MouseEventArgs e)
        {
            if (CurrentObj != null)
            {
                CurrentObj.GetType().GetProperty("Location").SetValue(CurrentObj, new Point(e.X+5,e.Y+5));
            }
        }

        private void ZoomChart(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            Size currentSize = chart.Size;
            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    currentSize.Width -= 10;
                    currentSize.Height -= 10;
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    currentSize.Width += 10;
                    currentSize.Height += 10;
                }

                chart.Size = currentSize;
            }
            catch { }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void removeChart_Click(object sender, MouseEventArgs e)
        { 
                try
                {
                    charts.ElementAt(chartListBox.SelectedIndex).Dispose();
                    charts.RemoveAt(chartListBox.SelectedIndex);
                    chartListBox.Items.RemoveAt(chartListBox.SelectedIndex);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Chart for removing not selected");
                }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
