using IDataCacheStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    public interface ITransformmationService
    {
        IDataCache GetData();
        void RemoveRow(int row);
    }
}
