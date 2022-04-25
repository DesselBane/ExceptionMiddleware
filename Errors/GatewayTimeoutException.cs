using System;
using System.Net;

namespace ExceptionMiddleware.Errors;

public class GatewayTimeoutException : InvalidRestOperationException
{
    public GatewayTimeoutException(Uri target, TimeSpan timeout, string customErrorCode,
        Exception innerException = null) : this(
        $"Timed out waiting for a response from {target}. Waited for {timeout:o}", customErrorCode,
        innerException)
    {
    }

    public GatewayTimeoutException(string message, string customErrorCode, Exception innerException = null) : base(
        message, customErrorCode, innerException)
    {
    }

    public override int ResponseCode => (int)HttpStatusCode.GatewayTimeout;
}