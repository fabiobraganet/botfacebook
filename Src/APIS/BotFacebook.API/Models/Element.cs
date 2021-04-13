
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;
    
    public class Element
    {
        public Element(
            string id, 
            string retailerId, 
            string imageUrl, 
            string title, 
            string subtitle)
        {
            Id = id;
            RetailerId = retailerId;
            ImageUrl = imageUrl;
            Title = title;
            Subtitle = subtitle;
        }

        /// <summary>
        /// Product ID from Facebook product catalog
        /// </summary>
        [JsonProperty("id")] public string Id { get; set; }

        /// <summary>
        /// External ID that is associated with the Product. (ex: SKU/ Content ID)
        /// </summary>
        [JsonProperty("retailer_id")] public string RetailerId { get; set; }

        /// <summary>
        /// URL of product
        /// </summary>
        [JsonProperty("image_url")] public string ImageUrl { get; set; }

        /// <summary>
        /// Title of product
        /// </summary>
        [JsonProperty("title")] public string Title { get; set; }

        /// <summary>
        /// Subtitle of product
        /// </summary>
        [JsonProperty("subtitle")] public string Subtitle { get; set; }
    }
}
