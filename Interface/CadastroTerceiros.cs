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
                if (validarControles() == false)
                {
                    return;
                }
                
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
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentTerceiros);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private bool validarControles()
        {

            MessageBoxButtons botao = MessageBoxButtons.OK;

            MessageBoxIcon icone = MessageBoxIcon.Information;



            if (mkCPF.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo CPF corretamente!", "Erro", botao, icone);
                mkCPF.Focus();
                return false;
            }

            else if (tbNome.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Nome!", "Erro", botao, icone);
                tbNome.Focus();
                return false;
            }

            else if (mkCelular.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo celular corretamente!", "Erro", botao, icone);
                mkCelular.Focus();
                return false;
            }
            else if (mkTelefone.Text.Length > 1 && mkTelefone.Text.Length < 10)
            {
                MessageBox.Show("É necessário preencher o campo telefone corretamente!", "Erro", botao, icone);
                mkTelefone.Focus();
                return false;
            }
            else if (mkCEP.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo CEP corretamente!", "Erro", botao, icone);
                mkCEP.Focus();
                return false;
            }
            else if (mkRNTRC.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo Nº RNTRC corretamente!", "Erro", botao, icone);
                mkRNTRC.Focus();
                return false;
            }
            else if (mkCNH.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo Nº CNH corretamente!", "Erro", botao, icone);
                mkCNH.Focus();
                return false;
            }
            else if (dateVencimentoRENTRC.Text == " ")
            {
                MessageBox.Show("É necessário preencher o campo de vencimento da RNTRC corretamente!", "Erro", botao, icone);
                dateVencimentoRENTRC.Focus();
                return false;
            }
            else if (dateVencimentoCNH.Text == " ")
            {
                MessageBox.Show("É necessário preencher o campo de vencimento da CNH corretamente!", "Erro", botao, icone);
                dateVencimentoCNH.Focus();
                return false;
            }
            else if (dateInicioAtividade.Text == " ")
            {
                MessageBox.Show("É necessário preencher o campo de Data de Início das Atividades corretamente!", "Erro", botao, icone);
                dateInicioAtividade.Focus();
                return false;
            }
            else if (comboMOPP.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Curso MOPP corretamente!", "Erro", botao, icone);
                comboMOPP.Focus();
                return false;
            }
            else if (comboTipoVeiculo.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo de Tipo de Veículo corretamente!", "Erro", botao, icone);
                comboTipoVeiculo.Focus();
                return false;
            }
            else if (comboTipoContrato.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Tipo de Contrato corretamente!", "Erro", botao, icone);
                comboTipoContrato.Focus();
                return false;
            }
            else if (comboSituacaoContrato.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Situação corretamente!", "Erro", botao, icone);
                comboSituacaoContrato.Focus();
                return false;
            }
            else if (tbLogradouro.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Logradouro corretamente!", "Erro", botao, icone);
                tbLogradouro.Focus();
                return false;
            }
            else if (tbBairro.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Bairro corretamente!", "Erro", botao, icone);
                tbBairro.Focus();
                return false;
            }
            else if (tbNumCasa.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo N° corretamente!", "Erro", botao, icone);
               tbNumCasa.Focus();
                return false;
            }
            else if (comboCidade.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Cidade corretamente!", "Erro", botao, icone);
                comboCidade.Focus();
                return false;
            }
            else if (comboUF.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo UF corretamente!", "Erro", botao, icone);
                comboUF.Focus();
                return false;
            }
            else if (comboGenero.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Genero corretamente!", "Erro", botao, icone);
                comboGenero.Focus();
                return false;
            }
            else if (textEmail.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Email corretamente!", "Erro", botao, icone);
                textEmail.Focus();
                return false;
            }
            else if (comboCategoriaCNH.Text == String.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Categoria CNH corretamente!", "Erro", botao, icone);
                comboCategoriaCNH.Focus();
                return false;
            }
            return true;

        }
    }
}
