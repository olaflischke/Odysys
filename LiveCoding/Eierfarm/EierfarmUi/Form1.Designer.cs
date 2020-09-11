namespace EierfarmUi
{
    partial class frmEierfarm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNeuesHuhn = new System.Windows.Forms.Button();
            this.cbxTiere = new System.Windows.Forms.ComboBox();
            this.pgdTier = new System.Windows.Forms.PropertyGrid();
            this.btnEiLegen = new System.Windows.Forms.Button();
            this.btnFuettern = new System.Windows.Forms.Button();
            this.btnNeueGans = new System.Windows.Forms.Button();
            this.btnSchnabletier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNeuesHuhn
            // 
            this.btnNeuesHuhn.Location = new System.Drawing.Point(232, 16);
            this.btnNeuesHuhn.Margin = new System.Windows.Forms.Padding(2);
            this.btnNeuesHuhn.Name = "btnNeuesHuhn";
            this.btnNeuesHuhn.Size = new System.Drawing.Size(100, 23);
            this.btnNeuesHuhn.TabIndex = 0;
            this.btnNeuesHuhn.Text = "Neues Huhn";
            this.btnNeuesHuhn.UseVisualStyleBackColor = true;
            this.btnNeuesHuhn.Click += new System.EventHandler(this.btnNeuesHuhn_Click);
            // 
            // cbxTiere
            // 
            this.cbxTiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTiere.FormattingEnabled = true;
            this.cbxTiere.Location = new System.Drawing.Point(91, 16);
            this.cbxTiere.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTiere.Name = "cbxTiere";
            this.cbxTiere.Size = new System.Drawing.Size(138, 21);
            this.cbxTiere.TabIndex = 1;
            this.cbxTiere.SelectedIndexChanged += new System.EventHandler(this.cbxTiere_SelectedIndexChanged);
            // 
            // pgdTier
            // 
            this.pgdTier.HelpVisible = false;
            this.pgdTier.Location = new System.Drawing.Point(91, 127);
            this.pgdTier.Margin = new System.Windows.Forms.Padding(2);
            this.pgdTier.Name = "pgdTier";
            this.pgdTier.Size = new System.Drawing.Size(199, 182);
            this.pgdTier.TabIndex = 2;
            // 
            // btnEiLegen
            // 
            this.btnEiLegen.Location = new System.Drawing.Point(294, 181);
            this.btnEiLegen.Margin = new System.Windows.Forms.Padding(2);
            this.btnEiLegen.Name = "btnEiLegen";
            this.btnEiLegen.Size = new System.Drawing.Size(57, 21);
            this.btnEiLegen.TabIndex = 3;
            this.btnEiLegen.Text = "Ei legen";
            this.btnEiLegen.UseVisualStyleBackColor = true;
            this.btnEiLegen.Click += new System.EventHandler(this.btnEiLegen_Click);
            // 
            // btnFuettern
            // 
            this.btnFuettern.Location = new System.Drawing.Point(294, 156);
            this.btnFuettern.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuettern.Name = "btnFuettern";
            this.btnFuettern.Size = new System.Drawing.Size(57, 21);
            this.btnFuettern.TabIndex = 4;
            this.btnFuettern.Text = "Füttern";
            this.btnFuettern.UseVisualStyleBackColor = true;
            this.btnFuettern.Click += new System.EventHandler(this.btnFuettern_Click);
            // 
            // btnNeueGans
            // 
            this.btnNeueGans.Location = new System.Drawing.Point(232, 43);
            this.btnNeueGans.Margin = new System.Windows.Forms.Padding(2);
            this.btnNeueGans.Name = "btnNeueGans";
            this.btnNeueGans.Size = new System.Drawing.Size(100, 23);
            this.btnNeueGans.TabIndex = 5;
            this.btnNeueGans.Text = "Neue Gans";
            this.btnNeueGans.UseVisualStyleBackColor = true;
            this.btnNeueGans.Click += new System.EventHandler(this.btnNeueGans_Click);
            // 
            // btnSchnabletier
            // 
            this.btnSchnabletier.Location = new System.Drawing.Point(232, 70);
            this.btnSchnabletier.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchnabletier.Name = "btnSchnabletier";
            this.btnSchnabletier.Size = new System.Drawing.Size(100, 23);
            this.btnSchnabletier.TabIndex = 6;
            this.btnSchnabletier.Text = "Schnabeltier";
            this.btnSchnabletier.UseVisualStyleBackColor = true;
            this.btnSchnabletier.Click += new System.EventHandler(this.btnSchnabletier_Click);
            // 
            // frmEierfarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 320);
            this.Controls.Add(this.btnSchnabletier);
            this.Controls.Add(this.btnNeueGans);
            this.Controls.Add(this.btnFuettern);
            this.Controls.Add(this.btnEiLegen);
            this.Controls.Add(this.pgdTier);
            this.Controls.Add(this.cbxTiere);
            this.Controls.Add(this.btnNeuesHuhn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEierfarm";
            this.Text = "Eierfarm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNeuesHuhn;
        private System.Windows.Forms.ComboBox cbxTiere;
        private System.Windows.Forms.PropertyGrid pgdTier;
        private System.Windows.Forms.Button btnEiLegen;
        private System.Windows.Forms.Button btnFuettern;
        private System.Windows.Forms.Button btnNeueGans;
        private System.Windows.Forms.Button btnSchnabletier;
    }
}

