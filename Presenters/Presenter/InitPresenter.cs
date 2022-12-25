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
using IDataCacheStorage;

namespace Presenters.Presenter
{
    public class InitPresenter : ViewPresenter<IInitView>
    {
        private IDataSourceAccessService _services;
        private IDataCache cache;
        public override void InitView()
        {
        }
        public InitPresenter(IInitView view) : base(view)
        {
            cache= new DataCache();
        }

        public IDataSourceAccessService Service { get { return _services; }  set { _services = value; } }
        public IDataCache Cache { get { return cache; } set { cache = value; } }

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
                        _services = new CSVFileAccessService(cache);
                    }
                  
                    else if (fileInfo.Extension == ".txt")
                    {
                        _services = new TXTFileAccessService(cache);
                    }
                  
                    return _path;
                }
                else
                {
                    return null;
                }
            }
        }
        public FileInfo SelectFile(string filter)
        {
            using(OpenFileDialog fdb = new OpenFileDialog())
            {
                fdb.Filter = filter;
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                        //string _path = fdb.FileName;
                        FileInfo fileInfo = new FileInfo(fdb.FileName);
                    if (fileInfo.Extension == ".csv")
                    {
                        _services = new CSVFileAccessService(cache);
                    }
                    else if (fileInfo.Extension == ".txt")
                    {
                        _services = new TXTFileAccessService(cache);
                    }
                    view.FileNames.Items.Add(fileInfo.Name);
                    return fileInfo;
                }
                else
                {
                    return null;
                }
               
            }
        }
    }
}
