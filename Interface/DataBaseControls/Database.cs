using Interface.FormsControls;
using MySqlConnector;
using System.Data;

namespace Interface.DataBaseControls
{
    internal class Database
    {
        private Mapper mapper = new();

        private DataTable dados = new();

        public string? Route;

        public string GetData
        {
            set
            {
                dados.Rows.Clear();
                dados.Columns.Clear();

                Route = value;
            }
        }

        public bool isCPF
        {
            set
            {
                dados.Rows.Clear();
                dados.Columns.Clear();

                mapper.mapperForDatabase(Route!, value);
            }
        }

        public void GetDataGridView(DataGridView dataGridView, MaskedTextBox maskedTextBox, string selectOrDelete = "Select")
        {
            try
            {
                dados.Rows.Clear();
                dados.Columns.Clear();

                dataGridView.DataSource = null;
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                if (selectOrDelete.Contains("Select"))
                {
                    MySqlConnection conexao = new("server=localhost;user=root;database=tms");

                    conexao.Open();

                    if (maskedTextBox.MaskCompleted == true && maskedTextBox.Text != "")
                    {
                        MySqlCommand comandoWhere = new($"SELECT * FROM {mapper.TypeDataDatabase} WHERE {mapper.TypeWhereDatabase} = '{maskedTextBox.Text}'", conexao);

                        MySqlDataAdapter mySqlDataAdapterWhere = new(comandoWhere);

                        mySqlDataAdapterWhere.Fill(dados);

                        dataGridView.DataSource = dados;
                    }

                    if (Route!.Contains("Clientes"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"INNER JOIN Cliente ON {mapper.TypeDataDatabase}.ID_for_cliente = Cliente.ID_cliente " +
                            $"INNER JOIN TelefoneCliente ON {mapper.TypeDataDatabase}.ID_for_cliente = TelefoneCliente.ID_for_cliente " +
                            $"INNER JOIN CelularCliente ON {mapper.TypeDataDatabase}.ID_for_cliente = CelularCliente.ID_for_cliente " +
                            $"INNER JOIN EmailCliente ON {mapper.TypeDataDatabase}.ID_for_cliente = EmailCliente.ID_for_cliente;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase}", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }


                    conexao.Close();
                }

                if (selectOrDelete.Contains("Delete") && maskedTextBox.MaskCompleted == true && maskedTextBox.Text != "")
                {
                    MySqlConnection conexao = new("server=localhost;user=root;database=tms");

                    conexao.Open();

                    MySqlCommand comandoDelete = new($"DELETE * FROM {mapper.TypeDataDatabase} WHERE {mapper.TypeWhereDatabase} = '{maskedTextBox.Text}'", conexao);

                    comandoDelete.ExecuteNonQuery();

                    MessageBox.Show("Deletado com sucesso!", "Aviso");

                    if (Route!.Contains("Clientes"))
                    {
                        MySqlCommand comandoSelect = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"INNER JOIN Cliente ON {mapper.TypeDataDatabase}.ID_for_cliente = Cliente.ID_cliente " +
                            $"INNER JOIN TelefoneCliente ON {mapper.TypeDataDatabase}.ID_for_cliente = TelefoneCliente.ID_for_cliente " +
                            $"INNER JOIN CelularCliente ON {mapper.TypeDataDatabase}.ID_for_cliente = CelularCliente.ID_for_cliente " +
                            $"INNER JOIN EmailCliente ON {mapper.TypeDataDatabase}.ID_for_cliente = EmailCliente.ID_for_cliente;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comandoSelect);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else
                    {
                        MySqlCommand comandoSelect = new($"SELECT * FROM {mapper.TypeDataDatabase}", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comandoSelect);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }

                    conexao.Close();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
