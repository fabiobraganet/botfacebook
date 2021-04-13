
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;

    public class Recipient
    {
        public Recipient(string id)
        {
            Id = id;
        }

        /// <summary>
        /// Seu ID da Página
        /// </summary>
        [JsonProperty("id")] public string Id { get; set; }
    }
}
