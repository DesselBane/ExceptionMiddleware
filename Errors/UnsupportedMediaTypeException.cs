using System;

namespace ExceptionMiddleware.Errors
{
    public class UnsupportedMediaTypeException : InvalidRestOperationException
    {
        public UnsupportedMediaTypeException(string message, string customErrorCode, Exception innerException = null)
            : base(message, customErrorCode, innerException)
        {
        }

        public override int ResponseCode => 415;
    }
}