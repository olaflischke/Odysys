using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace TradingDayAnalyzerDal
{
    public class Tradingday
    {
        public Tradingday(XElement node)
        {
            NumberFormatInfo nfiEzb = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",   // EZB verwendet . als Dezimaltrennzeichen
                NumberGroupSeparator = ""       // EZB hat kein Tausender-Trennzeichen
            };

            this.Date = Convert.ToDateTime(node.Attribute("time").Value);

            var qExchangeRates = from element in node.Descendants()
                                 where element.Name.LocalName == "Cube" && element.Attributes().Count() == 2
                                 select new ExchangeRate()
                                 {
                                     CountryCode = element.Attribute("currency").Value, // currency="USD"
                                     Rate = Convert.ToDouble(element.Attribute("rate").Value, nfiEzb) //rate="1.1876"
                                 };



            this.ExchangeRates = qExchangeRates.ToList();
        }

        public DateTime Date { get; set; }
        public List<ExchangeRate> ExchangeRates { get; set; }
    }
}