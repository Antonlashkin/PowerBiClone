using IDataSourceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IDataCacheStorage
{
    public interface IDataCache
    {
        void AddTable(IDataSourceRep _bufferData);
    }
}
