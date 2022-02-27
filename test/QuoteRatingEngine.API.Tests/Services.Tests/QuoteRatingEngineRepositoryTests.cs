using Xunit;
using QuoteRatingEngine.Repository;
using QuoteRatingEngine.API.Services;
using QuoteRatingEngine.Core.Models;

namespace QuoteRatingEngine.API.Tests.Services.Tests
{
    public class QuoteRatingEngineRepositoryTests
    {
        [Fact]
        public void TestGetStateFactorByState()
        {
            // arrange
            var quoteRatingEngineRepository = new QuoteRatingEngineRepository(new QuoteRatingEngineContext());

            // act
            var ohStateFactor = quoteRatingEngineRepository.GetStateFactorByState(State.OH);
            var flStateFactor = quoteRatingEngineRepository.GetStateFactorByState(State.FL);
            var txStateFactor = quoteRatingEngineRepository.GetStateFactorByState(State.TX);

            // assert
            Assert.Equal(1, ohStateFactor);
            Assert.Equal(1.2, flStateFactor);
            Assert.Equal(0.943, txStateFactor);
        }

        [Fact]
        public void TestGetBusinessFactorByBusiness()
        {
            // arrange
            var quoteRatingEngineRepository = new QuoteRatingEngineRepository(new QuoteRatingEngineContext());

            // act
            var architectBusinessFactor = quoteRatingEngineRepository.GetBusinessFactorByBusiness(Business.Architect);
            var plumberBusinessFactor = quoteRatingEngineRepository.GetBusinessFactorByBusiness(Business.Plumber);
            var programmerBusinessFactor = quoteRatingEngineRepository.GetBusinessFactorByBusiness(Business.Programmer);

            // assert
            Assert.Equal(1, architectBusinessFactor);
            Assert.Equal(0.5, plumberBusinessFactor);
            Assert.Equal(1.25, programmerBusinessFactor);
        }
    }
}