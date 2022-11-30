using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServices;
using Entities;
using IVisuals;

namespace DataServices
{
    public class DataVizualizationService : IService
    {
        // Передача данных для визуализации
        private IVisual visual;

        public DataVizualizationService(IVisual visual)
        {
            this.visual = visual;
        }

        public Entitie GetData()
        {
            return null;
        }

    }
}
