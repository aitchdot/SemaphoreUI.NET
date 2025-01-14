using System.Runtime.Serialization;
using Newtonsoft.Json;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace SemaphoreUI.NET.Model;

[DataContract]
public class AddRepositoryRequest
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [DataMember(Name = "project_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "project_id")]
    public int? ProjectId { get; set; }

    [DataMember(Name = "git_url", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "git_url")]
    public string GitUrl { get; set; }

    [DataMember(Name = "ssh_key_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "ssh_key_id")]
    public int? SshKeyId { get; set; }
}