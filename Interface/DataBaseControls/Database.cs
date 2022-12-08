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
                    else if (Route!.Contains("Motoristas"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"INNER JOIN TelefoneFuncionario ON {mapper.TypeDataDatabase}.ID_motorista = TelefoneFuncionario.ID_for_funcionario " +
                            $"INNER JOIN CelularFuncionario ON {mapper.TypeDataDatabase}.ID_motorista = CelularFuncionario.ID_for_funcionario " +
                            $"INNER JOIN EmailFuncionario ON {mapper.TypeDataDatabase}.ID_motorista = EmailFuncionario.ID_for_funcionario;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Veiculos"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN Carroceria ON {mapper.TypeDataDatabase}.ID_veiculo = Carroceria.ID_carroceria " +
                            $"LEFT JOIN TipoVeiculo ON {mapper.TypeDataDatabase}.ID_veiculo = TipoVeiculo.ID_tipo_veiculo " +
                            $"LEFT JOIN Modelo ON {mapper.TypeDataDatabase}.ID_veiculo = Modelo.ID_modelo " +
                            $"LEFT JOIN Marca ON {mapper.TypeDataDatabase}.Placa = Marca.ID_marca " +
                            $"LEFT JOIN Manutencao ON {mapper.TypeDataDatabase}.ID_veiculo = Manutencao.ID_for_veiculo;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Pedidos"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"INNER JOIN Cliente ON {mapper.TypeDataDatabase}.ID_for_cliente = Cliente.ID_cliente " +
                            $"LEFT JOIN ClienteFisico ON {mapper.TypeDataDatabase}.ID_for_cliente = ClienteFisico.ID_for_cliente " +
                            $"LEFT JOIN ClienteJuridico ON {mapper.TypeDataDatabase}.ID_for_cliente = ClienteJuridico.ID_for_cliente;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Empresa"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN Manutencao ON {mapper.TypeDataDatabase}.Nome_fantasia = Manutencao.ID_for_empresa", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Processo"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN ProcessoManutencao ON ProcessoManutencao.ID_processo_manutencao = {mapper.TypeDataDatabase}.ID_manutencao " +
                            $"LEFT JOIN Veiculo ON Veiculo.ID_veiculo = {mapper.TypeDataDatabase}.ID_for_veiculo " +
                            $"LEFT JOIN PessoaJuridica ON PessoaJuridica.Nome_fantasia = {mapper.TypeDataDatabase}.ID_for_empresa;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Terceiros"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN TelefoneMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = TelefoneMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN CelularMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = CelularMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN EmailMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = EmailMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN ContratoMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = ContratoMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN VeiculoTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = VeiculoTerceiro.ID_for_motorista;", conexao);

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

                    MySqlCommand comandoDelete = new($"DELETE FROM {mapper.TypeDataDatabase} WHERE {mapper.TypeWhereDatabase} = '{maskedTextBox.Text}'", conexao);

                    comandoDelete.ExecuteNonQuery();

                    MessageBox.Show("Deletado com sucesso!", "Aviso");

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
                    else if (Route!.Contains("Motoristas"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"INNER JOIN TelefoneFuncionario ON {mapper.TypeDataDatabase}.ID_motorista = TelefoneFuncionario.ID_for_funcionario " +
                            $"INNER JOIN CelularFuncionario ON {mapper.TypeDataDatabase}.ID_motorista = CelularFuncionario.ID_for_funcionario " +
                            $"INNER JOIN EmailFuncionario ON {mapper.TypeDataDatabase}.ID_motorista = EmailFuncionario.ID_for_funcionario;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Veiculos"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN Carroceria ON {mapper.TypeDataDatabase}.ID_veiculo = Carroceria.ID_carroceria " +
                            $"LEFT JOIN TipoVeiculo ON {mapper.TypeDataDatabase}.ID_veiculo = TipoVeiculo.ID_tipo_veiculo " +
                            $"LEFT JOIN Modelo ON {mapper.TypeDataDatabase}.ID_veiculo = Modelo.ID_modelo " +
                            $"LEFT JOIN Marca ON {mapper.TypeDataDatabase}.Placa = Marca.ID_marca " +
                            $"LEFT JOIN Manutencao ON {mapper.TypeDataDatabase}.ID_veiculo = Manutencao.ID_for_veiculo;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Pedidos"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"INNER JOIN Cliente ON {mapper.TypeDataDatabase}.ID_for_cliente = Cliente.ID_cliente " +
                            $"LEFT JOIN ClienteFisico ON {mapper.TypeDataDatabase}.ID_for_cliente = ClienteFisico.ID_for_cliente " +
                            $"LEFT JOIN ClienteJuridico ON {mapper.TypeDataDatabase}.ID_for_cliente = ClienteJuridico.ID_for_cliente;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Empresa"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN Manutencao ON {mapper.TypeDataDatabase}.Nome_fantasia = Manutencao.ID_for_empresa", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Processo"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN ProcessoManutencao ON ProcessoManutencao.ID_processo_manutencao = {mapper.TypeDataDatabase}.ID_manutencao " +
                            $"LEFT JOIN Veiculo ON Veiculo.ID_veiculo = {mapper.TypeDataDatabase}.ID_for_veiculo " +
                            $"LEFT JOIN PessoaJuridica ON PessoaJuridica.Nome_fantasia = {mapper.TypeDataDatabase}.ID_for_empresa;", conexao);

                        MySqlDataAdapter mySqlDataAdapter = new(comando);

                        mySqlDataAdapter.Fill(dados);

                        dataGridView.DataSource = dados;
                    }
                    else if (Route!.Contains("Terceiros"))
                    {
                        MySqlCommand comando = new($"SELECT * FROM {mapper.TypeDataDatabase} " +
                            $"LEFT JOIN TelefoneMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = TelefoneMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN CelularMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = CelularMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN EmailMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = EmailMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN ContratoMotoristaTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = ContratoMotoristaTerceiro.ID_for_motorista " +
                            $"LEFT JOIN VeiculoTerceiro ON {mapper.TypeDataDatabase}.ID_motorista_terceiro = VeiculoTerceiro.ID_for_motorista;", conexao);

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
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
