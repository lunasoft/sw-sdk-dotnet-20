using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Web;
using SW.SDK.Helpers;
using SW.SDK.Entities;

namespace SW.SDK.Services.IssuerJson
{
    public abstract class IssuerJsonService : Services
    {
        protected IssuerJsonService(string url, string user, string password)
            : base(url, user, password)
        {
        }
        protected IssuerJsonService(string url, string token)
            : base(url, token)
        {
        }
        internal virtual HttpWebRequest RequestIssuerJson(string json, string version, string format)
        {
            this.SetupRequest();
            string reqString = "";
            if (format.Length != 0)
            {
                reqString = string.Format("/v3/cfdi33/issue/json/{0}/{1}", version, format);
            }
            else
            {
                reqString = string.Format("/v3/cfdi33/issue/json/{0}", version);
            }           
            byte[] requestData = Encoding.UTF8.GetBytes(reqString);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://services.test.sw.com.mx" + reqString);
            request.ContentType = "application/jsontoxml";
            request.Headers.Add("Authorization", "bearer " + Token);
            request.Method = WebRequestMethods.Http.Post;
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            return request;
        }


    }
}
