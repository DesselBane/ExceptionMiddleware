using System;
using System.Net;

namespace ExceptionMiddleware
{
    public class UnauthorizedException : InvalidRestOperationException
    {
        #region Properties

        public override int ResponseCode => (int) HttpStatusCode.Unauthorized;

        #endregion

        #region Constructors

        public UnauthorizedException(string message, Guid customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException)
        {
        }

        #endregion
    }
}