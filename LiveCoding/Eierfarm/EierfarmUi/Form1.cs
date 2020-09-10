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
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            Huhn huhn = new Huhn("Neues Huhn");

            cbxTiere.Items.Add(huhn);
            cbxTiere.SelectedItem = huhn;
        }

        private void cbxTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgdTier.SelectedObject = cbxTiere.SelectedItem;
        }

        private void btnFuettern_Click(object sender, EventArgs e)
        {
            Huhn huhn = cbxTiere.SelectedItem as Huhn; //SaveCast - liefert null, wenn Cast fehlschlägt
            if (huhn != null)
            {
                huhn.Fressen();
                pgdTier.SelectedObject = huhn;
            }
        }

        private void btnEiLegen_Click(object sender, EventArgs e)
        {
            Huhn huhn = cbxTiere.SelectedItem as Huhn;
            if (huhn!=null)
            {
                huhn.EiLegen();
                pgdTier.SelectedObject = huhn;
            }
        }
    }
}
