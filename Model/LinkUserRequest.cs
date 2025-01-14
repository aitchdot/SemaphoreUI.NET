using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace SemaphoreUI.NET.Model;

[DataContract]
public class LinkUserRequest
{
    [DataMember(Name = "user_id", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    [DataMember(Name = "admin", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "admin")]
    public bool? Admin { get; set; }


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProjectIdUsersBody {\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Admin: ").Append(Admin).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    public string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}