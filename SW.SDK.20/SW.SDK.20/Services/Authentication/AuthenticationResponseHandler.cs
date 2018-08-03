using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Web;
using SW.SDK.Entities;
using SW.SDK.Helpers;

namespace SW.SDK.Services.Authentication
{
    internal class AuthenticationResponseHandler : ResponseHandler<AuthResponse>
    {
        public override AuthResponse HandleException(Exception ex)
        {
            return (AuthResponse)ex.ToAuthResponse();
        }
    }
}
