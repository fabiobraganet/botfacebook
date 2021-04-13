
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;

    public class Payload
    {
        public Payload(string title, string url, Product product = null)
        {
            Title = title;
            Url = url;
            Product = product;
        }

        public Payload(string title, string url, string stickerId, Product product = null)
        {
            Title = title;
            Url = url;
            Product = product;
            StickerId = stickerId;
        }

        /// <summary>
        /// URL of the attachment type. Applicable to attachment type: audio, file, image, location, video, fallback
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// Title of the attachment. Applicable to attachment type: fallback
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>
        /// Persistent id of this sticker, for example 369239263222822 references the Like sticker. Applicable to attachment type: image only if a sticker is sent.
        /// </summary>
        [JsonProperty("sticker_id")] public string StickerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product")] public Product Product { get; set; }
    }
}
