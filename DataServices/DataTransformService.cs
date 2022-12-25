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
    }
}
