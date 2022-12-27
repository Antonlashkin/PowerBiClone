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
            int chartIndex = view.ChartsBox.SelectedIndex;
            view.Charts.ElementAt(chartIndex).Series[0].Points.Clear();
            view.Charts.ElementAt(chartIndex).Series[0].ChartType = SeriesChartType.Pie;
            foreach (DataTable table in _services.GetData().GetAllTables())
            {
                if (table.DataColumn.Count > view.ComboBoxX.SelectedIndex)
                {
                    for(int i = 0; i < table.ColumnsName.Count;i++)
                    {
                        double point = Convert.ToDouble(table.DataColumn.ElementAt(view.ComboBoxX.SelectedIndex).ElementAt(i));
                        view.Charts.ElementAt(chartIndex).Series[0].Points.AddY(point);
                        view.Charts.ElementAt(chartIndex).Series[0].Points.Last().AxisLabel = table.ColumnsName.ElementAt(i);
                    }
                }
                else
                    continue;
            }
        }
        public void DisplayLineChart()
        {
            int chartIndex = view.ChartsBox.SelectedIndex;
            view.Charts.ElementAt(chartIndex).Series[0].Points.Clear();
            view.Charts.ElementAt(chartIndex).Series[0].ChartType = SeriesChartType.Spline;
            view.Charts.ElementAt(chartIndex).ChartAreas[0].AxisX.Title = view.ComboBoxX.Text;
            view.Charts.ElementAt(chartIndex).ChartAreas[0].AxisY.Title = view.ComboBoxY.Text;
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
            view.Charts.ElementAt(chartIndex).Series[0].Points.DataBindXY(pointsX, pointsY);
           
        }

        public void DisplayBarChart()
        {
            int chartIndex = view.ChartsBox.SelectedIndex;
            view.Charts.ElementAt(chartIndex).Series[0].Points.Clear();
            view.Charts.ElementAt(chartIndex).Series[0].ChartType = SeriesChartType.RangeBar;
            List<double> points = new List<double>(_services.GetColumn(view.ComboBoxX.SelectedIndex));
            for (int i = 0; i < points.Count; i++)
            {
                view.Charts.ElementAt(chartIndex).Series[0].Points.AddXY(i, points[i]);
            }
        }
    }
}
