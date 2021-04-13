
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Message
    {
        public Message(
            string mid, 
            string text, 
            IEnumerable<Attachment> attachments)
        {
            Mid = mid;
            Text = text;
            Attachments = attachments;
        }

        [JsonProperty("mid")] public string Mid { get; set; }

        /// <summary>
        /// Indicates the message sent from the page itself
        /// </summary>
        [JsonProperty("is_echo")] public bool IsEcho { get; set; }

        /// <summary>
        /// ID of the app from which the message was sent
        /// </summary>
        [JsonProperty("app_id")] public string AppId { get; set; }

        /// <summary>
        /// Custom string passed to the Send API as the metadata field. Only present if the metadata property was set in the original message. (https://developers.facebook.com/docs/messenger-platform/reference/send-api#request)
        /// </summary>
        [JsonProperty("metadata")] public string Metadata { get; set; }

        /// <summary>
        /// Text of message
        /// </summary>
        [JsonProperty("text")] public string Text { get; set; }

        /// <summary>
        /// Optional custom data provided by the sending app
        /// </summary>
        [JsonProperty("quick_reply")] public QuickReply QuickReply { get; set; }

        /// <summary>
        /// Reference to the message id (mid) that this message is replying to
        /// </summary>
        [JsonProperty("reply_to")] public ReplyTo ReplyTo { get; set; }

        /// <summary>
        /// Array containing attachment data
        /// </summary>
        [JsonProperty("attachments")] public IEnumerable<Attachment> Attachments { get; set; }

        /// <summary>
        /// Referral of the message from Facebook Shops product details page.
        /// </summary>
        [JsonProperty("referral")] public Referral Referral { get; set; }
    }
}
