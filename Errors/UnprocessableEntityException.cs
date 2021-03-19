using System;

namespace ExceptionMiddleware.Errors
{
    public class UnprocessableEntityException : InvalidRestOperationException
    {
        #region Constructors

        public UnprocessableEntityException(string message, string customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException)
        {
        }

        #endregion

        #region Properties

        public override int ResponseCode => 422;

        #endregion
    }
}