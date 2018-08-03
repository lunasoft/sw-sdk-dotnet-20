using System;
using System.IO;
using System.Net;
using System.Web;
using SW.SDK.Helpers;
using SW.SDK.Services;

namespace SW.SDK.Services.Authentication
{
    public class Authentication : AuthenticationService
    {
        AuthenticationResponseHandler _handler;
        public Authentication(string url, string user, string password)
            : base(url, user, password)
        {
            _handler = new AuthenticationResponseHandler();
        }
        public override AuthResponse GetToken()
        {
            try
            {
                new AuthenticationValidation(Url, User, Password, Token);
                var request = (HttpWebRequest)WebRequest.Create(Url + "security/authenticate");

                request.ContentType = "application/json";
                request.ContentLength = 0;
                request.Method = WebRequestMethods.Http.Post;
                request.Headers.Add("user", User);
                request.Headers.Add("password", Password);
                request.Proxy = null;

                return _handler.GetResponse(request);
            }
            catch (Exception e)
            {
                return _handler.HandleException(e);
            }
        }
    }
}
