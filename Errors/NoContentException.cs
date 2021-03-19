using System;
using System.Net;

namespace ExceptionMiddleware.Errors
{
    public class NoContentException : InvalidRestOperationException
    {
        #region Constructors

        public NoContentException(string message, string customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException)
        {
        }

        #endregion

        #region Properties

        #region Overrides of InvalidRestOperationException

        public override int ResponseCode => (int) HttpStatusCode.NoContent;

        #endregion

        #endregion
    }
}