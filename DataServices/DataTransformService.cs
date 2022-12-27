using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IServices;
using IDataSourcePerositories;
using DataServices;
using DataSourceRepositories;
using DataCacheStorage;
using IDataCacheStorage;
using DocumentFormat.OpenXml.Spreadsheet;

namespace DataServices
{
    public class DataTransformService : ITransformmationService
    {
        private IDataCache dataCache;
        private IDataCache bufferDataCache;

        public DataTransformService()
        {
            dataCache = new DataCache();
        }
        public DataTransformService(IDataCache dataCache)
        {
            this.dataCache = dataCache;
        }

        public IDataCache GetData()
        {
            return dataCache;
        }

        public void RemoveRow(int row)
        {
            foreach(DataTable table in dataCache.GetAllTables())
            {
                if (table.DataColumn.Count > row)
                {
                    table.DataColumn.RemoveAt(row);
                }
                else
                    continue;
            }
        }

        public void RemoveColoumn(int numOfColumn)
        {
            foreach (DataTable table in dataCache.GetAllTables())
            {
                if (numOfColumn >= table.ColumnsName.Count)
                {
                    numOfColumn -= table.ColumnsName.Count;
                    continue;
                }
                else
                {
                    dataCache.GetAllTables().Remove(table);

                    table.ColumnsName.RemoveAt(numOfColumn);
                    foreach(var row in table.DataColumn)
                    {
                        row.RemoveAt(numOfColumn);
                    }

                    var tmp = new DataSourceRepo();
                    tmp.DataBuffer = table;
                    dataCache.AddTable(tmp);
                    return;
                }
            }
        }

        public void RemoveTable(int column)
        {
            foreach (DataTable table in dataCache.GetAllTables())
            {
                int i = 0;
                if(column >= table.ColumnsName.Count)
                {
                    column -= table.ColumnsName.Count;
                    i++;
                    continue;
                }
                else
                {
                    dataCache.GetAllTables().Remove(table);
                    return;
                }
            }
        }

        public void AddRow(int numOfRow)
        {
            foreach (DataTable table in dataCache.GetAllTables())
            {
                List<string> row = new List<string>(table.ColumnsName.Count);
                for (int i = 0; i < table.ColumnsName.Count; ++i)
                    row.Add("");

                if (numOfRow < table.DataColumn.Count)
                {
                    table.DataColumn.Insert(numOfRow, row);
                }
                else
                {
                    table.DataColumn.Add(row);
                }    
            }
        }

        public void AddColoumn(int numOfColumn)
        {
            foreach (DataTable table in dataCache.GetAllTables())
            {
                if (numOfColumn >= table.ColumnsName.Count)
                {
                    numOfColumn -= table.ColumnsName.Count;
                    continue;
                }
                else
                {
                    dataCache.GetAllTables().Remove(table);

                    table.ColumnsName.Insert(numOfColumn, "");
                    foreach (var row in table.DataColumn)
                    {
                        row.Insert(numOfColumn, "");
                    }

                    var tmp = new DataSourceRepo();
                    tmp.DataBuffer = table;
                    dataCache.AddTable(tmp);
                    return;
                }
            }
        }

        public void SelectElementsMoreThen(double value, int column)
        {
            if (bufferDataCache != null)
                ReturnData();
            bufferDataCache = (IDataCache)dataCache.Clone();    
            foreach (DataTable table in bufferDataCache.GetAllTables())
            {
                if (column >= table.ColumnsName.Count)
                {
                    column -= table.ColumnsName.Count;
                    continue;
                }
                else
                {
                    int i = 0;
                    foreach (List<string> rows in table.DataColumn)
                    {
                        if(Convert.ToDouble(rows.ElementAt(column)) < value)
                        {
                            RemoveRow(i);
                            i--;
                        }
                        i++;
                    }
                    return;
                }
            }
        }

        public void SelectElementsLessThen(double value, int column)
        {
            if (bufferDataCache != null)
                ReturnData();
            bufferDataCache = (IDataCache)dataCache.Clone();
            foreach (DataTable table in bufferDataCache.GetAllTables())
            {
                if (column >= table.ColumnsName.Count)
                {
                    column -= table.ColumnsName.Count;
                    continue;
                }
                else
                {
                    int i = 0;
                    foreach (List<string> rows in table.DataColumn)
                    {
                        if (Convert.ToDouble(rows.ElementAt(column)) > value)
                        {
                            RemoveRow(i);
                            i--;
                        }
                        i++;
                    }
                    return;
                }
            }
        }
        public void ReturnData()
        {
            dataCache = bufferDataCache;
        }

        public void ChangeElement(string newValue, int column, int row)
        {
            foreach (DataTable table in dataCache.GetAllTables())
            {
                int i = 0;
                if (column >= table.ColumnsName.Count)
                {
                    column -= table.ColumnsName.Count;
                    i++;
                    continue;
                }
                else
                {
                    table.DataColumn.ElementAt(row)[column] = newValue;
                    return;
                }
            }

        }
    }
}
