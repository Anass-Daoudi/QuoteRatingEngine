using Xunit;
using QuoteRatingEngine.Repository;
using QuoteRatingEngine.Core.Models;

namespace QuoteRatingEngine.Repository.Tests
{
    public class QuoteRatingEngineContextTests
    {
        [Fact]
        public void TestStateFactorByState()
        {
            // arrange
            var stateFactorByState = new QuoteRatingEngineContext().StateFactorByState;

            // act
            var ohStateFactor = stateFactorByState[State.OH];
            var flStateFactor = stateFactorByState[State.FL];
            var txStateFactor = stateFactorByState[State.TX];

            // assert
            Assert.Equal(1, ohStateFactor);
            Assert.Equal(1.2, flStateFactor);
            Assert.Equal(0.943, txStateFactor);
        }

        [Fact]
        public void TestBusinessFactorByBusiness()
        {
            // arrange
            var businessFactorByBusiness = new QuoteRatingEngineContext().BusinessFactorByBusiness;

            // act
            var architectBusinessFactor = businessFactorByBusiness[Business.Architect];
            var plumberBusinessFactor = businessFactorByBusiness[Business.Plumber];
            var programmerBusinessFactor = businessFactorByBusiness[Business.Programmer];

            // assert
            Assert.Equal(1, architectBusinessFactor);
            Assert.Equal(0.5, plumberBusinessFactor);
            Assert.Equal(1.25, programmerBusinessFactor);
        }
    }
}