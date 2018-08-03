using SW.SDK.Entities;
using SW.SDK.Helpers;
using Newtonsoft.Json;

namespace SW.SDK.Services.Authentication
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AuthResponse : Response
    {
        [JsonProperty]
        public Data data { get; set; }
    }
    [JsonObject(MemberSerialization.OptIn)]
    public partial class Data
    {
        [JsonProperty]
        public string token { get; set; }
    }
}
