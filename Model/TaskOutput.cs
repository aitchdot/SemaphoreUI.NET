using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class SemaphoreTaskOutput
{
    [DataMember(Name = "task_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "task_id")]
    public int? SemaphoreTaskId { get; set; }

    [DataMember(Name = "task", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "task")]
    public string SemaphoreTask { get; set; }

    [DataMember(Name = "time", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "time")]
    public DateTime? Time { get; set; }

    [DataMember(Name = "output", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "output")]
    public string Output { get; set; }
}