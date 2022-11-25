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

        public void reader(string FileName, ref DataCacheStorage data)
        {

            FileInfo fileInfo = new FileInfo(FileName);

            if (fileInfo.Extension == ".csv")
            {
                DataCacheStorageBuilder dcsb = new DataCacheStorageBuilder();
                dcsb.setFileLocation(FileName);
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string[] keys = sr.ReadLine().Split(' ');
                    List<string> values = keys.ToList();
                    dcsb.setColumnNames(values);
                    List<List<string>> readData = new List<List<string>>();
                    while (!sr.EndOfStream)
                    {
                        string[] par = sr.ReadLine().Split(' ');
                        List<string> addedColumn = par.ToList();
                        readData.Add(addedColumn);
                    }
                    dcsb.setData(readData);

                }
                data = dcsb.build();
            }
            else throw new Exception("No such format");
        }
    }
}
