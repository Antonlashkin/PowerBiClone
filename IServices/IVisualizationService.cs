using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IDataSourcePerositories;
using IDataCacheStorage;

namespace IServices
{
    public interface IBasicService
    {
       IDataCache GetData();
    }
}
