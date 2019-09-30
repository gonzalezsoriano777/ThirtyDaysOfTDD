using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysOfTDD.UnitTests.DependecyInjectionPractice
{
    public class BusinessService_Improved
    {
        private DataStoreProvider _dataStoreProvider;
        private LogginProvider _logginProvider;
        private WebServiceProvider _webServiceProvider;

        public BusinessService_Improved(DataStoreProvider dataStoreProvider, 
            LogginProvider logginProvider, WebServiceProvider webServiceProvider)

        {
            _dataStoreProvider = dataStoreProvider;
            _logginProvider = logginProvider;
            _webServiceProvider = webServiceProvider;
        }

    }


    public class DataStoreProvider
    {

    }

    public class LogginProvider
    {

    }

    public class WebServiceProvider
    {

    } 
}
