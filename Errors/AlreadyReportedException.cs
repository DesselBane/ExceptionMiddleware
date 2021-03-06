﻿using System;

namespace ExceptionMiddleware.Errors
{
    public class AlreadyReportedException : InvalidRestOperationException
    {
        public AlreadyReportedException(string message, string customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException)
        {
        }

        public override int ResponseCode => 208;
    }
}