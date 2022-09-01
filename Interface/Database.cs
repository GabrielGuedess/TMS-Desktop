using System.Data;
using System.Data.OleDb;

namespace Interface
{
    internal class Database
    {
        string TypeData = "";
        string TypePessoa = "";

        string TypeWhere = "";

        DataTable dados = new();

        public string GetData
        {

            set
            {
                dados.Rows.Clear();
                dados.Columns.Clear();

                TypeData = value;
            }
        }

        public string PessoaData
        {

            set
            {
                dados.Rows.Clear();
                dados.Columns.Clear();

                TypePessoa = value;
            }
        }

        public void GetDataGridView(DataGridView dataGridView, MaskedTextBox maskedTextBox)
        {
            try
            {
                dados.Rows.Clear();
                dados.Columns.Clear();
                dataGridView.DataSource = null;

                if (TypeData.Contains("Clientes"))
                {
                    TypeData = TypePessoa;
                    TypeWhere = TypeData == "Clientes_Fisicos" ? "CPF" : "CPNJ";
                }

                if (TypeData.Contains("Usuarios"))
                {
                    TypeData = "Usuario";
                    TypeWhere = "CPF";
                }

                if (TypeData.Contains("Rotas"))
                {
                    TypeData = "Rotas";
                    TypeWhere = "ID_Rota";
                }

                if (TypeData.Contains("Motoristas"))
                {
                    TypeData = "C_Motoristas";
                    TypeWhere = "CPF";
                }

                if (TypeData.Contains("Veiculos"))
                {
                    TypeData = "tbVeiculos";
                    TypeWhere = "Placa";
                }

                if (TypeData.Contains("Terceiros"))
                {
                    TypeData = "tbTerceiros";
                    TypeWhere = "CPF";
                }

                if (TypeData.Contains("Sinistros"))
                {
                    TypeData = "tbSinistros";
                    TypeWhere = "ID";
                }

                if (TypeData.Contains("Notas"))
                {
                    TypeData = "C_Nota_Fiscal";
                    TypeWhere = "CHAVE_ACESSO";
                }

                if (TypeData.Contains("Tarifas"))
                {
                    TypeData = "Tarifas_taxas";
                    TypeWhere = "Nome_Emp";
                }

                if (TypeData.Contains("Redes"))
                {
                    TypeData = "C_Redes_de_Transporte";
                    TypeWhere = "NUM_ID";
                }

                

                OleDbConnection conexao = new($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath + "/bd/Banco de dados V2.mdb"}");

                OleDbCommand cmd = new($"SELECT * FROM {TypeData}", conexao);

                OleDbDataAdapter sda = new(cmd);

                sda.Fill(dados);

                dataGridView.DataSource = dados;

                if (maskedTextBox.MaskCompleted == true && maskedTextBox.Text != "")
                {
                    dados.Rows.Clear();
                    dados.Columns.Clear();

                    OleDbCommand cmdWhere = new($"SELECT * FROM {TypeData} WHERE {TypeWhere} = '{maskedTextBox.Text}'", conexao);

                    OleDbDataAdapter sdaWhere = new(cmdWhere);

                    sdaWhere.Fill(dados);

                    dataGridView.DataSource = dados;
                }

                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
