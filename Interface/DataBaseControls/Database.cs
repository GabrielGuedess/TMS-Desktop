using System.Data;
using System.Data.OleDb;
using Interface.FormsControls;

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
                    OleDbConnection conexao = new($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath + "/bd/Banco de dados V2.mdb"}");

                    conexao.Open();

                    if (maskedTextBox.MaskCompleted == true && maskedTextBox.Text != "")
                    {
                        OleDbCommand cmdWhere = new($"SELECT * FROM {mapper.TypeDataDatabase} WHERE {mapper.TypeWhereDatabase} = '{maskedTextBox.Text}'", conexao);

                        OleDbDataAdapter sdaWhere = new(cmdWhere);

                        sdaWhere.Fill(dados);

                        dataGridView.DataSource = dados;
                    }

                    OleDbCommand cmd = new($"SELECT * FROM {mapper.TypeDataDatabase}", conexao);

                    OleDbDataAdapter sda = new(cmd);

                    sda.Fill(dados);

                    dataGridView.DataSource = dados;

                    conexao.Close();
                }

                if (selectOrDelete.Contains("Delete") && maskedTextBox.MaskCompleted == true && maskedTextBox.Text != "")
                {
                    OleDbConnection conexao = new($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath + "/bd/Banco de dados V2.mdb"}");

                    conexao.Open();

                    string cmdDelete = $"DELETE * FROM {mapper.TypeDataDatabase} WHERE {mapper.TypeWhereDatabase} = '{maskedTextBox.Text}'";

                    OleDbCommand sdaDelte = new(cmdDelete, conexao);

                    sdaDelte.ExecuteNonQuery();

                    MessageBox.Show("Deletado com sucesso!", "Aviso");

                    OleDbCommand cmd = new($"SELECT * FROM {mapper.TypeDataDatabase}", conexao);

                    OleDbDataAdapter sda = new(cmd);

                    sda.Fill(dados);

                    dataGridView.DataSource = dados;

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
