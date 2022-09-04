﻿using System.Data;
using System.Data.OleDb;

namespace Interface.Properties
{
    public class ConnectDB
    {
        readonly LimparFormularios limpar = new();

        private OleDbConnection DB = new OleDbConnection($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath + "/bd/Banco de dados V2.mdb"}");

        public void cadastrar(string SQL)
        {
            try
            {
                DB.Open();

                OleDbCommand comando = new OleDbCommand(SQL, DB);

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com sucesso", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        public DataTable? pesquisar(string SQL)
        {
            try
            {
                DB.Open();
                OleDbCommand comando = new OleDbCommand();

                comando.Connection = DB;
                DataTable? dados = new DataTable();

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

                return dados!;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

                return null;
            }

        }

        public DataRow? pesquisarRow(string SQL, Panel panelClear)
        {
            try
            {
                DB.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = DB;

                DataTable dados = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(SQL, DB);

                adaptador.Fill(dados);

                if (dados.Rows.Count > 0)
                {
                    DataRow dadosRow = dados.Rows[0];

                    DB.Close();

                    return dadosRow;
                }
                else
                {
                    MessageBox.Show("Dado não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar.CleanControl(panelClear);

                    DB.Close();

                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

                return null;
            }

        }
    }
}
