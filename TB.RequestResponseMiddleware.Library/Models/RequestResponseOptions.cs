﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB.RequestResponseMiddleware.Library.Models
{
    public class RequestResponseOptions
    {
        internal Func<RequestResponseContext, Task> ReqResHandler { get; set; }
        internal ILoggerFactory LoggerFactory;
        internal LoggingOptions LoggingOptions;

        public void UseHandler(Func<RequestResponseContext, Task> reqResHandler)
        {
            ReqResHandler = reqResHandler;
        }

        public void UseLogger(ILoggerFactory loggerFactory, Action<LoggingOptions> loggingAction) 
        {
            LoggingOptions = new LoggingOptions();
            loggingAction(LoggingOptions);

            LoggerFactory = loggerFactory;
        }
    }
}
