using System.Text.Json;
using System.Text.Json.Serialization;

public class VirtualMachine
{
    [JsonInclude]
    [JsonPropertyName("name")]
    public string Name { get; set; }
}