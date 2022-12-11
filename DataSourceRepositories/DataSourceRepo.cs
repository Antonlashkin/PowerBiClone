using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataSourcePerositories;
using Entities;

namespace DataSourceRepositories
{
    public class DataSourceRepo : IDataSourceRep
    {
        private DataTable _bufferData;

        public DataSourceRepo()
        {
            _bufferData = new DataTable();
        }

        public DataTable DataBuffer { get { return _bufferData; } set { _bufferData = value; } }

        public DataTable GetTable() { return _bufferData; }

        public void RemoveLastRow()
        {
            _bufferData.DataColumn.RemoveAt(_bufferData.DataColumn.Count - 1);
        }
    }
}
