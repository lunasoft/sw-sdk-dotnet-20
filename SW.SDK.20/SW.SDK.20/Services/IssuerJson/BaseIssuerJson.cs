using System;
using System.Collections.Generic;
using System.Text;
using SW.SDK.Helpers;
using SW.SDK.Services.IssueJson;
using System.Net;

namespace SW.SDK.Services.IssuerJson
{
    public abstract class BaseIssuerJson : IssuerJsonService
    {

        public BaseIssuerJson(string url, string user, string password)
            : base(url, user, password)
        {
        }
        public BaseIssuerJson(string url, string token)
            : base(url, token)
        {
        }

        public virtual IssuerJsonResponseV1 EmisionTimbradoJsonV1(string json)
        {
            IssuerJsonResponseHandlerV1 handler = new IssuerJsonResponseHandlerV1();
            try
            {
                string format = "";
                var request = this.RequestIssuerJson(json, StampTypes.v1.ToString(), format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
        public virtual IssuerJsonResponseV1 EmisionTimbradoJsonV1(string json, bool isb64)
        {
            IssuerJsonResponseHandlerV1 handler = new IssuerJsonResponseHandlerV1();
            try
            {
                string format = isb64 ? "b64" : "";
                var request = this.RequestIssuerJson(json, StampTypes.v1.ToString(), format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }

        public virtual IssuerJsonResponseV2 EmisionTimbradoJsonV2(string json)
        {
            IssuerJsonResponseHandlerV2 handler = new IssuerJsonResponseHandlerV2();
            try
            {
                string format = "";
                var request = this.RequestIssuerJson(json, StampTypes.v2.ToString(), format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
        public virtual IssuerJsonResponseV2 EmisionTimbradoJsonV2(string json, bool isb64)
        {
            IssuerJsonResponseHandlerV2 handler = new IssuerJsonResponseHandlerV2();
            try
            {
                string format = isb64 ? "b64" : "";
                var request = this.RequestIssuerJson(json, StampTypes.v2.ToString(), format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }

        public virtual IssuerJsonResponseV3 EmisionTimbradoJsonV3(string json)
        {
            IssuerJsonResponseHandlerV3 handler = new IssuerJsonResponseHandlerV3();
            try
            {
                string format = "";
                var request = this.RequestIssuerJson(json, StampTypes.v3.ToString(), format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
        public virtual IssuerJsonResponseV3 EmisionTimbradoJsonV3(string json, bool isb64)
        {
            IssuerJsonResponseHandlerV3 handler = new IssuerJsonResponseHandlerV3();
            try
            {
                string format = isb64 ? "b64" : "";
                var request = this.RequestIssuerJson(json, StampTypes.v3.ToString(), format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }

        public virtual IssuerJsonResponseV4 EmisionTimbradoJsonV4(string json)
        {
            IssuerJsonResponseHandlerV4 handler = new IssuerJsonResponseHandlerV4();
            try
            {
                string format = "";
                var request = this.RequestIssuerJson(json, StampTypes.v4.ToString(), format);
                var response = handler.GetResponse(request);
                return response;
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
        public virtual IssuerJsonResponseV4 EmisionTimbradoJsonV4(string json, bool isb64)
        {
            IssuerJsonResponseHandlerV4 handler = new IssuerJsonResponseHandlerV4();
            try
            {
                string format = isb64 ? "b64" : "";
                var request = this.RequestIssuerJson(json, StampTypes.v4.ToString(), format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }

    }
}
