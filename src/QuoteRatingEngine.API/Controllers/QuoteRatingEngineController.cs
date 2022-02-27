using Microsoft.AspNetCore.Mvc;
using QuoteRatingEngine.API.Models;
using QuoteRatingEngine.API.Services;
using QuoteRatingEngine.Core.Models;
using QuoteRatingEngine.Core.Services;

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

        [HttpPost("ComputePremium")]
        public ActionResult GetTotalPremium([FromBody] QuoteInput quoteInput)
        {
            var stateFactor = _quoteRatingEngineRepository.GetStateFactorByState(quoteInput.State);
            var businessFactor = _quoteRatingEngineRepository.GetBusinessFactorByBusiness(quoteInput.Business);

            var totalPremiumComputer = new TotalPremiumComputer(
                stateFactor: stateFactor,
                businessFactor: businessFactor,
                revenue: quoteInput.Revenue
            );

            var totalPremium = totalPremiumComputer.getTotalPremium();

            return Ok(new TotalPremiumResponse(totalPremium));
        }
    }
}