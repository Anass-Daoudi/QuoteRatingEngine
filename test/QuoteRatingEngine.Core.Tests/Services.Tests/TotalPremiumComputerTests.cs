using Xunit;
using QuoteRatingEngine.Core.Services;

namespace QuoteRatingEngine.Core.Tests.Services.Tests
{
    public class TotalPremiumComputerTests
    {
        [Fact]
        public void CalculatesTotalPremium()
        {
            // arrange
            var totalPremiumComputer = new TotalPremiumComputer(
                stateFactor: 0.943,
                 businessFactor: 0.5,
                 revenue: 6000000
            );

            // act
            var totalPremium = totalPremiumComputer.getTotalPremium();

            // assert
            Assert.Equal(11316, totalPremium);
        }
    }
}