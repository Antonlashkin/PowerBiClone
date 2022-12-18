using IDataSourcePerositories;
using IVisuals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Visuals
{
    public class BasicVisual : IVisual
    {
       
        public void BarChartFormating(IDataSourceRep dataSourceRep, Chart chart, int X, int Y)
        {

        }

        public void LineChartFormating(IDataSourceRep dataSourceRep, Chart chart, int X, int Y)
        {
            chart.Series[0].Points.Clear();
            Axis xAxis = new Axis();
            xAxis.Title = dataSourceRep.GetTable().ColumnsName[X];
            Axis yAxis = new Axis();
            yAxis.Title = dataSourceRep.GetTable().ColumnsName[Y];
            chart.ChartAreas[0].AxisX = xAxis;
            chart.ChartAreas[0].AxisY = yAxis;
            foreach (List<string> row in dataSourceRep.GetTable().DataColumn)
            {
                double x = Convert.ToDouble(row.ElementAt(X));
                double y = Convert.ToDouble(row.ElementAt(Y));
                chart.Series[0].Points.AddXY(x, y);

            }
        }

        public void PieChartFormating(IDataSourceRep dataSourceRep, Chart chart, int X, int Y)
        {
            
        }
    }
}
