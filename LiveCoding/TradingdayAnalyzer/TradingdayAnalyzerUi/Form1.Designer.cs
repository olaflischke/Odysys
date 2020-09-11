namespace TradingdayAnalyzerUi
{
    partial class Form1
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
            this.lbxTradingdays = new System.Windows.Forms.ListBox();
            this.lbxExchangeRate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxTradingdays
            // 
            this.lbxTradingdays.FormattingEnabled = true;
            this.lbxTradingdays.Location = new System.Drawing.Point(12, 12);
            this.lbxTradingdays.Name = "lbxTradingdays";
            this.lbxTradingdays.Size = new System.Drawing.Size(224, 264);
            this.lbxTradingdays.TabIndex = 0;
            // 
            // lbxExchangeRate
            // 
            this.lbxExchangeRate.FormattingEnabled = true;
            this.lbxExchangeRate.Location = new System.Drawing.Point(242, 12);
            this.lbxExchangeRate.Name = "lbxExchangeRate";
            this.lbxExchangeRate.Size = new System.Drawing.Size(221, 264);
            this.lbxExchangeRate.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 293);
            this.Controls.Add(this.lbxExchangeRate);
            this.Controls.Add(this.lbxTradingdays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTradingdays;
        private System.Windows.Forms.ListBox lbxExchangeRate;
    }
}

