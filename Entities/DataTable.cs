using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DataTable
    {
        //Класс для хранения данных
        private List<string> _columnsName;
        private List<List<string>> _dataColumn;

        public DataTable()
        {
            _columnsName = new List<string>();
            _dataColumn = new List<List<string>>();
        }

        public List<string> ColumnsName { get { return _columnsName; } set { _columnsName = value; } }

        public List<List<string>> DataColumn { get { return _dataColumn; } set { _dataColumn = value; } }

        public override string ToString()
        {
            return base.ToString() + ":" + _columnsName.ToString() + ":" + _dataColumn.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + _columnsName.GetHashCode() + _dataColumn.GetHashCode();
        }

    }
}
