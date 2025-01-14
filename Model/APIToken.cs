using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class ApiToken
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    [DataMember(Name = "created", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    [DataMember(Name = "expired", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "expired")]
    public bool? Expired { get; set; }

    [DataMember(Name = "user_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }
}