
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// referral payload is only provided when the user sends a message from Facebook Shops product detail page.
    /// </summary>
    public class Referral
    {
        public Referral(Product product)
        {
            Product = product;
        }

        /// <summary>
        /// Product information
        /// </summary>
        [JsonProperty("product")] public Product Product { get; set; }
    }
}
