
namespace BotFacebook.API.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Both mids and watermark fields are used to determine which messages were delivered. watermark is always present and mids is sometimes present. mids provides delivery receipts on a per-message basis but may not be present (due to backward compatibility reasons with older Messenger clients). watermark is always present and is a timestamp indicating that all messages with a timestamp before watermark were delivered.
    /// </summary>
    public class Delivery
    {
        /// <summary>
        /// Array containing message IDs of messages that were delivered. Field may not be present.
        /// </summary>
        [JsonProperty("mids")] public IEnumerable<string> Mids { get; set; }

        /// <summary>
        /// All messages that were sent before this timestamp were delivered
        /// </summary>
        [JsonProperty("watermark")] public float Watermark { get; set; }
    }
}
