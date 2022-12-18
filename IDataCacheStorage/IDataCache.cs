using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataSourcePerositories;
using Entities;

namespace IDataCacheStorage
{
    public interface IDataCache
    {
        void AddTable(IDataSourceRep _bufferData);
        DataTable GetTable(int index);
        void Clear();
        List<DataTable> GetAllTables();
    }
}
