using System;

namespace ExceptionMiddleware
{
    public class UnprocessableEntityException : InvalidRestOperationException
    {
        #region Properties

        public override int ResponseCode => 422;

        #endregion

        #region Constructors

        public UnprocessableEntityException(string message, Guid customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException)
        {
        }

        #endregion
    }
}