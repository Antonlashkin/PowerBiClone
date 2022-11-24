using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Classes
{
    public class DataCacheStorageBilder
    {
        private DataCacheStorage dataCacheStorage;

        public DataCacheStorageBilder() { 
        dataCacheStorage = new DataCacheStorage();
        }
        public DataCacheStorageBilder(DataCacheStorage dataCacheStorage)
        {
            this.dataCacheStorage = dataCacheStorage;
        }

        public void setFileLocation(string FileName)
        {
            dataCacheStorage.FileLcation = FileName;
        }

        public void setColumnNames(List<string> columns)
        {
            dataCacheStorage.ColumnsName = columns;
        }

        public void setData(List<List<string>> data)
        {
            dataCacheStorage.DataColumn = data;
        }

        public DataCacheStorage build()
        {
            return dataCacheStorage;
        }

    }
}
