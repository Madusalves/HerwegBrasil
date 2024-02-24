using System.Text.Json.Serialization;

namespace HerwegBrasil.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? ispb { get; set; }
        [JsonPropertyName("name")]
        public string? name { get; set; }
        [JsonPropertyName("code")]
        public int code { get; set; }
        [JsonPropertyName("fullname")]
        public string? fullName { get; set; }
    }
}
