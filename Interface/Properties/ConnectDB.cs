using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Properties
{
    public class ConnectDB
    {
        private static string pasta = Application.StartupPath + @"/bd/Banco de dados V2.mdb";
        private static string conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pasta;
        private OleDbConnection DB = new OleDbConnection(conexao);
        public void cadastrar(string SQL)
        {
            try
            {
                DB.Open();
                // Cria o comando do SQL na conexão aberta
                OleDbCommand comando = new OleDbCommand(SQL, DB);

                // Médodo para executar o comando SQL que não retorna dados.
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public DataTable pesquisar(string SQL)
        {
            try
            {
                DB.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = DB;
                DataTable dados = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(SQL, DB);
                adaptador.Fill(dados);
                if (dados.Rows.Count == 0)
                {
                    dados = null;
                }
                else
                {
                    DB.Close();
                }

                return dados;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }

        }
    }
}
