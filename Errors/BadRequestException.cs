using System;

namespace ExceptionMiddleware.Errors
{
    public class BadRequestException : InvalidRestOperationException
    {
        public BadRequestException(string message, string customErrorCode, Exception innerException = null) : base(
            message, customErrorCode, innerException)
        {
        }

        public override int ResponseCode { get; } = 400;
    }
}