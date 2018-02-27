using System;
using System.Runtime.Serialization;

namespace ExceptionMiddleware
{
    [DataContract]
    public class ExceptionDTO
    {
        #region Properties

        [DataMember]
        public Guid ErrorCode { get; set; }

        [DataMember]
        public string ErrorReason { get; set; }

        #endregion

        #region Constructors

        public ExceptionDTO(InvalidRestOperationException ex)
        {
            ErrorCode   = ex.CustomErrorCode;
            ErrorReason = ex.Message;
        }

        public ExceptionDTO() { }

        #endregion
    }
}