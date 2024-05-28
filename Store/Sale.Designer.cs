namespace Store
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saleLabel = new System.Windows.Forms.Label();
            this.salePanel = new System.Windows.Forms.Panel();
            this.salePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleLabel
            // 
            this.saleLabel.AutoSize = true;
            this.saleLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.saleLabel.Location = new System.Drawing.Point(321, 28);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(148, 50);
            this.saleLabel.TabIndex = 0;
            this.saleLabel.Text = "VENDA";
            this.saleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salePanel
            // 
            this.salePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salePanel.Controls.Add(this.saleLabel);
            this.salePanel.Location = new System.Drawing.Point(0, 0);
            this.salePanel.Name = "salePanel";
            this.salePanel.Size = new System.Drawing.Size(800, 108);
            this.salePanel.TabIndex = 4;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.salePanel);
            this.Name = "Sale";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.salePanel.ResumeLayout(false);
            this.salePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.Panel salePanel;
    }
}