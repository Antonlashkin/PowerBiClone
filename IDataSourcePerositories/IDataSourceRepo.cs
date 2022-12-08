using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IDataSourcePerositories
{
    public interface IDataSourceRep
    {
        DataTable GetTable();
    }
}
