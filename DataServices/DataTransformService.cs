using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IServices;
using IDataSourcePerositories;
using DataServices;
using DataSourceRepositories;
using DataCacheStorage;

namespace DataServices
{
    public class DataTransformService : IBasicService
    {
        private IDataSourceRep _repository;

        public DataTransformService(IDataSourceRep repo) {
            _repository = repo;
        }
        public DataTransformService()
        {
            _repository = new DataSourceRepo();
        }
        public IDataSourceRep GetData()
        {
            return _repository;
        }
    }
}
