using System;
using System.Net;

namespace ExceptionMiddleware.Errors;

public class NotImplementedException : InvalidRestOperationException
{
    public NotImplementedException(string message, string customErrorCode, Exception innerException = null) : base(message, customErrorCode, innerException)
    {
    }

    public override int ResponseCode => (int)HttpStatusCode.NotImplemented;
}