
namespace BotFacebook.API.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Entry
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("time")] public Int64 Time { get; set; }
        [JsonProperty("messaging")] public IEnumerable<Messaging> Messagings { get; set; }
    }
}
