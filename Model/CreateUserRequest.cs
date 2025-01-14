using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class CreateUserRequest
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [DataMember(Name = "username", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }

    [DataMember(Name = "email", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    [DataMember(Name = "alert", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "alert")]
    public bool? Alert { get; set; }

    [DataMember(Name = "admin", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "admin")]
    public bool? Admin { get; set; }
}