using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TradingDayAnalyzerDal
{
    public class Archive
    {
        /// <summary>
        /// Erzeugt eine Archive-Instanz mit Daten aus einer lokalen Datenbank
        /// </summary>
        public Archive()
        {
            this.Tradingdays = GetDataFromLocalDatabase();
        }


        /// <summary>
        /// Erzeugt eine Archive-Instanz mit der gg. URL.
        /// </summary>
        /// <param name="url">URL einer GESMES-Datei.</param>
        public Archive(string url)
        {
            //this.Tradingdays = GetDataFromXmlClassic(url);
            this.Tradingdays = GetDataFromXml(url);
            this.SaveToLocalDatabase();
        }

        /// <summary>
        /// Schreibt Tradingdays und ExchangeRates in eine lokale Datenbank
        /// </summary>
        private void SaveToLocalDatabase()
        {
            // TradingDays in DataSet füllen
            DataSet dsArchive = new DataSet("Archive");

            DataTable dtTradingDays = new DataTable("TradingDays");
            dtTradingDays.Columns.Add("Id", typeof(Int32));
            dtTradingDays.Columns.Add("Date", typeof(DateTime));

            DataTable dtExchangeRates = new DataTable("ExchangeRates");
            dtExchangeRates.Columns.Add("Id", typeof(Int32));
            dtExchangeRates.Columns.Add("Rate", typeof(double));
            dtExchangeRates.Columns.Add("CountryCode", typeof(string));
            dtExchangeRates.Columns.Add("Tradingday_Id", typeof(Int32));

            dsArchive.Tables.Add(dtTradingDays);
            dsArchive.Tables.Add(dtExchangeRates);

            int zaehler = 1;

            for (int i = 0; i < this.Tradingdays.Count; i++)
            {
                DataRow dr = dtTradingDays.NewRow();
                dr["Id"] = i;
                dr["Date"] = this.Tradingdays[i].Date;
                dtTradingDays.Rows.Add(dr);

                for (int j = 0; j < this.Tradingdays[i].ExchangeRates.Count; j++)
                {
                    DataRow drExchangeRate = dtExchangeRates.NewRow();
                    drExchangeRate["Id"] = zaehler;
                    zaehler++;
                    drExchangeRate["CountryCode"] = this.Tradingdays[i].ExchangeRates[j].CountryCode;
                    drExchangeRate["Rate"] = this.Tradingdays[i].ExchangeRates[j].Rate;
                    drExchangeRate["Trading_Id"] = i;
                    dtExchangeRates.Rows.Add(drExchangeRate);
                }
            }

            try
            {
                // using sorgt dafür, dass Ressource (Connection hier) aufgeräumt wird
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConString))
                {
                    connection.Open();

                    SqlCommand commandTradingDays = new SqlCommand();
                    commandTradingDays.Connection = connection;
                    commandTradingDays.CommandText = "INSERT INTO TradingDays (Date) VALUES (@Date)";

                    SqlCommand commandExchangeRates = new SqlCommand();
                    // Command konfigurieren

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    // TradingDays speichern
                    sqlDataAdapter.InsertCommand = commandTradingDays;
                    sqlDataAdapter.Update(dtTradingDays); // Update wertet DataRow.RowState für jede Zeile der Tabelle aus und führt das passende Kommando aus

                    // ExchangeRates speichern
                    sqlDataAdapter.InsertCommand = commandExchangeRates;
                    sqlDataAdapter.Update(dtExchangeRates);
                }
            }
            catch (Exception ex)
            {
                // Exceptionhandling
            }
        }

        private List<Tradingday> GetDataFromLocalDatabase()
        {
            throw new NotImplementedException();
        }


        private List<Tradingday> GetDataFromXml(string url)
        {
            // Type inference
            var a = new ExchangeRate();

            List<Tradingday> days = new List<Tradingday>();

            try
            {
                XDocument document = XDocument.Load(url);

                // Deklarative Syntax
                var qTradingDays = from node in document.Root.Descendants()
                                   where node.Name.LocalName == "Cube" // Knotenname = "Cube"
                                   && node.Attributes().Any(at => at.Name == "time") // ein Attribut namens "time"
                                   select new Tradingday(node) { Date = Convert.ToDateTime(node.Attribute("time").Value) };

                // Methodensyntax
                var qTradingDaysMeth = document.Root.Descendants()
                                            .Where(node => node.Name.LocalName == "Cube" && node.Attributes().Any(at => at.Name == "time"))
                                            .Select(node => new Tradingday(node)
                                            {
                                                Date = Convert.ToDateTime(node.Attribute("time").Value)
                                            });

                //foreach (XElement item in qTradingDays)
                //{
                //    Tradingday tradingday = new Tradingday() { Date = Convert.ToDateTime(item.Attribute("time").Value) };
                //    days.Add(tradingday);
                //}

                days = qTradingDays.ToList(); ;


            }
            catch (WebException ex)
            {
                throw new TradingdayDalException("Fehler beim XML-Lesen: URL falsch oder kein Internet?", ex);

            }
            // Catch-Block für allgemeine Exception
            catch (Exception ex)
            {
                throw new TradingdayDalException("Fehler beim XML-Lesen (Details siehe InnerException)", ex);
            }
            finally
            {
                // wird immer ausgeführt, egal ob Exception oder nicht
            }

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
