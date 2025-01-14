using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class StartProjectTaskRequest
{
    [DataMember(Name = "template_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "template_id")]
    public int? TemplateId { get; set; }

    [DataMember(Name = "debug", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "debug")]
    public bool? Debug { get; set; }

    [DataMember(Name = "dry_run", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "dry_run")]
    public bool? DryRun { get; set; }

    [DataMember(Name = "playbook", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "playbook")]
    public string Playbook { get; set; }

    [DataMember(Name = "environment", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }
}