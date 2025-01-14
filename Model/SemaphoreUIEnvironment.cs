using System.Runtime.Serialization;
using Newtonsoft.Json;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace SemaphoreUI.NET.Model;

[DataContract]
public class SemaphoreUiEnvironment
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

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