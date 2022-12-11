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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presenters.Presenter
{
    internal class VisualizationPresenter: ViewPresenter<IView>
    {
        private IBasicService _services;
        public override void InitView()
        {

        }
        public VisualizationPresenter(IView view,IBasicService service) : base(view)
        {
            _services = service;
        }

        public IBasicService Service { get { return _services; } set { _services = value; } }

        public void DisplayTable(DataGridView dataGrid)
        {
            int i = 0;
            dataGrid.Rows.Clear();  
            int count = dataGrid.Columns.Count;
            for (i = 0; i < count; i++)
            {
                dataGrid.Columns.RemoveAt(0);
            }
            foreach (string name in _services.GetData().GetTable().ColumnsName)
            {
                dataGrid.Columns.Add(name,name);
            }
            dataGrid.Rows.Add(_services.GetData().GetTable().DataColumn.Count);
            i = 0;
            foreach (List<string> strings in _services.GetData().GetTable().DataColumn)
            {
                for (int j = 0; j < strings.Count; j++)
                {
                   
                    dataGrid.Rows[i].Cells[j].Value = strings[j];
                 
                }
                i++;
            }
        }

        public void DisplayChart(Chart chart1, DataGridView dataGrid)
        {
            chart1.Series[0].Points.Clear();
            Axis xAxis = new Axis();
            Axis yAxis = new Axis();
            chart1.ChartAreas[0].AxisX = xAxis;
            chart1.ChartAreas[0].AxisY = yAxis;
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                int x = Convert.ToInt32(dataGrid.Rows[i].Cells[0].Value);
                int y = Convert.ToInt32(dataGrid.Rows[i].Cells[1].Value);
                chart1.Series[0].Points.AddXY(x, y);

            }
        }
    }
}
