using System.Runtime.Serialization;
using Newtonsoft.Json;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace SemaphoreUI.NET.Model;

[DataContract]
public class SemaphoreEvent
{
    [DataMember(Name = "project_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "project_id")]
    public int? ProjectId { get; set; }

    [DataMember(Name = "object_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "object_id")]
    public int? ObjectId { get; set; }

    [DataMember(Name = "object_type", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "object_type")]
    public string ObjectType { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }
}