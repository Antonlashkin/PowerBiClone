using DataCacheStorage;
using DataServices;
using IDataSourcePerositories;
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
using IDataCacheStorage;
using Entities;

namespace Presenters.Presenter
{

    public class VisualizationPresenter: ViewPresenter<ITableView>
    {
        private IBasicService _services;
        public override void InitView()
        {

        }
        public VisualizationPresenter(ITableView view,IBasicService service): base(view)
        {
            _services = service;
        }

        public IBasicService Service { get { return _services; } set { _services = value; } }

        public void DisplayTable()
        {
            int i = 0;
            view.DataGridView.Rows.Clear();  
            int count = view.DataGridView.Columns.Count;
            for (i = 0; i < count; i++)
            {
                view.DataGridView.Columns.RemoveAt(0);
            }
            foreach (DataTable table in _services.GetData().GetAllTables())
            {
                int j = 0;
                foreach (string name in table.ColumnsName)
                {
                    view.DataGridView.Columns.Add(name, name);
                }
                if(table.DataColumn.Count > view.DataGridView.RowCount)
                {
                    int diff = table.DataColumn.Count - view.DataGridView.RowCount;
                    view.DataGridView.Rows.Add(diff);
                }
                i = 0;
                foreach (List<string> strings in table.DataColumn)
                {
                    int k = 0;
                    for (; j < j + strings.Count; j++)
                    {
                        view.DataGridView.Rows[i].Cells[j].Value = strings[k++];

                    }
                    i++;
                }
            }
        }

        public void RemoveRow(int k)
        {
            _services.GetData();
        }

        public void DisplayChart(Chart chart1,int X, int Y)
        {
            chart1.Series[0].Points.Clear();
            Axis xAxis = new Axis();
            xAxis.Title = _services.GetData().GetTable(0).ColumnsName[X];
            Axis yAxis = new Axis();
            yAxis.Title = _services.GetData().GetTable(0).ColumnsName[Y];
            chart1.ChartAreas[0].AxisX = xAxis;
            chart1.ChartAreas[0].AxisY = yAxis;
            foreach (List<string> row in _services.GetData().GetTable(0).DataColumn)
            {
                double x = Convert.ToDouble(row.ElementAt(X));
                double y = Convert.ToDouble(row.ElementAt(Y));
                chart1.Series[0].Points.AddXY(x, y);

            }
        }
    }
}
