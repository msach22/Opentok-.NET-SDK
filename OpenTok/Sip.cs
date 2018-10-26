using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace OpenTokSDK
{
    public class Sip
    {
        internal Sip()
        {

        }

        internal void CopySip(Sip sip)
        {
            this.Id = sip.Id;
            this.ConnectionId = sip.ConnectionId;
            this.StreamId = sip.StreamId;
        }
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("streamId")]
        public string StreamId { get; set; }

    }
}
