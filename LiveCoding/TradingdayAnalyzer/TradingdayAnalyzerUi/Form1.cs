using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingDayAnalyzerDal;

namespace TradingdayAnalyzerUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";

            try
            {
                Archive archive = new Archive(url);

                lbxTradingdays.DataSource = archive.Tradingdays;

            }
            catch (TradingdayDalException ex)
            {
                Archive archive = new Archive();
                lbxTradingdays.DataSource = archive.Tradingdays;

            }

            catch (Exception ex)
            {
                MessageBox.Show(text: $"{Environment.NewLine}{ex.Message}\n\r{ex.InnerException.Message}",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error,
                    caption: "Problem");
            }
        }

    }
}
