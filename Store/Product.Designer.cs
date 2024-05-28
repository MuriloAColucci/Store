namespace Store
{
    partial class Product
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
            this.productLabel = new System.Windows.Forms.Label();
            this.productPanel = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.productLabel.Location = new System.Drawing.Point(293, 28);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(221, 50);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "PRODUTOS";
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPanel
            // 
            this.productPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productPanel.Controls.Add(this.productLabel);
            this.productPanel.Location = new System.Drawing.Point(0, 0);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(800, 108);
            this.productPanel.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(192, 231);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(338, 29);
            this.priceTextBox.TabIndex = 25;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(192, 186);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(338, 29);
            this.descriptionTextBox.TabIndex = 24;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quantityLabel.Location = new System.Drawing.Point(74, 278);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(100, 21);
            this.quantityLabel.TabIndex = 23;
            this.quantityLabel.Text = "Quantidade";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceLabel.Location = new System.Drawing.Point(74, 234);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(57, 21);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "Preço:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.descriptionLabel.Location = new System.Drawing.Point(74, 189);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(88, 21);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "Descrição:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(610, 202);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(116, 46);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Atualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(610, 258);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 46);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Remover";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(610, 146);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(116, 46);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Cadastrar";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(192, 146);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(338, 29);
            this.nameTextBox.TabIndex = 17;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Location = new System.Drawing.Point(74, 146);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 21);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Nome:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(525, 328);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 29);
            this.searchButton.TabIndex = 32;
            this.searchButton.Text = "Pesquisar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchLabel.Location = new System.Drawing.Point(82, 331);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(138, 21);
            this.searchLabel.TabIndex = 30;
            this.searchLabel.Text = "Pesquisar Nome:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(222, 328);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(297, 29);
            this.searchTextBox.TabIndex = 31;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchPanel.Location = new System.Drawing.Point(0, 317);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(800, 2);
            this.searchPanel.TabIndex = 29;
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(12, 365);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(776, 221);
            this.productDataGridView.TabIndex = 27;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Numero de linha(s)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(192, 275);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(338, 29);
            this.quantityTextBox.TabIndex = 33;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productPanel);
            this.Name = "Product";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Product_Load);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}