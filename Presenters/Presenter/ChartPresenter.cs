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

namespace Presenters.Presenter
{
    public class ChartPresenter : ViewPresenter<IChartView>
    {
        private IBasicService _services;
        public override void InitView()
        {

        }
        public ChartPresenter(IBasicService basicService, IChartView view) : base(view)
        {   
            _services = basicService;
        }

        public IBasicService Service { get { return _services; } set { _services = value; } }
        public void SetComboBoxX()
        {
            foreach (DataTable data in _services.GetData().GetAllTables())
                foreach (string colName in data.ColumnsName)
                    view.ComboBoxX.Items.Add(colName);
        }
        public void SetComboBoxY()
        {
            foreach (DataTable data in _services.GetData().GetAllTables())
                foreach (string colName in data.ColumnsName)
                    view.ComboBoxY.Items.Add(colName);
        }
    }
}
