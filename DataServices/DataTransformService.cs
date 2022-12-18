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
    public class DataTransformService : IBasicService
    {
        private IDataCache dataCache;

        public DataTransformService()
        {
            dataCache = DataCache.GetInstance();
        }
        public IDataCache GetData()
        {
            return dataCache;
        }
    }
}
