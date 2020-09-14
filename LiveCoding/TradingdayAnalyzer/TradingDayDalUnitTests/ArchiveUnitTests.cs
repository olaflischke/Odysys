using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TradingDayAnalyzerDal;

namespace TradingDayDalUnitTests
{
    [TestClass]
    public class ArchiveUnitTests
    {
        string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";

        [TestMethod]
        public void ArchiveInitTest()
        {
            Archive archive = new Archive(url);

            // STRINGS ARE IMMUTABLE!!!
            // Zeichenketten sind unveränderbar - eigentlich gilt: string = char[]

            // Sehr schlecht (am Ende 3 Strings im Speicher)
            //string meldung = "Gefundene TradingDays: " + archive.Tradingdays.Count;

            // Stattdessen (bis .NET 4!):
            //StringBuilder builder = new StringBuilder();
            //builder.Append("Gefundene TradingDays: ");
            //builder.Append(archive.Tradingdays.Count);
            //string meldung = builder.ToString();

            // StringBuilder seit 4.5 mit $"...{C#}..."
            Console.WriteLine($"Gefundene TradingDays: {archive.Tradingdays.Count}");

            // Assert - für den Test-Explorer
            Assert.AreEqual(64, archive.Tradingdays.Count);
        }
    }
}
