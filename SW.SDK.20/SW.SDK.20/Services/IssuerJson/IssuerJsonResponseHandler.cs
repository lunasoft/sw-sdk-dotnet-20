using System;
using System.Collections.Generic;
using System.Text;
using SW.SDK.Helpers;
using SW.SDK.Services.IssuerJson;

namespace SW.SDK.Services.IssueJson
{
    internal class IssuerJsonResponseHandlerV1 : ResponseHandler<IssuerJsonResponseV1>
    {
        public override IssuerJsonResponseV1 HandleException(Exception ex)
        {
            return ex.ToIssuerJsonResponseV1();
        }
    }
    internal class IssuerJsonResponseHandlerV2 : ResponseHandler<IssuerJsonResponseV2>
    {
        public override IssuerJsonResponseV2 HandleException(Exception ex)
        {
            return ex.ToIssuerJsonResponseV2();
        }
    }
    internal class IssuerJsonResponseHandlerV3 : ResponseHandler<IssuerJsonResponseV3>
    {
        public override IssuerJsonResponseV3 HandleException(Exception ex)
        {
            return ex.ToIssuerJsonResponseV3();
        }
    }
    internal class IssuerJsonResponseHandlerV4 : ResponseHandler<IssuerJsonResponseV4>
    {
        public override IssuerJsonResponseV4 HandleException(Exception ex)
        {
            return ex.ToIssuerJsonResponseV4();
        }
    }
}
