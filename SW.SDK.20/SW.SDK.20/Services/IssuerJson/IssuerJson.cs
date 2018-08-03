using System;
using System.Collections.Generic;
using System.Text;
using SW.SDK.Helpers;

namespace SW.SDK.Services.IssuerJson
{
    public class IssuerJson : BaseIssuerJson
    {
        public IssuerJson(string url, string user, string password)
            : base(url, user, password)
        {
        }

        public IssuerJson(string url, string token)
            : base(url, token)
        {
        }

    }
}
