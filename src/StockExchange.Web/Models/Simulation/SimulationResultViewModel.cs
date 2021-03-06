﻿using StockExchange.Business.Models.Company;
using StockExchange.Business.Models.Simulations;
using System.Collections.Generic;
using StockExchange.Business.Models.Wallet;
using StockExchange.Web.Models.Charts;

namespace StockExchange.Web.Models.Simulation
{
    /// <summary>
    /// View model for simulation results
    /// </summary>
    public class SimulationResultViewModel
    {
        /// <summary>
        /// Transactions concluded during the simulation
        /// </summary>
        public IList<SimulationTransaction> TransactionsLog { get; set; }

        /// <summary>
        /// Number of stocks owned at the end of the simulation
        /// </summary>
        public IList<OwnedCompanyStocksDto> CurrentCompanyQuantity { get; set; }


        /// <summary>
        /// The start budget
        /// </summary>
        public decimal StartBudget { get; set; }

        /// <summary>
        /// The end budget
        /// </summary>
        public decimal TotalSimulationValue { get; set; }

        /// <summary>
        /// The percentage profit at the end of the simulation
        /// </summary>
        public double PercentageProfit { get; set; }

        /// <summary>
        /// The profit achieved when using the "Buy and Keep" strategy
        /// </summary>
        public double KeepStrategyProfit { get; set; }

        /// <summary>
        /// The average gain on a single transaction achieved during the simulation
        /// </summary>
        public AverageTransactionResult AverageGainOnTransaction { get; set; }

        /// <summary>
        /// The average loss on a single transaction achieved during the simulation
        /// </summary>
        public AverageTransactionResult AverageLossOnTransaction { get; set; }

        /// <summary>
        /// The minimal simulation value achieved during the simulation
        /// </summary>
        public ExtremeSimulationValue MaximalSimulationValue { get; set; }

        /// <summary>
        /// The maximal simulation value achieved during the simulation
        /// </summary>
        public ExtremeSimulationValue MinimalSimulationValue { get; set; }

        /// <summary>
        /// Success transaction percentage.
        /// </summary>
        public double SuccessTransactionPercentage { get; set; }

        /// <summary>
        /// Failed transaction percentage.
        /// </summary>
        public double FailedTransactionPercentage { get; set; }

        public LineChartModel Chart { get; set; }
    }
}
