﻿using StockExchange.Business.Indicators.Common;
using StockExchange.Business.Models.Indicators;
using StockExchange.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace StockExchange.Business.Indicators
{
    /// <summary>
    /// Simple Moving Average technical indicator
    /// </summary>
    [IndicatorDescription("Sma")]
    public class SmaIndicator : IIndicator
    {
        /// <summary>
        /// Default <see cref="Term"/> value for the SMA indicator
        /// </summary>
        public const int DefaultTerm = 5;

        /// <summary>
        /// The number of prices from previous days to include when computing 
        /// an indicator value
        /// </summary>
        public int Term { get; set; } = DefaultTerm;

        /// <inheritdoc />
        [IgnoreIndicatorProperty]
        public IndicatorType Type => IndicatorType.Sma;

        /// <inheritdoc />
        [IgnoreIndicatorProperty]
        public int RequiredPricesForSignalCount => Term;

        /// <inheritdoc />
        public IList<IndicatorValue> Calculate(IList<Price> prices)
        {
            var ret = new List<IndicatorValue>();
            for (var i = 0; i < prices.Count - Term + 1; ++i)
                ret.Add(MovingAverageHelper.SimpleMovingAverage(prices.Skip(i).Take(Term).ToList()));
            return ret;
        }

        /// <inheritdoc />
        public IList<Signal> GenerateSignals(IList<Price> prices)
        {
            return MovingAverageHelper.GenerateSignalsForMovingAverages(this, Term, prices);
        }
    }
}
