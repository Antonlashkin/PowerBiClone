using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IDataCacheStorage;
using IDataSourceRepositories;

namespace DataCacheStorage
{
    public class DataCache : IDataCache
    {
        private List<DataTable> _entitiesList;

        public DataCache()
        {
            _entitiesList = new List<DataTable>();
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
