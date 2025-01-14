using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class SemaphoreTask
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    [DataMember(Name = "template_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "template_id")]
    public int? TemplateId { get; set; }

    [DataMember(Name = "status", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    [DataMember(Name = "debug", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "debug")]
    public bool? Debug { get; set; }

    [DataMember(Name = "playbook", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "playbook")]
    public string Playbook { get; set; }

    [DataMember(Name = "environment", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }
}