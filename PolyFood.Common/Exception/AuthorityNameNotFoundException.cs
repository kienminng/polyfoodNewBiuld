using System.Runtime.Serialization;

namespace PolyFood.Common.Exception;

[Serializable]
public class AuthorityNameNotFoundException : System.Exception
{
    public string AuthorityName { get; }
    

    public AuthorityNameNotFoundException(string message) : base(message)
    {
    }
    
    public AuthorityNameNotFoundException(string? message, string authorityName) : base(message)
    {
        AuthorityName = authorityName;
    }

    public AuthorityNameNotFoundException(string? message, System.Exception? innerException, string authorityName) : base(message, innerException)
    {
        AuthorityName = authorityName;
    }
}