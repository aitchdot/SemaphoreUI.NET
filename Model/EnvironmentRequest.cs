using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class EnvironmentRequest
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [DataMember(Name = "project_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "project_id")]
    public int? ProjectId { get; set; }

    [DataMember(Name = "password", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    [DataMember(Name = "json", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "json")]
    public string Json { get; set; }
}