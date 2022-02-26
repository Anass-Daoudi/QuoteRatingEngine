using QuoteRatingEngine.Core.Models;
using QuoteRatingEngine.Repository;

namespace QuoteRatingEngine.API.Services
{

    public class QuoteRatingEngineRepository : IQuoteRatingEngineRepository
    {
        private QuoteRatingEngineContext _quoteRatingEngineContext { get; }

        public QuoteRatingEngineRepository(QuoteRatingEngineContext quoteRatingEngineContext)
        {
            _quoteRatingEngineContext = quoteRatingEngineContext;
        }

        public double GetStateFactorByState(State state)
        {
            return _quoteRatingEngineContext.StateFactorByState[state];
        }

        public double GetBusinessFactorByBusiness(Business business)
        {
            return _quoteRatingEngineContext.BusinessFactorByBusiness[business];
        }
    }
}