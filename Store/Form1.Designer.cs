namespace Store
{
    partial class LOJA
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientRegister = new System.Windows.Forms.Button();
            this.productRegister = new System.Windows.Forms.Button();
            this.saleRegister = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 108);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOJA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientRegister
            // 
            this.clientRegister.CausesValidation = false;
            this.clientRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientRegister.Location = new System.Drawing.Point(92, 192);
            this.clientRegister.Name = "clientRegister";
            this.clientRegister.Size = new System.Drawing.Size(125, 55);
            this.clientRegister.TabIndex = 3;
            this.clientRegister.Text = "CLIENTES";
            this.clientRegister.UseVisualStyleBackColor = true;
            this.clientRegister.Click += new System.EventHandler(this.clientRegister_Click);
            // 
            // productRegister
            // 
            this.productRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productRegister.Location = new System.Drawing.Point(338, 192);
            this.productRegister.Name = "productRegister";
            this.productRegister.Size = new System.Drawing.Size(125, 55);
            this.productRegister.TabIndex = 6;
            this.productRegister.Text = "PRODUTOS";
            this.productRegister.UseVisualStyleBackColor = true;
            this.productRegister.Click += new System.EventHandler(this.productRegister_Click);
            // 
            // saleRegister
            // 
            this.saleRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleRegister.Location = new System.Drawing.Point(578, 192);
            this.saleRegister.Name = "saleRegister";
            this.saleRegister.Size = new System.Drawing.Size(125, 55);
            this.saleRegister.TabIndex = 7;
            this.saleRegister.Text = "VENDAS";
            this.saleRegister.UseVisualStyleBackColor = true;
            this.saleRegister.Click += new System.EventHandler(this.saleRegister_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(338, 317);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(125, 55);
            this.reportButton.TabIndex = 8;
            this.reportButton.Text = "RELATORIOS";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // LOJA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.saleRegister);
            this.Controls.Add(this.productRegister);
            this.Controls.Add(this.clientRegister);
            this.Controls.Add(this.panel1);
            this.Name = "LOJA";
            this.Text = "LOJA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clientRegister;
        private System.Windows.Forms.Button productRegister;
        private System.Windows.Forms.Button saleRegister;
        private System.Windows.Forms.Button reportButton;
    }
}

