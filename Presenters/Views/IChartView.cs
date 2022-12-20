using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presenters.Views
{
    public interface IChartView
    {
        ComboBox ComboBoxX { get;}
        ComboBox ComboBoxY { get;}

        List<Chart> Charts { get;}
        void HideView();
        void MakeVisible();

    }
}
