using System;
using System.Net;

namespace ExceptionMiddleware
{
    public class UnauthorizedException : InvalidRestOperationException
    {
        #region Constructors

        public UnauthorizedException(string message, string customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException) { }

        #endregion

        #region Properties

        public override int ResponseCode => (int) HttpStatusCode.Unauthorized;

        #endregion
    }
}