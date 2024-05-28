namespace Store
{
    partial class Report
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchClientButton = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.searchStockButton = new System.Windows.Forms.Button();
            this.searchSaleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Numero de linha(s)";
            // 
            // searchClientButton
            // 
            this.searchClientButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClientButton.Location = new System.Drawing.Point(12, 12);
            this.searchClientButton.Name = "searchClientButton";
            this.searchClientButton.Size = new System.Drawing.Size(146, 46);
            this.searchClientButton.TabIndex = 18;
            this.searchClientButton.Text = "Clientes";
            this.searchClientButton.UseVisualStyleBackColor = true;
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(12, 64);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(776, 522);
            this.reportDataGridView.TabIndex = 17;
            // 
            // searchStockButton
            // 
            this.searchStockButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStockButton.Location = new System.Drawing.Point(164, 12);
            this.searchStockButton.Name = "searchStockButton";
            this.searchStockButton.Size = new System.Drawing.Size(146, 46);
            this.searchStockButton.TabIndex = 20;
            this.searchStockButton.Text = "Estoque";
            this.searchStockButton.UseVisualStyleBackColor = true;
            // 
            // searchSaleButton
            // 
            this.searchSaleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSaleButton.Location = new System.Drawing.Point(316, 12);
            this.searchSaleButton.Name = "searchSaleButton";
            this.searchSaleButton.Size = new System.Drawing.Size(146, 46);
            this.searchSaleButton.TabIndex = 21;
            this.searchSaleButton.Text = "Vendas";
            this.searchSaleButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(642, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.printButton_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchSaleButton);
            this.Controls.Add(this.searchStockButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.searchClientButton);
            this.Controls.Add(this.reportDataGridView);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button searchClientButton;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button searchStockButton;
        private System.Windows.Forms.Button searchSaleButton;
        private System.Windows.Forms.Button button1;
    }
}