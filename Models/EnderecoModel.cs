using System.Text.Json.Serialization;

namespace HerwegBrasil.Models
{
    public class EnderecoModel
    {
        [JsonPropertyName("cep")]
        public string? cep { get; set; }
        [JsonPropertyName("state")]
        public string? state { get; set; }
        [JsonPropertyName("city")]
        public string? city { get; set; }
        [JsonPropertyName("neighborhood")]
        public string? neighborhood { get; set; }
        [JsonPropertyName("street")]
        public string? street { get; set; }
        [JsonPropertyName("service")]
        public string? service { get; set; }
    }
}
