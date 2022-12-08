using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IDataCacheStorage;
using IDataSourcePerositories;

namespace DataCacheStorage
{
    public  class DataCache : IDataCache
    {
        private  static List<DataTable> _entitiesList;
        private static DataCache _cache;

        private DataCache()
        {
            _entitiesList = new List<DataTable>();
        }
        public static DataCache getInstance()
        {
            if (_cache == null)
                _cache = new DataCache();
            return _cache;


        }

        public List<DataTable> EntitiesList { get { return _entitiesList; } set { _entitiesList = value; } }

        public void AddTable(IDataSourceRep _bufferData)
        {
            _entitiesList.Add(_bufferData.GetTable());
        }



        public override string ToString()
        {
            return base.ToString() + ":" + _entitiesList.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + _entitiesList.GetHashCode();
        }

    }
}
