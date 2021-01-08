using System;
using System.Net;

namespace ExceptionMiddleware
{
    public class ServiceUnavailableException : InvalidRestOperationException
    {
        public ServiceUnavailableException(string message, string customErrorCode, Exception innerException = null) :
            base(message, customErrorCode, innerException)
        {
        }

        public override int ResponseCode { get; } = (int) HttpStatusCode.ServiceUnavailable;
    }
}