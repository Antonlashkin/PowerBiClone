using Presenters.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;
using System.Windows.Forms;
using System.IO;
using DataServices;
using DataCacheStorage;

namespace Presenters.Presenter
{
    public class InitPresenter : ViewPresenter<IView>
    {
        private IDataSourceAccessService _services;
        public override void InitView()
        {

        }
        public InitPresenter(IView view) : base(view)
        {
        }

        public IDataSourceAccessService Service { get { return _services; }  set { _services = value; } }

        public void ReadFile(string _fileName)
        {
            _services.reader(_fileName);
            DataCache.getInstance().AddTable(_services.GetData());
        }

        public string SelectFile()
        {
            using(OpenFileDialog fdb = new OpenFileDialog())
            {
                if(fdb.ShowDialog() == DialogResult.OK)
                {
                        string _path = fdb.FileName;
                        //string _path = fdb.FileName;
                        FileInfo fileInfo = new FileInfo(_path);
                        if (fileInfo.Extension == ".csv" && _services == null)
                        {
                            _services = new CSVFileAccessService();
                        }
                        else if (fileInfo.Extension == ".csv" && _services != null)
                        {
                            _services = new CSVFileAccessService(_services.GetData());
                        }
                        return _path;
                }
                else
                {
                    return null;
                }
               
            }
        }
    }
}
