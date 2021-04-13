
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class MessagesProtocol
    {
        [JsonProperty("object")] public string FacebookObject { get; set; }
        [JsonProperty("entry")] public IEnumerable<Entry> Entry { get; set; }
    }
}
