using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
internal class Login(string auth, string password)
{
    [DataMember(Name = "auth", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "auth")]
    public string Auth { get; set; } = auth;

    [DataMember(Name = "password", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; } = password;
}