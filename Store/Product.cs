using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Product : Form
    {
        private string id = "";
        private int intRow = 0;

        public Product()
        {
            InitializeComponent();
            resetData();
        }

        //Reseta as informações das caixas de texto
        private void resetData()
        {
            this.id = string.Empty;

            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
        }

        //Carrega a tela de Produtos
        private void Product_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        //Carrega as informações da lista de Produtos
        private void loadData(string keyword)
        {
            DbConnection.sql = "SELECT * FROM product WHERE CONCAT(CAST(product_id as varchar), ' ', name) LIKE @keyword::varchar";

            string strKeyword = string.Format("%{0}%", keyword);

            DbConnection.cmd = new Npgsql.NpgsqlCommand(DbConnection.sql, DbConnection.connection);
            DbConnection.cmd.Parameters.Clear();
            DbConnection.cmd.Parameters.AddWithValue("keyword", strKeyword);

            DataTable dataTable = DbConnection.executeConnection(DbConnection.cmd);

            if (dataTable.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dataTable.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }

            toolStripStatusLabel1.Text = "Numero de linha(s) " + intRow.ToString();

            DataGridView dataGridView = productDataGridView;

            dataGridView.MultiSelect = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.DataSource = dataTable;

            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Nome";
            dataGridView.Columns[2].HeaderText = "Descrição";
            dataGridView.Columns[3].HeaderText = "Preço";
            dataGridView.Columns[4].HeaderText = "Quantidade";

            dataGridView.Columns[0].Width = 85;
            dataGridView.Columns[1].Width = 220;
            dataGridView.Columns[2].Width = 260;
            dataGridView.Columns[3].Width = 85;
            dataGridView.Columns[4].Width = 85;
        }

        //Executa a conexão com o banco de dados
        private void executeConnection(string mySQL, string param)
        {
            DbConnection.cmd = new Npgsql.NpgsqlCommand(mySQL, DbConnection.connection);
            addParameters(param);
            DbConnection.executeConnection(DbConnection.cmd);
        }

        //Adiciona os parametros referentes as variáveis do banco de dados com as do código
        private void addParameters(string param)
        {
            DbConnection.cmd.Parameters.Clear();
            DbConnection.cmd.Parameters.AddWithValue("name", nameTextBox.Text.Trim());
            DbConnection.cmd.Parameters.AddWithValue("description", descriptionTextBox.Text.Trim());
            DbConnection.cmd.Parameters.AddWithValue("price", Convert.ToDecimal(priceTextBox.Text, CultureInfo.InvariantCulture));
            DbConnection.cmd.Parameters.AddWithValue("quantity", int.Parse(quantityTextBox.Text));

            if (param == "Update" || param == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                DbConnection.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        //Insere o Produto
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(descriptionTextBox.Text.Trim())
                || string.IsNullOrEmpty(priceTextBox.Text.Trim()) || string.IsNullOrEmpty(quantityTextBox.Text.Trim()))
            {
                MessageBox.Show("Porfavor insira todas informações!", "Insirer Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DbConnection.sql = "INSERT INTO product(name, description, price, quantity) " +
                "VALUES(@name, @description, @price, @quantity)";

            executeConnection(DbConnection.sql, "Insert");

            MessageBox.Show("Produto salvo com sucesso!", "Produto Salvo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            loadData("");

            resetData();
        }

        //Atualiza o Produto
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Porfavor selecione um item da lista!", "Atualizar Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(descriptionTextBox.Text.Trim())
                || string.IsNullOrEmpty(priceTextBox.Text.Trim()) || string.IsNullOrEmpty(quantityTextBox.Text.Trim()))
            {
                MessageBox.Show("Porfavor insira todas informações!", "Insirer Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DbConnection.sql = "UPDATE product SET name = @name, description = @description, price = @price, " +
                "quantity = @quantity WHERE product_id = @id::integer";

            executeConnection(DbConnection.sql, "Update");

            MessageBox.Show("Produto atualizado com sucesso!", "Dados Atualizados!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            loadData("");

            resetData();
        }

        //Remove o Produto
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Porfavor selecione um item da lista!", "Deletar Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Deseja realmente remover este produto?", "Remover Produto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DbConnection.sql = "DELETE FROM product WHERE product_id = @id::integer";

                executeConnection(DbConnection.sql, "Delete");

                MessageBox.Show("Produto removido com sucesso!", "Produto Removido!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                loadData("");

                resetData();
            }
        }

        //Seleção de produto na tabela de produtos
        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dataGridView = productDataGridView;

                this.id = Convert.ToString(dataGridView.CurrentRow.Cells[0].Value);

                nameTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value);
                descriptionTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value);
                priceTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[3].Value);
                quantityTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[4].Value);
            }
        }

        //Busca de produto
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text.Trim()))
            {
                loadData("");
            }
            else
            {
                loadData(searchTextBox.Text.Trim());
            }

            resetData();
        }

        
    }
}
