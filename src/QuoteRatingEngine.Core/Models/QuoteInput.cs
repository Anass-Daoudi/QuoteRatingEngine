using System.Text.Json.Serialization;

namespace QuoteRatingEngine.Core.Models
{
    public class QuoteInput
    {
        public decimal Revenue { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public State State { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Business Business { get; set; }

        public QuoteInput()
        {

        }
    }
}