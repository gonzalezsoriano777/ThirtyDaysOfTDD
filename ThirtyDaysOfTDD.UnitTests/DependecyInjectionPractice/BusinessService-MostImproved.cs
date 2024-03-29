﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ThirtyDaysOfTDD.UnitTests.Dependecy_Injection_Practice
{
    public class BusinessServiceImproved
    {
        private IDataStoreProvider _dataStoreProvider;
        private ILoggingProvider _loggingProvider;
        private IWebServiceProvider _webServiceProvider;

        public BusinessServiceImproved(IDataStoreProvider dataStoreProvider,
            ILoggingProvider loggingProvider, IWebServiceProvider webServiceProvider)
        {
            _dataStoreProvider = dataStoreProvider;
            _loggingProvider = loggingProvider;
            _webServiceProvider = webServiceProvider;
        }
    }

    public class DataStoreProvider : IDataStoreProvider
    {

    }

    public interface IDataStoreProvider
    {

    }

    public class LoggingProvider : ILoggingProvider
    {

    }

    public interface ILoggingProvider
    {

    }

    public class WebServiceProvider : IWebServiceProvider
    {

    }

    public interface IWebServiceProvider
    {

    }

}