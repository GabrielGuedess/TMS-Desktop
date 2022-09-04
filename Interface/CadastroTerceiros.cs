using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroTerceiros : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                cadastrarTerceiro.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentTerceiros.Location = new Point(0, 0);

                    mkCPF.ReadOnly = false;
                    mkCPF.Cursor = Cursors.IBeam;
                    buscarCPF.Visible = false;
                }

                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentTerceiros.Location = new Point(0, 62);


                    mkCPF.ReadOnly = true;
                    mkCPF.Cursor = Cursors.No;
                    buscarCPF.Visible = true;
                }
            }
        }
        public DataRow OverviewDataResponse
        {
            set
            {
                maskCpf.Text = value["CPF"].ToString();

                if (value != null)
                {
                    mkCPF.Text = value["CPF"].ToString();
                    tbNome.Text = value["Nome"].ToString();
                    //dateNascimento.Text = value["*"].ToString();
                    //comboGenero.Text = value["*"].ToString();
                    mkCelular.Text = value["Celular"].ToString();
                    mkTelefone.Text = value["Telefone"].ToString();
                    textEmail.Text = value["Email"].ToString();
                    mkCEP.Text = value["CEP"].ToString();
                    comboUF.Text = value["Estado"].ToString();
                    comboCidade.Text = value["CIDADE"].ToString();
                    //tbLogradouro.Text = value["*"].ToString();
                    tbNumCasa.Text = value["Numero"].ToString();
                    tbBairro.Text = value["Bairro"].ToString();
                    tbComplemento.Text = value["Complemento"].ToString();

                    mkCNH.Text = value["NumeroCNH"].ToString();
                    comboCategoriaCNH.Text = value["CategoriaCNH"].ToString();
                    comboMOPP.Text = value["CursoMOPP"].ToString();
                    dateVencimentoCNH.Text = value["VencimentoCNH"].ToString();
                    mkRNTRC.Text = value["NumeroRNTRC"].ToString();
                    dateVencimentoRENTRC.Text = value["VencimentoRNTRC"].ToString();
                    comboTipoVeiculo.Text = value["TipoVeiculo"].ToString();

                    comboTipoContrato.Text = value["TipoContrato"].ToString();
                    comboSituacaoContrato.Text = value["Situacao"].ToString();
                    dateInicioAtividade.Text = value["DataInicioAtividades"].ToString();
                    dateFimAtividade.Text = value["DataFimAtividades"].ToString();
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
        private void buscarCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCPF);
        }

        private void cadastrarTerceiro_Click(object sender, EventArgs e)
        {
            try
            {
                if (Type.Contains("Cadastro") && validarControles())
                {
                    string SQL;
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

                    limpar.CleanControl(contentTerceiros);
                    limpar.CleanControl(searchPanel);
                }

                if (Type.Contains("Update") && validarControles())
                {
                    string SQLUp = $"UPDATE tbTerceiros SET " +
                    $"Nome= '{tbNome.Text}', " +
                    //$"Email= '{dateNascimento.Text}', " +
                    //$"Num_Cel= '{comboGenero.Text}', " +
                    $"Celular= '{mkCelular.Text}', " +
                    $"Telefone= '{mkTelefone.Text}', " +
                    $"Email= '{textEmail.Text}', " +
                    $"CEP= '{mkCEP.Text}', " +
                    $"Estado= '{comboUF.Text}', " +
                    $"CIDADE= '{comboCidade.Text}', " +
                    //$"Num_Cel= '{tbLogradouro.Text}', " +
                    $"Numero= '{tbNumCasa.Text}', " +
                    $"Bairro= '{tbBairro.Text}', " +
                    $"Complemento= '{tbComplemento.Text}', " +

                    $"NumeroCNH= '{mkCNH.Text}', " +
                    $"CategoriaCNH= '{comboCategoriaCNH.Text}', " +
                    $"CursoMOPP= '{comboMOPP.Text}', " +
                    $"VencimentoCNH= '{dateVencimentoCNH.Text}', " +
                    $"NumeroRNTRC= '{mkRNTRC.Text}', " +
                    $"VencimentoRNTRC= '{dateVencimentoRENTRC.Text}', " +
                    $"TipoVeiculo= '{comboTipoVeiculo.Text}', " +

                    $"TipoContrato= '{comboTipoContrato.Text}', " +
                    $"Situacao= '{comboSituacaoContrato.Text}', " +
                    $"DataInicioAtividades= '{dateInicioAtividade.Text}', " +
                    $"DataFimAtividades= '{dateFimAtividade.Text}' " +
                    $"WHERE CPF = '{maskCpf.Text.Replace('.', ',')}'";

                    ConnectDB connectDB = new();
                    connectDB.cadastrar(SQLUp);

                    limpar.CleanControl(contentTerceiros);
                    limpar.CleanControl(searchPanel);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void buscarCPF_Click(object sender, EventArgs e)
        {
            if (maskCpf.MaskCompleted)
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM tbTerceiros WHERE CPF = '{maskCpf.Text}'", contentTerceiros)!;

                if (dados != null)
                {
                    maskCpf.Text = dados["CPF"].ToString();

                    tbNome.Text = dados["Nome"].ToString();
                    dateNascimento.Text = dados["Data_de_Nascimento"].ToString();
                    comboGenero.Text = dados["Genero"].ToString();
                    mkCelular.Text = dados["Celular"].ToString();
                    mkTelefone.Text = dados["Telefone"].ToString();
                    textEmail.Text = dados["Email"].ToString();
                    mkCEP.Text = dados["CEP"].ToString();
                    comboUF.Text = dados["Estado"].ToString();
                    comboCidade.Text = dados["CIDADE"].ToString();
                    tbLogradouro.Text = dados["Logradouro"].ToString();
                    tbNumCasa.Text = dados["Numero"].ToString();
                    tbBairro.Text = dados["Bairro"].ToString();
                    tbComplemento.Text = dados["Complemento"].ToString();

                    mkCNH.Text = dados["NumeroCNH"].ToString();
                    comboCategoriaCNH.Text = dados["CategoriaCNH"].ToString();
                    comboMOPP.Text = dados["CursoMOPP"].ToString();
                    dateVencimentoCNH.Text = dados["VencimentoCNH"].ToString();
                    mkRNTRC.Text = dados["NumeroRNTRC"].ToString();
                    dateVencimentoRENTRC.Text = dados["VencimentoRNTRC"].ToString();
                    comboTipoVeiculo.Text = dados["TipoVeiculo"].ToString();

                    comboTipoContrato.Text = dados["TipoContrato"].ToString();
                    comboSituacaoContrato.Text = dados["Situacao"].ToString();
                    dateInicioAtividade.Text = dados["DataInicioAtividades"].ToString();
                    dateFimAtividade.Text = dados["DataFimAtividades"].ToString();
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
            }
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            maskCpf.Focus();
        }

        private void maskCpf_TextChanged(object sender, EventArgs e)
        {
            mkCPF.Text = maskCpf.Text;

            utils.feedbackColorInput(maskCpf, typeData);
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
