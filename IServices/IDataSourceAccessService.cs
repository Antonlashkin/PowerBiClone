using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataCacheStorage;
using IDataSourcePerositories;

namespace IServices
{
    public interface IDataSourceAccessService
    {
        bool reader(string FileName);
        bool writer(string FileName);

        IDataSourceRep GetData();
        IDataCache GetAllData();
    }
}
