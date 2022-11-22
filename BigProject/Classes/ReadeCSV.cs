using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BigProject.Classes
{
    class ReaderCSV
    {

        public void reader(string FileName, DataCacheStorage data)
        {

            FileInfo fileInfo = new FileInfo(FileName);

            if (fileInfo.Extension == ".csv")
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string[] keys = sr.ReadLine().Split(' ');
                    foreach (string key in keys)
                    {
                        List<Object> row = new List<Object>();
                        data.DataColumn.Add(key, row);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] par = sr.ReadLine().Split(' ');
                        int i = 0;
                        foreach (string key in keys)
                        {
                            data.DataColumn[key].Add(par[i]);
                            i++;
                        }
                    }

                }
            }
            else throw new Exception("No such format");
        }
    }
}
