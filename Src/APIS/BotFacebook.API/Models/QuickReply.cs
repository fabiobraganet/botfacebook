
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;

    public class QuickReply
    {
        [JsonProperty("payload")] public string Payload { get; set; }
    }
}
