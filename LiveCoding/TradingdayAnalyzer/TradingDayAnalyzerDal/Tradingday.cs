using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TradingDayAnalyzerDal
{
    public class Tradingday
    {
        public Tradingday(XElement node)
        {
            // TODO: ExchangeRate-Objekte aus dem node erstellen (Tipp: LINQ-Statement in Archive.cs)
        }

        public DateTime Date { get; set; }
        public List<ExchangeRate> ExchangeRates { get; set; }
    }
}