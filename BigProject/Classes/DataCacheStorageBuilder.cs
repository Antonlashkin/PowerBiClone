using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.Classes
{
    public class DataCacheStorageBuilder
    {
        private DataCacheStorage dataCacheStorage;

        public DataCacheStorageBuilder() { 
        dataCacheStorage = new DataCacheStorage();
        }
        public DataCacheStorageBuilder(DataCacheStorage dataCacheStorage)
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
