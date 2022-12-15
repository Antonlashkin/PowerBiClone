using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;
using Entities;
using IVisuals;
using IDataSourcePerositories;

namespace DataServices
{
    public class DataVisualizationService : IBasicService
    {
        // Передача данных для визуализации
        private IVisual visual;

        public DataVisualizationService(IVisual visual)
        {
            this.visual = visual;
        }

        public int FindElement(string name)
        {
            throw new NotImplementedException();
        }

        public IDataSourceRep GetData()
        {
            return null;
        }

    }
}
