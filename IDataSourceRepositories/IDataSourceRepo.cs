using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace IDataSourceRepositories
{
    public interface IDataSourceRep
    {
        DataTable GetTable();
    }
}
