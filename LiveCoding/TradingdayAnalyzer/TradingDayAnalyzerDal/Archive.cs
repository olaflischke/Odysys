using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TradingDayAnalyzerDal
{
   public class Archive
    {
        /// <summary>
        /// Erzeugt eine Archive-Instanz mit der gg. URL.
        /// </summary>
        /// <param name="url">URL einer GESMES-Datei.</param>
        public Archive(string url)
        {
            //this.Tradingdays = GetDataFromXmlClassic(url);
            this.Tradingdays = GetDataFromXml(url);
        }

        private List<Tradingday> GetDataFromXml(string url)
        {
            // Type inference
            var a = new ExchangeRate();

            List<Tradingday> days = new List<Tradingday>();

            XDocument document = XDocument.Load(url);

            var qTradingDays = from node in document.Root.Descendants()
                               where node.Name.LocalName == "Cube" && node.Attributes().Count() == 1
                               select new Tradingday(node) { Date = Convert.ToDateTime(node.Attribute("time").Value) };

            //foreach (XElement item in qTradingDays)
            //{
            //    Tradingday tradingday = new Tradingday() { Date = Convert.ToDateTime(item.Attribute("time").Value) };
            //    days.Add(tradingday);
            //}

            days = qTradingDays.ToList(); ;

            return days;
        }

        public List<Tradingday> Tradingdays { get; set; }

        /// <summary>
        /// Liest die Daten einer GESMES-XML-Datei und füllt das Archiv.
        /// </summary>
        /// <param name="url">URL einer GESMES-XML-Datei.</param>
        /// <returns>Eine Liste von TradingDay-Objekten.</returns>
        /// <remarks>
        /// Verwendet den klassischen XML-Reader - unelegant, nicht objektorientiert, nur zu Schulungszwecken!
        /// </remarks>
        //public List<Tradingday> GetDataFromXmlClassic(string url)
        //{
        //    List<Tradingday> days = new List<Tradingday>();

        //    XmlReader reader = XmlReader.Create(url);

        //    while (reader.Read())
        //    {
        //        Tradingday tradingday = null;

        //        if (reader.Name == "Cube" && reader.AttributeCount == 1)
        //        {
        //            tradingday = new Tradingday();
        //            tradingday.Date = Convert.ToDateTime(reader["time"]);
        //        }
        //        if (reader.Name == "Cube" && reader.AttributeCount == 2)
        //        {
        //            ExchangeRate rate = new ExchangeRate();
        //            rate.Rate = Convert.ToDouble(reader["rate"]);
        //            rate.CountryCode = reader["currency"];

        //            if (tradingday != null)
        //            {
        //                tradingday.ExchangeRates.Add(rate);
        //            }
        //        }

        //        days.Add(tradingday);
        //    }

        //    return days;
        //}
    }
}
