using QuoteRatingEngine.Core.Models;

namespace QuoteRatingEngine.API.Services
{
    public interface IQuoteRatingEngineRepository
    {
        double GetStateFactorByState(State state);
        double GetBusinessFactorByBusiness(Business business);
    }
}