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

       public DataCache()
        {
            _entitiesList = new List<DataTable>();
        }

        public List<DataTable> EntitiesList { get { return _entitiesList; } set { _entitiesList = value; } }

        public void SetAllTables(List<DataTable> entitiesList)
        {
            _entitiesList = entitiesList;

            EntitiesList = entitiesList;
        }

        public void AddTable(IDataSourceRep _bufferData)
        {
            _entitiesList.Add(_bufferData.GetTable());
        }

        public void AddTable(DataTable table)
        {
            _entitiesList.Add(table);
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

        public object Clone()
        {
            DataCache cloned= new DataCache();
            foreach(DataTable table in _entitiesList)
            {
                cloned.AddTable((DataTable)table.Clone());
            }
            return cloned;
        }

        public void Clone(IDataCache data)
        {
            foreach (DataTable table in data.GetAllTables())
            {
                _entitiesList.Add((DataTable)table.Clone());
            }
        }
    }
}
