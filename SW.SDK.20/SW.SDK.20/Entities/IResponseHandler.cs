using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SW.SDK.Entities
{
    internal interface IResponseHandler
    {
        SW.SDK.Entities.Response GetResponse(WebRequest request);
        SW.SDK.Entities.Response HandleException(Exception ex);
    }
}
