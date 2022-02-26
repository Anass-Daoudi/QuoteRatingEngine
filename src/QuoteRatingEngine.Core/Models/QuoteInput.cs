using System;
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

        public override bool Equals(object obj)
        {
            return obj is QuoteInput input &&
                   Revenue == input.Revenue &&
                   State == input.State &&
                   Business == input.Business;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Revenue, State, Business);
        }
    }
}