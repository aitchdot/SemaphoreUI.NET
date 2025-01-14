using System.Runtime.Serialization;
using Newtonsoft.Json;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace SemaphoreUI.NET.Model;

[DataContract]
public class Template
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    [DataMember(Name = "ssh_key_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "ssh_key_id")]
    public int? SshKeyId { get; set; }

    [DataMember(Name = "project_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "project_id")]
    public int? ProjectId { get; set; }

    [DataMember(Name = "inventory_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "inventory_id")]
    public int? InventoryId { get; set; }

    [DataMember(Name = "repository_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "repository_id")]
    public int? RepositoryId { get; set; }

    [DataMember(Name = "environment_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "environment_id")]
    public int? EnvironmentId { get; set; }

    [DataMember(Name = "alias", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    [DataMember(Name = "playbook", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "playbook")]
    public string Playbook { get; set; }

    [DataMember(Name = "arguments", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "arguments")]
    public string Arguments { get; set; }

    [DataMember(Name = "override_args", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "override_args")]
    public bool? OverrideArgs { get; set; }
}