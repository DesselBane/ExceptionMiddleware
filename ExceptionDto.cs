using System.Runtime.Serialization;
using ExceptionMiddleware.Errors;

namespace ExceptionMiddleware
{
    [DataContract]
    public class ExceptionDTO
    {
        #region Properties

        [DataMember] public string ErrorCode { get; set; }

        [DataMember] public string ErrorReason { get; set; }

        #endregion

        #region Constructors

        public ExceptionDTO(InvalidRestOperationException ex)
        {
            ErrorCode = ex.CustomErrorCode;
            ErrorReason = ex.Message;
        }

        public ExceptionDTO()
        {
        }

        #endregion
    }
}