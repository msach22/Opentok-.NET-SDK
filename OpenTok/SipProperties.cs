using System.Collections.Generic;

namespace OpenTokSDK
{
    public class SipProperties
    {
        internal SipProperties()
        {

        }
        public SipProperties(string uri, string username = null, string password = null, string from = null, bool secure = false, Dictionary<string, string> headers = null)
        {
            this.uri = uri;
            this.username = username;
            this.password = password;
            this.from = from;
            this.secure = secure;
            this.headers = headers;
        }

        public string uri { get; set; }

        public string from { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public bool secure { get; set; }

        public Dictionary<string, string> headers { get; set; }

    }
}
