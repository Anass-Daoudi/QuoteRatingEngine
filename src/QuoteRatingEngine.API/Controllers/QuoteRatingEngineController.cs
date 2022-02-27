using Microsoft.AspNetCore.Mvc;
using QuoteRatingEngine.API.Services;

namespace QuoteRatingEngine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteRatingEngineController : ControllerBase
    {
        private IQuoteRatingEngineRepository _quoteRatingEngineRepository { get; }

        public QuoteRatingEngineController(IQuoteRatingEngineRepository quoteRatingEngineRepository)
        {
            _quoteRatingEngineRepository = quoteRatingEngineRepository;
        }
    }
}