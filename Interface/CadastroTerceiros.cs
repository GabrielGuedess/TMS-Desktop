using Interface.Properties;
using System.Data.OleDb;

namespace Interface
{
    public partial class CadastroTerceiros : UserControl
    {
        readonly Utilidades utils = new();

        public string TypeControl
        {
            set
            {
                cadastrarTerceiro.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentTerceiros.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentTerceiros.Location = new Point(0, 62);
                }
            }
        }

        public CadastroTerceiros()
        {
            InitializeComponent();
        }

        private void CadastroTerceiros_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelCPF, panelTextCPFClient, panelEmail, panelTextEndereco, panelCNH, panelFim);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarTerceiro_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarTerceiro);
        }

        private void cadastrarTerceiro_Click(object sender, EventArgs e)
        {
            try
            {
                var conexao = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Resources.Database}";
                string SQL;
                //Comando SQL
                SQL = "Insert Into tbTerceiros (CPF, Nome , Email, Telefone," +
                    " Celular, CEP, Endereco, Numero, Complemento, Bairro, Cidade," +
                    " Estado, NumeroCNH, CategoriaCNH, VencimentoCNH, NumeroRNTRC, VencimentoRNTRC" +
                    ", TipoVeiculo, CursoMOPP, TipoContrato, Situacao, DataInicioAtividades," +
                    " DataFimAtividades) Values ";
                SQL += $"('{mkCPF.Text}', '{tbNome.Text}', '{textEmail.Text}', '{mkTelefone.Text}', '{mkCelular.Text}'" +
                    $", '{mkCEP.Text}', '{tbLogradouro.Text}', '{tbNumCasa.Text}', '{tbComplemento.Text}', '{tbBairro.Text}'" +
                    $", '{comboCidade.Text}', '{comboUF.Text}', '{mkCNH.Text}', '{comboCategoriaCNH.Text}','{dateVencimentoCNH.Text}', '{mkRNTRC.Text}'" +
                    $", '{dateVencimentoRENTRC.Text}', '{comboTipoVeiculo.Text}', '{comboMOPP.Text}'" +
                    $", '{comboTipoContrato.Text}', '{comboSituacaoContrato.Text}', '{dateInicioAtividade.Text}', '{dateFimAtividade.Text}')";
                OleDbConnection DB = new OleDbConnection(conexao);
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
    }
}
