﻿namespace StockExchange.Business.Models.Indicators
{
    /// <summary>
    /// Class containing indicator descriptions.
    /// </summary>
    public class IndicatorDescriptionDto
    {
        /// <summary>
        /// Buy signal description. 
        /// </summary>
        public string BuySignalDescription { get; set; }

        /// <summary>
        /// Sell signal description.
        /// </summary>
        public string SellSignalDescription { get; set; }
    }
}
