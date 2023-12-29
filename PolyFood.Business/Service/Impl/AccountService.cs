using System.Data;
using System.Security.Claims;
using System.Text.RegularExpressions;
using PolyFood.Business.Service.IService;
using PolyFood.Common.Common;
using PolyFood.Common.Exception;
using PolyFood.DTOs.Request;
using PolyFood.DTOs.Request.Authen;
using PolyFood.DTOs.Response;
using PolyFood.Entity.Entity;
using PolyFood.Repository.Repository.IRepo;

namespace PolyFood.Business.Service.Impl;

public class AccountService : IAccountService
{
    private readonly IAccountRepo _accountRepo;
    private readonly IDecentralizationRepo _decentralizationRepo;
    private readonly IJwtService _jwtService;
    private readonly IMailSender _mailSender;
    private readonly IUserRepo _userRepo;

    public AccountService(IAccountRepo accountRepo,
        IJwtService jwtService,
        IDecentralizationRepo decentralizationRepo,
        IUserRepo userRepo, IMailSender mailSender)
    {
        _accountRepo = accountRepo;
        _jwtService = jwtService;
        _decentralizationRepo = decentralizationRepo;
        _userRepo = userRepo;
        _mailSender = mailSender;
    }

    public bool ChangePassword()
    {
        throw new NotImplementedException();
    }

    public bool ChangeStatus(string? username)
    {
        if (username is null) return false;
        var account = _accountRepo.FindByUsername(username);
        if (account is null) return false;
        account.Status = 1;
        return true;
    }

    public TokenModel Login(AuthenticationRequest request)
    {
        request.password = EndCode.EndCodeBase64(request.password);
        var account = _accountRepo.FindByUsernamePassword(request.usernameOrEmail, request.password);
        if (account == null) return null;
        var accessToken = CreateAccessToken(account);
        var refreshToken = _jwtService.GenerateRefreshToken();
        account.Token.RefreshToken = refreshToken;
        account.Token.RefreshTokenExpiryTime = DateTime.Now;
        _accountRepo.Update(account);
        return new TokenModel
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken
        };
    }

    public bool Register(RegisterRequest register, string authorName)
    {
        ValidateAccount(register.Email, register.UserName);
        ValidatePassword(register.Password);
        var role = ValidateAuthorityName(authorName);
        register.Password = EndCode.EndCodeBase64(register.Password);
        var account = register.ChangeToAccount();
  //      account.Decentralization = role;
        _accountRepo.Add(account);
        var accountId = account.AccountId;
        account = _accountRepo.GetById(accountId);
        if (account is null) throw new AccountNotFoundException(accountId);
        var token = CreateAccessToken(account);
        _mailSender.ConfirmEmailByUrl(account, token);
        return true;
    }

    private string CreateAccessToken(Account account)
    {
        if (account is null) return null;
  //      var Authority = _decentralizationRepo.GetById(account.Decentralization_Id.Value);
  //      var Authority_name = Authority.Authority_name;
        var Email = account.Users.Email;
        var claims = new List<Claim>
        {
            new("Id", account.AccountId.ToString()),
            new(ClaimTypes.Email, Email),
     //       new(ClaimTypes.Role, Authority_name),
            new(ClaimTypes.Name, account.Username)
        };
        var token = _jwtService.GenerateAccessToken(claims);
        return token;
    }

    private User? EmailIsExist(string email)
    {
        var result = _userRepo.FindByEmail(email);
        return result;
    }

    private Account? UsernameIsExist(string username)
    {
        var result = _accountRepo.FindByUsername(username);
        return result;
    }

    private void ValidateAccount(string email, string username)
    {
        var user = EmailIsExist(email);
        if (user != null) throw new DuplicateNameException(Constant.AccountException.EmailIsExist);

        var account = UsernameIsExist(username);
        if (account != null) throw new DuplicateNameException(Constant.AccountException.UsernameIsExist);
    }

    private Decentralization? ValidateAuthorityName(string authorName)
    {
        var result = _decentralizationRepo.FindByName(authorName);
        if (result is null)
            throw new AuthorityNameNotFoundException(Constant.Authority.AuthorityNameNotFound, authorName);
        return result;
    }

    private void ValidatePassword(string password)
    {
        var pattern = Constant.User.PasswordRegex;

        if (Regex.IsMatch(password, pattern)) throw new ArgumentException(Constant.User.PasswordRegexMessage);
    }
}