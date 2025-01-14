using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class InfoType
{
    [DataMember(Name = "version", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    [DataMember(Name = "updateBody", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "updateBody")]
    public string UpdateBody { get; set; }

    [DataMember(Name = "update", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "update")]
    public InfoTypeUpdate Update { get; set; }
}