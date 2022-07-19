using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDataAccess
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string databaseType)
        {
            switch (databaseType)
            {
                case "ListDataAccess":
                    return new ListDataAccess();
                case "SQLDataAccess":
                    return new SQLDataAccess();
                case "MongoDataAccess":
                    return new MongoDataAccess();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
