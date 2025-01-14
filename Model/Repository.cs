using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class Repository
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

    [DataMember(Name = "git_url", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "git_url")]
    public string GitUrl { get; set; }

    [DataMember(Name = "ssh_key_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "ssh_key_id")]
    public int? SshKeyId { get; set; }
}