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
using System.Drawing;

namespace Presenters.Presenter
{

    public class VisualizationPresenter: ViewPresenter<ITableView>
    {
        private ITransformmationService _services;
        public override void InitView()
        {

        }
        public VisualizationPresenter(ITableView view,ITransformmationService service): base(view)
        {
            _services = service;
        }

        public ITransformmationService Service { get { return _services; } set { _services = value; } }

        public void DisplayTable()
        {
            int i = 0;
            int numberOfTable = 0;
            view.DataGridView.Rows.Clear();  
            int count = view.DataGridView.Columns.Count;
            for (i = 0; i < count; i++)
            {
                view.DataGridView.Columns.RemoveAt(0);
            }
            int j = 0;
            foreach (DataTable table in _services.GetData().GetAllTables())
            {
                foreach (string name in table.ColumnsName)
                {
                    view.DataGridView.Columns.Add(name, name);
                    if(numberOfTable % 2 == 1)
                        view.DataGridView.Columns.GetLastColumn(
                            DataGridViewElementStates.Visible,DataGridViewElementStates.None).DefaultCellStyle.BackColor = Color.Azure;
                }
              
                if(table.DataColumn.Count > view.DataGridView.RowCount && view.DataGridView.Columns.Count !=0)
                {
                    int diff = table.DataColumn.Count - view.DataGridView.RowCount;
                    view.DataGridView.Rows.Add(diff);
                }
                i = 0;
                foreach (List<string> strings in table.DataColumn)
                {
                    int k = 0;
                    for (int l = j; l < j + strings.Count; l++)
                    {
                        view.DataGridView.Rows[i].Cells[l].Value = strings[k];
                        k++;

                    }
                    i++;
                }
                j = j + table.ColumnsName.Count();
                numberOfTable++;
            }
        }

        public void RemoveRow()
        {
            try
            {
                int removingRow = view.DataGridView.CurrentRow.Index;
                _services.RemoveRow(removingRow);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Row not selected");
            }
        }

        public void RemoveColoumn()
        {
            try
            {
                int removingColoumn = view.DataGridView.CurrentCell.ColumnIndex;
                _services.RemoveColoumn(removingColoumn);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Coloumn not selected");
            }
        }

        public void RemoveTable()
        {
            try {
                int removingTable = view.DataGridView.CurrentCell.ColumnIndex;
                _services.RemoveTable(removingTable);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Column not selected");
            }
        }

        public void SelectMoreThen()
        {
            try
            {
                double value = Convert.ToDouble(view.ValueBox.Text);
                int row = view.DataGridView.CurrentCell.ColumnIndex;
                _services.SelectElementsMoreThen(value, row);
            }
            catch(FormatException)
            {
                MessageBox.Show("Incorrect delimiter");
            }
            catch(NullReferenceException) 
            {
                MessageBox.Show("Select Column");
            }
        }
        public void SelectLessThen()
        {
            try
            {
                double value = Convert.ToDouble(view.ValueBox.Text);
                int row = view.DataGridView.CurrentCell.ColumnIndex;
                _services.SelectElementsLessThen(value, row);
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect delimiter");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select Column");
            }
        }

        public void ChangeElement()
        {
            try
            {
                int column = view.DataGridView.CurrentCell.ColumnIndex;
                int row = view.DataGridView.CurrentCell.RowIndex;
                string value = view.DataGridView.CurrentCell.Value.ToString();
                _services.ChangeElement(value, column, row);
            }
            catch
            {

            }
        }

        public void ReturnData()
        {
            _services.ReturnData();
        }
    }
}
