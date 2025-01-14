using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class UpdatePasswordRequest
{
    /// <summary>
    ///     Gets or Sets Password
    /// </summary>
    [DataMember(Name = "password", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }
}