
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;
    
    public class Attachment
    {
        public Attachment(string type, Payload payload = null)
        {
            Type = type;
            Payload = payload;
        }

        public Attachment(string type, string title, string url, Payload payload = null)
        {
            Type = type;
            Title = title;
            Url = url;
            Payload = payload;
        }

        /// <summary>
        /// audio, file, image, location, video or fallback
        /// </summary>
        [JsonProperty("type")] public string Type { get; set; }

        /// <summary>
        /// Title of attachment (optional)
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>
        /// URL of attachment (optional)
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// Payload of attachment(optional)
        /// </summary>
        [JsonProperty("payload")] public Payload Payload { get; set; }
    }
}
