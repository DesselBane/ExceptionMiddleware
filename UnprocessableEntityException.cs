using System;

namespace ExceptionMiddleware
{
    public class UnprocessableEntityException : InvalidRestOperationException
    {
        #region Constructors

        public UnprocessableEntityException(string message, Guid customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException) { }

        #endregion

        #region Properties

        public override int ResponseCode => 422;

        #endregion
    }
}