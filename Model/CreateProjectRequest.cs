using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class CreateProjectRequest
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [DataMember(Name = "alert", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "alert")]
    public bool? Alert { get; set; }
}