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

namespace Presenters.Presenter
{
    internal class VizualizationPresenter: ViewPresenter<IView>
    {
        private IBasicService _services;
        public override void InitView()
        {

        }
        public VizualizationPresenter(IView view,IBasicService service) : base(view)
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

    }
}
