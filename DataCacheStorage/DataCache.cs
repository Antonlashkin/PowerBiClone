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
    [Serializable]
    public  class DataCache : IDataCache
    {
        private List<DataTable> _entitiesList;
        private static DataCache dataCache;

       private DataCache()
        {
            _entitiesList = new List<DataTable>();
        }

        public static DataCache GetInstance() 
        {
            if(dataCache == null) {
                dataCache = new DataCache();
            }
            return dataCache;
            
        }

        public List<DataTable> EntitiesList { get { return _entitiesList; } set { _entitiesList = value; } }

        public void AddTable(IDataSourceRep _bufferData)
        {
            _entitiesList.Add(_bufferData.GetTable());
        }

        public void Clear()
        {
            _entitiesList.Clear();
        }


        public override string ToString()
        {
            return base.ToString() + ":" + _entitiesList.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + _entitiesList.GetHashCode();
        }

        public DataTable GetTable(int index)
        {
            return _entitiesList.ElementAt(index);
        }

        public List<DataTable> GetAllTables()
        {
            return _entitiesList;
        }
    }
}
