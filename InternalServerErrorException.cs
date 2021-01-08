using System;
using System.Net;

namespace ExceptionMiddleware
{
    public class InternalServerErrorException : InvalidRestOperationException
    {
        public InternalServerErrorException(string message, string customErrorCode, Exception innerException = null) : base(message, customErrorCode, innerException)
        {
        }

        public override int ResponseCode { get; } = (int) HttpStatusCode.InternalServerError;
    }
}