﻿using System;
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
                using (StreamReader stream = new StreamReader(FileName))
                {
                    char separator = DetectSeparator(FileName);
                    string[] keys = stream.ReadLine().Split(separator);
                    List<string> values = keys.ToList();
                    List<List<string>> readData = new List<List<string>>();
                    while (!stream.EndOfStream)
                    {
                        string[] par = stream.ReadLine().Split(separator);
                        List<string> addedColumn = par.ToList();
                        readData.Add(addedColumn);
                    }
                    data.GetTable().ColumnsName = values;
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

        public static char DetectSeparator(string csvFilePath)
        {
            string[] lines = File.ReadAllLines(csvFilePath);
            return DetectSeparator(lines);
        }

        public static char DetectSeparator(string[] lines)
        {
            char[] SeparatorChars = { ';', '|', '\t', ',' };
            var q = SeparatorChars.Select(sep => new
            { Separator = sep, Found = lines.GroupBy(line => line.Count(ch => ch == sep)) })
                    .OrderByDescending(res => res.Found.Count(grp => grp.Key > 0))
                    .ThenBy(res => res.Found.Count())
                    .First();

            return q.Separator;
        }

    }
}