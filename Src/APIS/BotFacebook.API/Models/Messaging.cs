
namespace BotFacebook.API.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public class Messaging
    {
        public Messaging(Sender sender, Recipient recipient, string timestamp, Message message)
        {
            Sender = sender;
            Recipient = recipient;
            Timestamp = timestamp;
            Message = message;
        }

        [JsonProperty("sender")] public Sender Sender { get; set; }
        [JsonProperty("recipient")] public Recipient Recipient { get; set; }
        [JsonProperty("timestamp")] public string Timestamp { get; set; }
        [JsonProperty("message")] public Message Message { get; set; }
        //[JsonProperty("messages")] public IEnumerable<Message> Messages { get; set; }
    }
}
