using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenter
{
    public abstract class ViewPresenter<Tview>
    {
        protected Tview view;

       public ViewPresenter(Tview view)
        {
            this.view = view;
        }

        abstract public void InitView();
        
    }
}
