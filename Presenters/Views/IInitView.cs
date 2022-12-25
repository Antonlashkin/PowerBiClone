using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using IDataCacheStorage;
using IDataSourcePerositories;

namespace Presenters.Views
{
    public interface IInitView
    {
        IDataCache Data { get;}
        ListBox FileNames { get; }
        void HideView();
        void MakeVisible();
    }
}
