using System;
using System.Collections.Generic;

namespace TradingDayAnalyzerDal
{
    public class Tradingday
    {
        public DateTime Date { get; set; }
        public List<ExchangeRate> ExchangeRates { get; set; }
    }
}