using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenters.Views
{
    public interface IChartView
    {
        ComboBox ComboBoxX { get;}
        ComboBox ComboBoxY { get;}

    }
}
