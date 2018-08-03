using System;
using System.Collections.Generic;
using System.Text;
using SW.SDK.Helpers;
//using SW.SDK.Services.Pdf;
using System.Net;
/*
namespace SW.SDK.Services.Pdf
{
    
    public abstract class BasePdf : PdfService
    {

        public BasePdf(string url, string user, string password)
            : base(url, user, password)
        {
        }
        public BasePdf(string url, string token)
            : base(url, token)
        {
        }

        public virtual PdfResponse Pdf(string pdf)
        {
            PdfResponseHandler handler = new PdfResponseHandler();
            try
            {
                string format = "";
                var request = this.RequestPdf(json, format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
        public virtual PdfResponse Pdf(string pdf, bool isb64)
        {
            PdfResponseHandler handler = new PdfResponseHandler();
            try
            {
                string format = isb64 ? "b64" : "";
                var request = this.RequestPdf(json, format);
                return handler.GetResponse(request);
            }
            catch (Exception ex)
            {
                return handler.HandleException(ex);
            }
        }
    }
}
*/