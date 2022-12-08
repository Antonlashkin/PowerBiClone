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
    public class DataVizualizationService : IBasicService
    {
        // Передача данных для визуализации
        private IVisual visual;

        public DataVizualizationService(IVisual visual)
        {
            this.visual = visual;
        }

        public IDataSourceRep GetData()
        {
            return null;
        }

    }
}
