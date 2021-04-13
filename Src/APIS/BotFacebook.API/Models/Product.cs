
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Product
    {
        public Product(IEnumerable<Element> elements)
        {
            Elements = elements;
        }

        public Product(string id, IEnumerable<Element> elements = null)
        {
            Id = id;
            Elements = elements;
        }

        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("elements")] public IEnumerable<Element> Elements { get; set; }
    }
}
