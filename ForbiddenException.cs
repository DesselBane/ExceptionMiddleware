using System;
using System.Net;

namespace ExceptionMiddleware
{
    public class ForbiddenException : InvalidRestOperationException
    {
        #region Constructors

        public ForbiddenException(string message, string customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException) { }

        #endregion

        #region Properties

        public override int ResponseCode => (int) HttpStatusCode.Forbidden;

        #endregion
    }
}