using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class InventoryResponse
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

    [DataMember(Name = "inventory", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "inventory")]
    public string Inventory { get; set; }

    [DataMember(Name = "key_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "key_id")]
    public int? KeyId { get; set; }

    [DataMember(Name = "ssh_key_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "ssh_key_id")]
    public int? SshKeyId { get; set; }

    [DataMember(Name = "type", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }
}