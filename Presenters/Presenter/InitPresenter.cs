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
    public class InitPresenter : ViewPresenter<IInitView>
    {
        private IDataSourceAccessService _services;
        public override void InitView()
        {
            view.Data = _services.GetAllData();
        }
        public InitPresenter(IInitView view) : base(view)
        {
        }

        public IDataSourceAccessService Service { get { return _services; }  set { _services = value; } }

        public void ReadFile(string _fileName)
        {
            _services.reader(_fileName);
        }
        public string SaveFile(string filter)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = filter;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string _path = saveFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(_path);
                    if (fileInfo.Extension == ".csv")
                    {
                        _services = new CSVFileAccessService();
                    }
                   // else if (fileInfo.Extension == ".csv" && _services != null)
                   // {
                    //    _services = new CSVFileAccessService(_services.GetData());
                   // }
                    else if (fileInfo.Extension == ".txt")
                    {
                        _services = new TXTFileAccessService();
                    }
                   // else if (fileInfo.Extension == ".txt" && _services != null)
                   // {
                   //     _services = new TXTFileAccessService(_services.GetData());
                   // }
                    return _path;
                }
                else
                {
                    return null;
                }
            }
        }
        public string SelectFile(string filter)
        {
            using(OpenFileDialog fdb = new OpenFileDialog())
            {
                fdb.Filter = filter;
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                        string _path = fdb.FileName;
                        //string _path = fdb.FileName;
                        FileInfo fileInfo = new FileInfo(_path);
                    if (fileInfo.Extension == ".csv")
                    {
                        _services = new CSVFileAccessService();
                    }
                    else if (fileInfo.Extension == ".txt")
                    {
                        _services = new TXTFileAccessService();
                    }
                    view.FileNames.Items.Add(_path);
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
