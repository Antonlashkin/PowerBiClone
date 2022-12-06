using Presenters.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;

namespace Presenters.Presenter
{
    public class InitPresenter : ViewPresenter<IView>
    {
        private IDataSourceAccessService _services;
        public override void InitView()
        {

        }
        public InitPresenter(IView view, IDataSourceAccessService service) : base(view)
        {
            _services = service;
        }
    }
}
