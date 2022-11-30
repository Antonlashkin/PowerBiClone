using Presenter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;

namespace Presenter.Presenter
{
    public class Presenter : ViewPresenter<IView>
    {
        private IService _services;
        public override void InitView()
        {
            view.ObjectData = _services.GetData();
        }
        public Presenter(IView view, IService service) : base(view)
        {
            _services = service;
        }
    }
}
