
namespace BotFacebook.API.Controller
{
    using BotFacebook.API.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    [Produces("application/json")]
    [Route("api/[controller]")]
    [RequireHttps]
    [ApiController]
    public class MessagerController : ControllerBase
    {
        private string fbToken = "...";
        private string postUrl = "https://graph.facebook.com/v2.6/me/messages";
        private string verifytoken = "...";

        [HttpGet]
        public async Task<IActionResult> WebHook(
            [FromQuery(Name = "hub.mode")] string mode,
            [FromQuery(Name = "hub.challenge")] string challenge,
            [FromQuery(Name = "hub.verify_token")] string verify_token)
        {
            try
            {
                if (verify_token != null && verify_token.Equals(verifytoken))
                    return await Task.FromResult(Ok(challenge));
                else
                    return await Task.FromResult(Ok(string.Empty));
            }
            catch
            {
                return await Task.FromResult(NotFound(403));
            }
        }

        [HttpPost]
        public async Task Webhook()
        {
            var json = (dynamic)null;
            try
            {
                using (StreamReader sr = new StreamReader(this.Request.Body))
                {
                    json = await sr.ReadToEndAsync();
                }

                MessagesProtocol data = JsonConvert.DeserializeObject<MessagesProtocol>(json);

                if (data != null)
                {
                    if (data.Entry != null)
                        foreach (var entry in data.Entry)
                            if (entry.Messagings != null)
                                foreach (var messaging in entry.Messagings)
                                    if (messaging.Message != null)
                                    {
                                        postToFB(messaging.Sender.Id, messaging.Message.Text);
                                    }

                }
            }
            catch (Exception ex)
            {
            }
        }

        private void postToFB(string recipientId, string messageText)
        {
            string messageTextAnswer = "RESPOSTA AUTOMATICA DE: " + messageText;
            string postParameters = string.Format("access_token={0}&recipient={1}&message={2}", fbToken, "{ id:" + recipientId + "}", "{ text:\"" + messageTextAnswer + "\"}");
            
            var client = new HttpClient();
            client.PostAsync(postUrl, new StringContent(postParameters, Encoding.UTF8, "application/json"));
        }

    }
}
