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

        object CurrentChart { get; }
        List <Chart> Charts { get; set; }
        ListBox ChartsBox { get; }
        void HideView();
        void MakeVisible();

    }
}
