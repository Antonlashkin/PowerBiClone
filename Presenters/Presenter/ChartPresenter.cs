using DataCacheStorage;
using DataServices;
using IServices;
using Presenters.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using System.Windows.Forms.DataVisualization.Charting;
using IDataCacheStorage;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presenters.Presenter
{
    public class ChartPresenter : ViewPresenter<IChartView>
    {
        private IVisualizationService _services;
        public override void InitView()
        {

        }
        public ChartPresenter(IVisualizationService basicService, IChartView view) : base(view)
        {   
            _services = basicService;
        }
       

        public IVisualizationService Service { get { return _services; } set { _services = value; } }
        public void SetComboBoxX()
        {
            view.ComboBoxX.Items.Clear();  
            foreach (DataTable data in _services.GetData().GetAllTables())
                foreach (string colName in data.ColumnsName)
                    view.ComboBoxX.Items.Add(colName);
        }
        public void SetComboBoxY()
        {
            view.ComboBoxY.Items.Clear();
            foreach (DataTable data in _services.GetData().GetAllTables())
                foreach (string colName in data.ColumnsName)
                    view.ComboBoxY.Items.Add(colName);
        }

        public string EnterNewTextDialog()
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter new name",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Enter new name" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            Button deleteButton = new Button() { Text = "Delete", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            deleteButton.Click += (sender, e) => { textBox.Text = "delete77788899/"; prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(deleteButton);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;


            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public void SetComboBoxByLines()
        {
            view.ComboBoxX.Items.Clear();
            int max = 0;
            foreach (DataTable data in _services.GetData().GetAllTables())
            {
                if(max < data.DataColumn.Count)
                    max = data.DataColumn.Count;
            }
            for (int i = 0; i < max; i++)
                view.ComboBoxX.Items.Add(i);
        }

        public void DisplayPieChart()
        {
            Chart currentChart = (Chart)view.CurrentChart;
            currentChart.Series[0].Points.Clear();
            currentChart.Series[0].ChartType = SeriesChartType.Pie;
            foreach (DataTable table in _services.GetData().GetAllTables())
            {
                if (table.DataColumn.Count > view.ComboBoxX.SelectedIndex)
                {
                    for(int i = 0; i < table.ColumnsName.Count;i++)
                    {
                        double point = Convert.ToDouble(table.DataColumn.ElementAt(view.ComboBoxX.SelectedIndex).ElementAt(i));
                        currentChart.Series[0].Points.AddY(point);
                        currentChart.Series[0].Points.Last().AxisLabel = table.ColumnsName.ElementAt(i);
                    }
                }
                else
                    continue;
            }
        }
        public void DisplayLineChart()
        {
            Chart currentChart = (Chart)view.CurrentChart;
            currentChart.Series[0].Points.Clear();
            currentChart.Series[0].ChartType = SeriesChartType.Spline;
            if (view.TextBoxX.Text == null || view.TextBoxX.Text == "")
            {
                currentChart.ChartAreas[0].AxisX.Title = "X";
            }else
            {
                currentChart.ChartAreas[0].AxisX.Title = view.TextBoxX.Text;
            }
            if (view.TextBoxY.Text == null || view.TextBoxY.Text == "")
            {
                currentChart.ChartAreas[0].AxisY.Title = "Y";
            }
            else
            {
                currentChart.ChartAreas[0].AxisY.Title = view.TextBoxY.Text;
            }
            List<double> pointsX = new List<double>(_services.GetColumn(view.ComboBoxX.SelectedIndex));
            List<double> pointsY = new List<double>(_services.GetColumn(view.ComboBoxY.SelectedIndex));
            if(pointsX.Count > pointsY.Count)
            {
                int deff = pointsX.Count - pointsY.Count;
                for(int i = 0; i < deff; i++)
                    pointsX.RemoveAt(pointsX.Count -1);
            }
            if (pointsX.Count < pointsY.Count)
            {
                int deff = pointsY.Count - pointsX.Count;
                for (int i = 0; i < deff; i++)
                    pointsY.RemoveAt(pointsX.Count - 1);
            }
            currentChart.Series[0].Points.DataBindXY(pointsX, pointsY);
           
        }

        public void DisplayBarChart()
        {
            Chart currentChart = (Chart)view.CurrentChart;
            currentChart.Series[0].Points.Clear();
            currentChart.Series[0].ChartType = SeriesChartType.RangeBar;
            List<double> points = new List<double>(_services.GetColumn(view.ComboBoxX.SelectedIndex));
            for (int i = 0; i < points.Count; i++)
            {
                currentChart.Series[0].Points.AddXY(i, points[i]);
            }
        }
    }
}
