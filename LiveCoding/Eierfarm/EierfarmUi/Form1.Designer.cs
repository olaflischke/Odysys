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
            this.btnNeu = new System.Windows.Forms.Button();
            this.cbxTiere = new System.Windows.Forms.ComboBox();
            this.pgdTier = new System.Windows.Forms.PropertyGrid();
            this.btnEiLegen = new System.Windows.Forms.Button();
            this.btnFuettern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(348, 24);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(87, 36);
            this.btnNeu.TabIndex = 0;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // cbxTiere
            // 
            this.cbxTiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTiere.FormattingEnabled = true;
            this.cbxTiere.Location = new System.Drawing.Point(137, 24);
            this.cbxTiere.Name = "cbxTiere";
            this.cbxTiere.Size = new System.Drawing.Size(205, 28);
            this.cbxTiere.TabIndex = 1;
            this.cbxTiere.SelectedIndexChanged += new System.EventHandler(this.cbxTiere_SelectedIndexChanged);
            // 
            // pgdTier
            // 
            this.pgdTier.Location = new System.Drawing.Point(137, 89);
            this.pgdTier.Name = "pgdTier";
            this.pgdTier.Size = new System.Drawing.Size(298, 349);
            this.pgdTier.TabIndex = 2;
            // 
            // btnEiLegen
            // 
            this.btnEiLegen.Location = new System.Drawing.Point(472, 159);
            this.btnEiLegen.Name = "btnEiLegen";
            this.btnEiLegen.Size = new System.Drawing.Size(85, 33);
            this.btnEiLegen.TabIndex = 3;
            this.btnEiLegen.Text = "Ei legen";
            this.btnEiLegen.UseVisualStyleBackColor = true;
            this.btnEiLegen.Click += new System.EventHandler(this.btnEiLegen_Click);
            // 
            // btnFuettern
            // 
            this.btnFuettern.Location = new System.Drawing.Point(472, 120);
            this.btnFuettern.Name = "btnFuettern";
            this.btnFuettern.Size = new System.Drawing.Size(85, 33);
            this.btnFuettern.TabIndex = 4;
            this.btnFuettern.Text = "Füttern";
            this.btnFuettern.UseVisualStyleBackColor = true;
            this.btnFuettern.Click += new System.EventHandler(this.btnFuettern_Click);
            // 
            // frmEierfarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 492);
            this.Controls.Add(this.btnFuettern);
            this.Controls.Add(this.btnEiLegen);
            this.Controls.Add(this.pgdTier);
            this.Controls.Add(this.cbxTiere);
            this.Controls.Add(this.btnNeu);
            this.Name = "frmEierfarm";
            this.Text = "Eierfarm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.ComboBox cbxTiere;
        private System.Windows.Forms.PropertyGrid pgdTier;
        private System.Windows.Forms.Button btnEiLegen;
        private System.Windows.Forms.Button btnFuettern;
    }
}

