using System.Text.Json.Serialization;
namespace WhatsAppAiBot.DTOs;

public class GeminiRequest
{
    [JsonPropertyName("contents")] 
    public List<Content> Contents { get; set; } = new List<Content>(); 
}

public class Content
{
    [JsonPropertyName("parts")] 
    public List<Part> Parts { get; set; } = new List<Part>();
}

public class Part
{
    [JsonPropertyName("text")] 
    public string Text { get; set; } = string.Empty;
}
