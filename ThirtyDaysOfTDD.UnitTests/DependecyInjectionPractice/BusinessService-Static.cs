using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysOfTDD.UnitTests.DependecyInjectionPractice
{
    public class BusinessServiceStatic
    {
        private SqlDataStoreProvider _dataStoreProvider =  new SqlDataStoreProvider();
        private DbLogginProvider _logginProvider = new DbLogginProvider();
        private ProdWebServiceProvider _webServiceProvider = new ProdWebServiceProvider();
    }

    public class SqlDataStoreProvider
    {

    }

    public class DbLogginProvider
    {

    }

    public class ProdWebServiceProvider
    {

    }
}
