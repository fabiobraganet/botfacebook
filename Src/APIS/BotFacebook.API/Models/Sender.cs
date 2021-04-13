
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;

    public class Sender
    {
        public Sender(string id, string userRef = "")
        {
            Id = id;
            UserRef = userRef;
        }


        /// <summary>
        /// O PSID (Número de identificação no escopo da Página) do usuário que acionou o evento de webhook.
        /// </summary>
        [JsonProperty("id")] public string Id { get; set; }

        /// <summary>
        /// O parâmetro user_ref do usuário que acionou o evento de webhook.Disponível somente para o evento de webhook do plugin de bate-papo.
        /// </summary>
        [JsonProperty("user_ref")] public string UserRef { get; set; }
    }
}
