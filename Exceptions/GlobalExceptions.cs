using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhcs_agent.Exceptions;

public class GlobalExceptions
{
    #region jwt token invalid
    public class TokenInvalidExceptions : Exception
    {
        public TokenInvalidExceptions(string message) : base(message) { }
    }
    #endregion

    #region jwt token expired
    public class TokenExpiredExceptions : Exception
    {
        public TokenExpiredExceptions(string message) : base(message) { }
    }
    #endregion

    #region login invalid
    public class LoginInvalid : Exception
    {
        public LoginInvalid(string message) : base(message) { }
    }
    #endregion

    #region user login blocked
    public class UserBlocked : Exception
    {
        public UserBlocked(string message) : base(message) { }
    }
    #endregion

    #region data already exists
    public class RecordAlreadyExists : Exception
    {
        public RecordAlreadyExists(string message) : base(message) { }
    }
    #endregion

    #region master code invalid update
    public class CodeInvalidUpdate : Exception
    {
        public CodeInvalidUpdate(string message) : base(message) { }
    }
    #endregion

    #region data already used
    public class RecordUsed : Exception
    {
        public RecordUsed(string message) : base(message) { }
    }
    #endregion

    #region payload parameter null
    public class PayloadNull : Exception
    {
        public PayloadNull(string message) : base(message) { }
    }
    #endregion

    #region record not found
    public class RecordNotFound : Exception
    {
        public RecordNotFound(string message) : base(message) { }
    }
    #endregion

    #region record transaction not found
    public class TransactionRecordNotFound : Exception
    {
        public TransactionRecordNotFound(string message) : base(message) { }
    }
    #endregion

    #region forbidden access
    public class ForbiddenExceptions : Exception
    {
        public ForbiddenExceptions(string message) : base(message) { }
    }
    #endregion

    #region feature access not valid
    public class FeatureNotValid : Exception
    {
        public FeatureNotValid(string message) : base(message) { }
    }
    #endregion

    #region unauthorized access
    public class UnauthorizedAccess : Exception
    {
        public UnauthorizedAccess(string message) : base(message) { }
    }
    #endregion

    #region unauthorized access
    public class UserGroupNotFound : Exception
    {
        public UserGroupNotFound(string message) : base(message) { }
    }
    #endregion

    #region ftp connection timeout
    public class FTPConnectionExceptions : Exception
    {
        public FTPConnectionExceptions(string message) : base(message) { }
    }
    #endregion

    #region service connection timeout
    public class ServiceConnectionTimeout : Exception
    {
        public ServiceConnectionTimeout(string message) : base(message) { }
    }
    #endregion

    #region service internal error
    public class ServiceInternalError : Exception
    {
        public ServiceInternalError(string message) : base(message) { }
    }
    #endregion

    #region transaction rollback
    public class TransactionRollback : Exception
    {
        public TransactionRollback(string message) : base(message) { }
    }
    #endregion

    #region document transaction rollback
    public class TransactionRollbackDocument : Exception
    {
        public TransactionRollbackDocument(string message) : base(message) { }
    }
    #endregion

    #region document not found
    public class DocumentNotFound : Exception
    {
        public DocumentNotFound(string message) : base(message) { }
    }
    #endregion

    #region menu not valid to parent menu
    public class MenuNotValid : Exception
    {
        public MenuNotValid(string message) : base(message) { }
    }
    #endregion

    #region pcn effective date not valid
    public class PcnDateNotPermitted : Exception
    {
        public PcnDateNotPermitted(string message) : base(message) { }
    }
    #endregion

    #region pcn iniator validate
    public class PcnInitiatorSelectPermitted : Exception
    {
        public PcnInitiatorSelectPermitted(string message) : base(message) { }
    }
    #endregion

    #region pcn has active
    public class HasPcnActive : Exception
    {
        public HasPcnActive(string message) : base(message) { }
    }
    #endregion

    #region pcn matrix validate
    public class PcnMatrixValidate : Exception
    {
        public PcnMatrixValidate(string message) : base(message) { }
    }
    #endregion

    #region services error exception
    public class ServiceApiException : Exception
    {
        public ServiceApiException(string message) : base(message) { }
    }
    #endregion

    #region rabbit connection unreachable
    public class BrokerUnreachableException : Exception
    {
        public BrokerUnreachableException(string message) : base(message) { }
    }
    #endregion

    #region api key invalid
    public class ApiKeyInvalid : Exception
    {
        public ApiKeyInvalid(string message) : base(message) { }
    }
    #endregion

    #region trustee data invalid
    public class TrusteeInvalid : Exception
    {
        public TrusteeInvalid(string message) : base(message) { }
    }
    #endregion
}
