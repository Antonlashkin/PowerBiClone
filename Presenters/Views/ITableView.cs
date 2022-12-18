using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenters.Views
{
    public interface ITableView
    {
        DataGridView DataGridView { get;}
        void HideView();
        void MakeVisible();
    }
}
