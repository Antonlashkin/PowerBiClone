using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataSourceRepositories;
using Entities;
using IServices;
using DataServices;

namespace DataSourceRepositories
{
    internal class DataSourceRepositories : IDataSourceRep
    {
        private Entitie entitie;
        private DataSourceAccessService dataSourceAccessService = new DataSourceAccessService();

        public DataSourceRepositories()
        {
            entitie = new Entitie();
        }
        
        public DataSourceRepositories(string fileName)
        {
            entitie = dataSourceAccessService.Read(fileName);
        }

        public Entitie GetEntitie
        {
            get { return entitie; }
        }
    }
}
