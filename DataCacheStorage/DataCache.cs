using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataCacheStorage
{
    public class DataCache
    {
        private List<Entitie> _entitiesList;

        public DataCache()
        {
            _entitiesList = new List<Entitie>();    
        }
        public List<Entitie> EntitiesList { get { return _entitiesList; } set { _entitiesList = value; } }
    }
}
