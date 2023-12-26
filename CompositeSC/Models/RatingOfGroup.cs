using System.Text.Json.Serialization;

namespace СompositeSC.Models
{
    public class RatingOfGroup
    {
        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }
        [JsonPropertyName("averageRating")]
        public double AverageRating { get; set; }
    }
}
