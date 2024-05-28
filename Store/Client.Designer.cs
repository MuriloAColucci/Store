namespace Store
{
    partial class Client
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
            this.clientPanel = new System.Windows.Forms.Panel();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientPanel.Controls.Add(this.clientLabel);
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(800, 108);
            this.clientPanel.TabIndex = 3;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.clientLabel.Location = new System.Drawing.Point(293, 28);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(188, 50);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "CLIENTES";
            this.clientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 365);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(776, 221);
            this.clientDataGridView.TabIndex = 4;
            this.clientDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDataGridView_CellClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Location = new System.Drawing.Point(63, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 21);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Nome:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(181, 148);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(338, 29);
            this.nameTextBox.TabIndex = 6;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(599, 148);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(116, 46);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Cadastrar";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(599, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 46);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Remover";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(599, 204);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(116, 46);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Atualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.Location = new System.Drawing.Point(63, 191);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(85, 21);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Endereço:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.telephoneLabel.Location = new System.Drawing.Point(63, 236);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(80, 21);
            this.telephoneLabel.TabIndex = 11;
            this.telephoneLabel.Text = "Telefone:";
            this.telephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Location = new System.Drawing.Point(63, 280);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 21);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(181, 188);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(338, 29);
            this.addressTextBox.TabIndex = 13;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneTextBox.Location = new System.Drawing.Point(181, 233);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(338, 29);
            this.telephoneTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(181, 277);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(338, 29);
            this.emailTextBox.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Numero de linha(s)";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchPanel.Location = new System.Drawing.Point(0, 317);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(800, 2);
            this.searchPanel.TabIndex = 17;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(222, 328);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(297, 29);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchLabel.Location = new System.Drawing.Point(82, 331);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(138, 21);
            this.searchLabel.TabIndex = 18;
            this.searchLabel.Text = "Pesquisar Nome:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(525, 328);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 29);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Pesquisar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(647, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.clientDataGridView);
            this.Controls.Add(this.clientPanel);
            this.Name = "Client";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Client_Load);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
    }
}