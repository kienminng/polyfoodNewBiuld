using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyFood.Common.Common
{
    public class EndCode
    {
        public static string EndCodeBase64(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            string encodedPassword = Convert.ToBase64String(passwordBytes);

            return encodedPassword;
        }
    }
}
