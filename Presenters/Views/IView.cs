using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IDataSourcePerositories;

namespace Presenters.Views
{
    public interface IView
    {
        IDataSourceRep Data { get;}
    }
}
