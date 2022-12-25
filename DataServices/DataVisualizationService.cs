using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;
using Entities;
using IVisuals;
using IDataSourcePerositories;
using IDataCacheStorage;

namespace DataServices
{
    public class DataVisualizationService : IVisualizationService
    {
        // Передача данных для визуализации
        private IDataCache dataCache;

        public DataVisualizationService(IDataCache data)
        {
            dataCache = data;
        }

        public void DeserialaizedCharts()
        {
            throw new NotImplementedException();
        }

        public List<double> GetColumn(int columnIndex)
        {
            foreach (DataTable table in dataCache.GetAllTables())
            {
                if (columnIndex >= table.ColumnsName.Count)
                {
                    columnIndex -= table.ColumnsName.Count;
                    continue;
                }
                else
                {
                    List<double> outList = new List<double>();
                    foreach (List<string> rows in table.DataColumn)
                    {
                        outList.Add(Convert.ToDouble(rows.ElementAt(columnIndex)));
                    }
                    return outList;
                }
            }
            return null;
        }

        public IDataCache GetData()
        {
            return dataCache;
        }

       
        
    }
}
