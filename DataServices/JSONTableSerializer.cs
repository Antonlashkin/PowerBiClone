using System;
using System.IO;
using System.Runtime.CompilerServices;
using DocumentFormat.OpenXml.Bibliography;
using IDataCacheStorage;
using IDataSourcePerositories;
using IServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using DataCacheStorage;
using System.Collections.Generic;
using Entities;
using System.Text;

namespace DataServices
{
    public class JsonTableSerializer : IDataSourceAccessService
    {
        private IDataCache _dataCache;
        public JsonTableSerializer()
        {
            _dataCache = new DataCache();
        }

        public JsonTableSerializer(ref IDataCache dataCache)
        {
            _dataCache = dataCache;
        }

        public bool reader(string fileName)
        {
            try
            {
                string jsonString = File.ReadAllText(fileName);
                var tables = JsonSerializer.Deserialize<List<DataTable>>(jsonString);
                System.Console.WriteLine(tables.Count);
                _dataCache.SetAllTables(tables);
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public bool writer(string fileName)
        {
            try
            {

                System.Console.WriteLine(_dataCache.GetAllTables().Count);
                string jsonString = JsonSerializer.Serialize(_dataCache.GetAllTables());
                File.WriteAllText(fileName, jsonString);
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public IDataCache Cache
        {
            get => _dataCache;
            set => _dataCache = value;
        }

        public IDataSourceRep GetData()
        {
            throw new System.NotImplementedException();
        }

        public IDataCache GetAllData()
        {
            return _dataCache;
        }
    }
}