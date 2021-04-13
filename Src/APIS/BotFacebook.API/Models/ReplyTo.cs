
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;

    public class ReplyTo
    {
        [JsonProperty("mid")] public string Mid { get; set; }
    }
}
