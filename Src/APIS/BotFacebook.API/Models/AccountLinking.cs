
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Note: authorization_code is only available when status is linked
    /// </summary>
    public class AccountLinking
    {
        public AccountLinking(string status, string authorizationCode)
        {
            Status = status;
            AuthorizationCode = authorizationCode;
        }

        /// <summary>
        /// linked or unlinked
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }

        /// <summary>
        /// Value of pass-through authorization_code provided in the Account Linking flow (https://developers.facebook.com/docs/messenger-platform/send-messages/buttons)
        /// </summary>
        [JsonProperty("authorization_code")] public string AuthorizationCode { get; set; }
    }
}
