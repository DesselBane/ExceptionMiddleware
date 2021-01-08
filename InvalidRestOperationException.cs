using System;

namespace ExceptionMiddleware
{
    public abstract class InvalidRestOperationException : InvalidOperationException
    {
        #region Constructors

        protected InvalidRestOperationException(string message, string customErrorCode, Exception innerException = null)
            : base(message, innerException)
        {
            CustomErrorCode = customErrorCode;
        }
        

        #endregion

        #region Properties

        public abstract int  ResponseCode    { get; }
        public          string CustomErrorCode { get; }

        #endregion
    }
}