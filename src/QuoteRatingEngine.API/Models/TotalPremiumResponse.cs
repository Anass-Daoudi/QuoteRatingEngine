namespace QuoteRatingEngine.API.Models
{
    public class TotalPremiumResponse
    {
        public decimal Premium { get; }

        public TotalPremiumResponse(decimal premium)
        {
            Premium = premium;
        }
    }
}