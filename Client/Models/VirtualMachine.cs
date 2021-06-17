using System.Text.Json;
using System.Text.Json.Serialization;

public class VirtualMachine
{
    [JsonInclude]
    [JsonPropertyName("Name")]
    public string Name { get; set; }
}