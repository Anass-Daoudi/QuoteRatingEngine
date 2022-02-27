using System;
using QuoteRatingEngine.Core.Models;

namespace QuoteRatingEngine.Core.Services
{

    public class TotalPremiumComputer
    {
        private const int _HazardFactor = 4;
        private decimal _basePremium { get; }
        private double _stateFactor { get; }
        private double _businessFactor { get; }

        public TotalPremiumComputer(double stateFactor, double businessFactor, decimal revenue)
        {
            _stateFactor = stateFactor;
            _businessFactor = businessFactor;
            _basePremium = Math.Ceiling(revenue / 1000);
        }

        public decimal getTotalPremium()
        {
            return (decimal)_stateFactor * (decimal)_businessFactor * _basePremium * (decimal)_HazardFactor;
        }
    }
}