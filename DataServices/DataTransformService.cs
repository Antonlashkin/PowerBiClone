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

namespace DataServices
{
    public class DataTransformService : ITransformmationService
    {
        private IDataCache dataCache;

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
    }
}
