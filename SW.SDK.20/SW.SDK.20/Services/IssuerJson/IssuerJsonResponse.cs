using System;
using System.Collections.Generic;
using System.Text;
using SW.SDK.Helpers;
using SW.SDK.Entities;
using Newtonsoft.Json;

namespace SW.SDK.Services.IssuerJson
{
    public class IssuerJsonResponseV1 : Response
    {
        [JsonProperty]
        public Data_TFD data { get; set; }
    }
    public class IssuerJsonResponseV2 : Response
    {
        [JsonProperty]
        public Data_CFDI_TFD data { get; set; }
    }
    public class IssuerJsonResponseV3 : Response
    {
        [JsonProperty]
        public Data_CFDI data { get; set; }
    }

    public class IssuerJsonResponseV4 : Response
    {
        [JsonProperty]
        public Data_Complete data { get; set; }
    }
    public class Data_TFD
    {
        [JsonProperty]
        public string tfd { get; set; }
    }

    public class Data_CFDI
    {
        [JsonProperty]
        public string cfdi { get; set; }
    }

    public class Data_CFDI_TFD : Data_TFD
    {
        [JsonProperty]
        public string cfdi { get; set; }
    }

    public class Data_Complete : Data_CFDI
    {
        [JsonProperty]
        public string cadenaOriginalSAT { get; set; }
        [JsonProperty]
        public string noCertificadoSAT { get; set; }
        [JsonProperty]
        public string noCertificadoCFDI { get; set; }
        [JsonProperty]
        public string uuid { get; set; }
        [JsonProperty]
        public string selloSAT { get; set; }
        [JsonProperty]
        public string selloCFDI { get; set; }
        [JsonProperty]
        public string fechaTimbrado { get; set; }
        [JsonProperty]
        public string qrCode { get; set; }
    }
}
