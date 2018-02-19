﻿using System;
using System.Net;

namespace ExceptionMiddleware
{
    public class ConflictException : InvalidRestOperationException
    {
        #region Properties

        public override int ResponseCode => (int) HttpStatusCode.Conflict;

        #endregion

        #region Constructors

        public ConflictException(string message, Guid customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException)
        {
        }

        #endregion
    }
}