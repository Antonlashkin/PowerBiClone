using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Presenters.Views
{
    public interface IView
    {
        DataTable ObjectData { get; set; }
    }
}
