using System;
using System.IO;
using System.Net;
using System.Web;
using SW.SDK.Helpers;

namespace SW.SDK.Services.Authentication
{
    public abstract class AuthenticationService : Services
    {

        public AuthenticationService(string url, string user, string password)
            : base(url, user, password)
        {
        }
        public abstract AuthResponse GetToken();
    }
}
