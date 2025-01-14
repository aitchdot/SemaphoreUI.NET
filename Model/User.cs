using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class User
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [DataMember(Name = "username", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }

    [DataMember(Name = "email", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    [DataMember(Name = "created", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    [DataMember(Name = "alert", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "alert")]
    public bool? Alert { get; set; }

    [DataMember(Name = "admin", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "admin")]
    public bool? Admin { get; set; }
}