using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Client : Form
    {
        private string id = "";
        private int intRow = 0;

        public Client()
        {
            InitializeComponent();
            resetData();
        }

        //Reseta as informações das caixas de texto
        private void resetData()
        {
            this.id = string.Empty;

            nameTextBox.Text = "";
            addressTextBox.Text = "";
            telephoneTextBox.Text = "";
            emailTextBox.Text = "";
        }

        //Carrega a tela de Clientes
        private void Client_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        //Carrega as informações da lista de Clientes
        private void loadData(string keyword)
        {
            DbConnection.sql = "SELECT * FROM client WHERE CONCAT(CAST(client_id as varchar), ' ', name) LIKE @keyword::varchar";

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

            DataGridView dataGridView = clientDataGridView;

            dataGridView.MultiSelect = false;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.DataSource = dataTable;

            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Nome";
            dataGridView.Columns[2].HeaderText = "Endereço";
            dataGridView.Columns[3].HeaderText = "Telefone";
            dataGridView.Columns[4].HeaderText = "Email";

            dataGridView.Columns[0].Width = 85;
            dataGridView.Columns[1].Width = 220;
            dataGridView.Columns[2].Width = 220;
            dataGridView.Columns[3].Width = 85;
            dataGridView.Columns[4].Width = 125;
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
            DbConnection.cmd.Parameters.AddWithValue("address", addressTextBox.Text.Trim());
            DbConnection.cmd.Parameters.AddWithValue("telephone", telephoneTextBox.Text.Trim());
            DbConnection.cmd.Parameters.AddWithValue("email", emailTextBox.Text.Trim());

            if (param == "Update" || param == "Delete" && !string.IsNullOrEmpty(this.id))
            {
                DbConnection.cmd.Parameters.AddWithValue("id", this.id);
            }
        }

        //Insere o Cliente
        private void insertButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(addressTextBox.Text.Trim())
                || string.IsNullOrEmpty(telephoneTextBox.Text.Trim()) || string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                MessageBox.Show("Porfavor insira todas informações!", "Insirer Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            DbConnection.sql = "INSERT INTO client(name, address, telephone, email) VALUES(@name, @address, @telephone, @email)";

            executeConnection(DbConnection.sql, "Insert");

            MessageBox.Show("Cliente salvo com sucesso!", "Cliente Salvo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            loadData("");

            resetData();
        }

        //Atualiza o Cliente
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Porfavor selecione um item da lista!", "Atualizar Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(nameTextBox.Text.Trim()) || string.IsNullOrEmpty(addressTextBox.Text.Trim())
                || string.IsNullOrEmpty(telephoneTextBox.Text.Trim()) || string.IsNullOrEmpty(emailTextBox.Text.Trim()))
            {
                MessageBox.Show("Porfavor insira todas informações!", "Insirer Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DbConnection.sql = "UPDATE client SET name = @name, address = @address, telephone = @telephone, " +
                "email = @email WHERE client_id = @id::integer";

            executeConnection(DbConnection.sql, "Update");

            MessageBox.Show("Cliente atualizado com sucesso!", "Dados Atualizados!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            loadData("");

            resetData();
        }

        //Remove o Cliente
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (clientDataGridView.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Porfavor selecione um item da lista!", "Deletar Informações!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Deseja realmente remover este cliente?", "Remover Cliente", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DbConnection.sql = "DELETE FROM client WHERE client_id = @id::integer";

                executeConnection(DbConnection.sql, "Delete");

                MessageBox.Show("Produto removido com sucesso!", "Produto Removido!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                loadData("");

                resetData();
            }
        }

        //Seleção de cliente na tabela de clientes
        private void clientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dataGridView = clientDataGridView;

                this.id = Convert.ToString(dataGridView.CurrentRow.Cells[0].Value);

                nameTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value);
                addressTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value);
                telephoneTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[3].Value);
                emailTextBox.Text = Convert.ToString(dataGridView.CurrentRow.Cells[4].Value);
            }
        }

        //Busca de cliente
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
