namespace PolyFood.DTOs.Request;

public class AuthenticationRequest
{
    public string usernameOrEmail { get; set; }
    public string password { get; set; }
}