using System.Text.Json.Serialization;
namespace WhatsAppAiBot.DTOs;

public class GeminiResponse
{
    [JsonPropertyName("candidates")] 
    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
}

public class Candidate
{
    [JsonPropertyName("content")] 
    public Content Content { get; set; } = new Content();
}