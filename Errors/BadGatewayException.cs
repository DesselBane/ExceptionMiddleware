using System;
using System.Net;

namespace ExceptionMiddleware.Errors;

public class BadGatewayException : InvalidRestOperationException
{
    public BadGatewayException(Uri target, string customErrorCode, Exception innerException = null)
        : this($"Failed to reach {target}.", customErrorCode, innerException)
    {
    }

    public BadGatewayException(string message, string customErrorCode, Exception innerException = null) : base(message,
        customErrorCode, innerException)
    {
    }

    public override int ResponseCode => (int)HttpStatusCode.BadGateway;
}