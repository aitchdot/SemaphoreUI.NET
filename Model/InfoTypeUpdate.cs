using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class InfoTypeUpdate
{
    [DataMember(Name = "tag_name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "tag_name")]
    public string TagName { get; set; }
}