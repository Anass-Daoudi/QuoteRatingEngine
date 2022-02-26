using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using QuoteRatingEngine.Core.Models;

namespace QuoteRatingEngine.Repository
{
    public class QuoteRatingEngineContext
    {
        public IReadOnlyDictionary<State, double> StateFactorByState { get; }
        public IReadOnlyDictionary<Business, double> BusinessFactorByBusiness { get; }

        public QuoteRatingEngineContext()
        {
            StateFactorByState = new ReadOnlyDictionary<State, double>(new Dictionary<State, double>()
            {
                {State.OH, 1},
                {State.FL,1.2},
                {State.TX,0.943}
            });

            BusinessFactorByBusiness = new ReadOnlyDictionary<Business, double>(new Dictionary<Business, double>()
            {
                {Business.Architect,1},
                {Business.Plumber,0.5},
                {Business.Programmer,1.25}
            });
        }

        public override bool Equals(object obj)
        {
            return obj is QuoteRatingEngineContext context &&
                   EqualityComparer<IReadOnlyDictionary<State, double>>.Default.Equals(StateFactorByState, context.StateFactorByState) &&
                   EqualityComparer<IReadOnlyDictionary<Business, double>>.Default.Equals(BusinessFactorByBusiness, context.BusinessFactorByBusiness);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StateFactorByState, BusinessFactorByBusiness);
        }
    }
}