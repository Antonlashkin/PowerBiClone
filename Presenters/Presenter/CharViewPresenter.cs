using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using IServices;
using Presenters.Views;

namespace Presenters.Presenter
{
    public class CharViewPresenter : ViewPresenter<IView>
    {
        private IBasicService _basicService;
        public CharViewPresenter(IView view, IBasicService _service) : base(view)
        {
            _basicService = _service;
        }

        public override void InitView()
        {
        }
        public void SetComboBox(ComboBox comboBox)
        {
            foreach (string names in _basicService.GetData().GetTable().ColumnsName) { comboBox.Items.Add(names); }
        }

        public void DisplayChart(Chart chart1, int X, int Y)
        {
            _basicService.
            chart1.Series[0].Points.Clear();
            Axis xAxis = new Axis();
            xAxis.Title = _basicService.GetData().GetTable().ColumnsName[X];
            Axis yAxis = new Axis();
            yAxis.Title = _basicService.GetData().GetTable().ColumnsName[Y];
            chart1.ChartAreas[0].AxisX = xAxis;
            chart1.ChartAreas[0].AxisY = yAxis;
            foreach (List<string> row in _basicService.GetData().GetTable().DataColumn)
            {
                double x = Convert.ToDouble(row.ElementAt(X));
                double y = Convert.ToDouble(row.ElementAt(Y));
                chart1.Series[0].Points.AddXY(x, y);

            }
        }
    }
}
