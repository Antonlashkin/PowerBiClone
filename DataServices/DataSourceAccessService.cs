using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using IServices;
using Entities;

namespace DataServices
{
    public class DataSourceAccessService : IService
    {
        Entitie entitie;
        // Чтение файлов
        public DataSourceAccessService()
        {
            entitie = new Entitie();
        }

        public Entitie Read(string FileName)
        {
            entitie = new Entitie();
            FileInfo fileInfo = new FileInfo(FileName);

            switch (fileInfo.Extension)
            {
                case ".csv":
                    ReadCSV(FileName);
                    break;
                default:
                    throw new Exception("No such format");
            }
            return entitie;
        }

        private void ReadCSV(string FileName)
        {
            using (StreamReader stream = new StreamReader(FileName))
            {
                string[] keys = stream.ReadLine().Split(' ');
                List<string> values = keys.ToList();
                List<List<string>> readData = new List<List<string>>();
                while (!stream.EndOfStream)
                {
                    string[] par = stream.ReadLine().Split(' ');
                    List<string> addedColumn = par.ToList();
                    readData.Add(addedColumn);
                }
                entitie.ColumnsName = values;
                entitie.DataColumn = readData;
            }
        }

        Entitie IService.GetData() => entitie;
    }
}
