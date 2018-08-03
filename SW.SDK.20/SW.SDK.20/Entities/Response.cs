using Newtonsoft.Json;

namespace SW.SDK.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Response
    {
        [JsonProperty]
        public string status { get; set; }
        [JsonProperty]
        public string message { get; set; }
        [JsonProperty]
        public string messageDetail { get; set; }
    }
}
