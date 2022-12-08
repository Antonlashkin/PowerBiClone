using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper;
using IDataSourcePerositories;
using IServices;
using DataSourceRepositories;

namespace DataServices
{
    public class CSVFileAccessService : IDataSourceAccessService
    {
        private IDataSourceRep data;

        public CSVFileAccessService(IDataSourceRep data)
        {
            this.data = data;
        }
        public CSVFileAccessService()
        {
            data = new DataSourceRepo();
        }

        public IDataSourceRep GetData()
        {
            return data;
        }

        public bool reader(string FileName)
        {
            FileInfo fileInfo = new FileInfo(FileName);

                using (StreamReader sr = new StreamReader(FileName))
                {
                    string[] keys = sr.ReadLine().Split(';');
                    List<string> values = keys.ToList();
                    data.GetTable().ColumnsName = values;
                    List<List<string>> readData = new List<List<string>>();
                    while (!sr.EndOfStream)
                    {
                        string[] par = sr.ReadLine().Split(';');
                        List<string> addedColumn = par.ToList();
                        readData.Add(addedColumn);
                    }
                    data.GetTable().DataColumn = readData;
                }
                return true;
        }

        public bool writer(string FileName)
        {
            using (var writer = new StreamWriter("D:/DataWriter.csv", false, Encoding.GetEncoding("windows-1251")))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("ru-Ru"))
                {
                    HasHeaderRecord = false,
                    Delimiter = ";"
                };
                using (var csv = new CsvWriter(writer, csvConfig))
                {
                    csv.WriteField(data.GetTable().ColumnsName);
                    foreach (var rows in data.GetTable().DataColumn)
                    {
                        csv.NextRecord();
                        csv.WriteField(rows);
                    }

                }
            }
            return true;
        }
    }
}
