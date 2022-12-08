using DataServices;
using IDataSourcePerositories;
using IServices;
using Presenters.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenters.Views
{
    public partial class TableVizualiztionView : Form, IView
    {
        private InitView _parentForm;
        private VizualizationPresenter _presenter;
       
        public TableVizualiztionView(InitView form)
        {
            DataTransformService dvs = new DataTransformService(form.Data);
            _presenter = new VizualizationPresenter(this,dvs);
            _parentForm = form; 
            InitializeComponent();
        }

        public IDataSourceRep Data => _presenter.Service.GetData();

        private void TableVizualiztionView_Load(object sender, EventArgs e)
        {

        }

        private void dataTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            _parentForm.Visible = true;
            this.Close();
        }

        private void showTable_Click(object sender, EventArgs e)
        {
            _presenter.DisplayTable(dataTable);

            
        }

        
    }
}
