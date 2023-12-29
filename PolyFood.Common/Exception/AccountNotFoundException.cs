using System.Runtime.Serialization;

namespace PolyFood.Common.Exception;

[Serializable]
public class AccountNotFoundException : System.Exception
{
    public int AccountId;

    public AccountNotFoundException(int accountId)
    {
        AccountId = accountId;
    }

    protected AccountNotFoundException(SerializationInfo info, StreamingContext context, int accountId) : base(info, context)
    {
        AccountId = accountId;
    }

    public AccountNotFoundException(string? message, int accountId) : base(message)
    {
        AccountId = accountId;
    }

    public AccountNotFoundException(string? message, System.Exception? innerException, int accountId) : base(message, innerException)
    {
        AccountId = accountId;
    }

    public override string ToString()
    {
        return $"Account Id {AccountId} Not Found";
    }
}