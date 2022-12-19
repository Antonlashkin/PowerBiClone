using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;
using Entities;
using IVisuals;
using IDataSourcePerositories;
using IDataCacheStorage;

namespace DataServices
{
    public class DataVisualizationService : IBasicService
    {
        // Передача данных для визуализации
        private IVisual visual;
        private IDataCache dataCache;

        public DataVisualizationService(IVisual visual)
        {
            this.visual = visual;
        }
        public DataVisualizationService()
        {
           
        }

        public int FindElement(string name)
        {
            throw new NotImplementedException();
        }

        public IDataCache GetData()
        {
            return dataCache;
        }

    }
}
