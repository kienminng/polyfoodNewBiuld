using PolyFood.DTOs.Request;
using PolyFood.DTOs.Request.Authen;
using PolyFood.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyFood.Business.Service.IService
{
    public interface IAccountService
    {
        TokenModel Login(AuthenticationRequest request);

        bool Register(RegisterRequest register,string authorName);

        bool ChangeStatus(string username);

        bool ChangePassword();
    }
}
