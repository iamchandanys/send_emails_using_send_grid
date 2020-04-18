using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Send.Emails.Using.SendGrid
{
    public class TemplateData
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("otp")]
        public string Otp { get; set; }
    }
}
