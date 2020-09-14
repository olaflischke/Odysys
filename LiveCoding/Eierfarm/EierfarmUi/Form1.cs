using EierfarmBl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EierfarmUi
{
    public partial class frmEierfarm : Form
    {
        public frmEierfarm()
        {
            InitializeComponent();

            cbxTiere.DisplayMember = "Name";
        }

        private void btnNeuesHuhn_Click(object sender, EventArgs e)
        {
            Huhn huhn = new Huhn("Neues Huhn");

            cbxTiere.Items.Add(huhn);
            cbxTiere.SelectedItem = huhn;
        }

        private void btnNeueGans_Click(object sender, EventArgs e)
        {
            Gans gans = new Gans("Neue Gans");

            cbxTiere.Items.Add(gans);
            cbxTiere.SelectedItem = gans;
        }

        private void btnSchnabletier_Click(object sender, EventArgs e)
        {
            Schnabeltier tier = new Schnabeltier() { Name = "Neues Schnabeltier" };
            cbxTiere.Items.Add(tier);
            cbxTiere.SelectedItem = tier;
        }

        private void cbxTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgdTier.SelectedObject = cbxTiere.SelectedItem;
        }

        private void btnFuettern_Click(object sender, EventArgs e)
        {
            IEiLeger tier = cbxTiere.SelectedItem as IEiLeger; //SaveCast - liefert null, wenn Cast fehlschlägt
            if (tier != null)
            {
                tier.Fressen();
                pgdTier.SelectedObject = tier;
            }
        }

        private void btnEiLegen_Click(object sender, EventArgs e)
        {
            IEiLeger tier = cbxTiere.SelectedItem as IEiLeger;
            if (tier != null)
            {
                tier.EiLegen();
                pgdTier.SelectedObject = tier;
            }
        }

    }
}
