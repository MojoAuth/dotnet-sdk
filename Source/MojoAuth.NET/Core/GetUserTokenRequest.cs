using System.Net.Http;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using MojoAuth.NET.Http;

namespace MojoAuth.NET.Core
{
    public class GetUserTokenRequest : HttpRequest
    {
        public GetUserTokenRequest(string identifier) : base("/manage/user/token", HttpMethod.Post, typeof(GetUserTokenResponse))
        {
            this.ContentType = BaseConstants.ContentTypeApplicationJson;
            var body = new GetUserTokenRequestPayload { Identifier = identifier };
            this.Body = body;
        }
    }

    [DataContract]
    public class GetUserTokenRequestPayload
    {
        [JsonPropertyName("identifier")]
        [DataMember(Name = "identifier")]
        public string Identifier;
    }
    
    [DataContract]
    public class GetUserTokenResponse : AuthenticationStatusResponse
    {
    }
}