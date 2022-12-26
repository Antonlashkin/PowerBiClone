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
        void RemoveColoumn(int column);
        void RemoveTable(int column);
        void SelectElementsMoreThen(double value, int column);
        void SelectElementsLessThen(double value, int column);

        void ChangeElement(string newValue, int column, int row);
        void ReturnData();
    }
}
