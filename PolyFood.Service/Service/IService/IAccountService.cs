using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyFood.Service.Service.IService
{
    public interface IAccountService
    {
        bool Login(string username,string password);
    }
}
