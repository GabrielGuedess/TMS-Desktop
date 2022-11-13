using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Properties;
using Interface.Utilities;
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
                    //dateNascimento.Format = DateTimePickerFormat.Short;
                    dateNascimento.Text = value["Data_de_Nascimento"].ToString();
                    comboGenero.Text = value["Genero"].ToString();
                    mkCelular.Text = value["Celular"].ToString();
                    mkTelefone.Text = value["Telefone"].ToString();
                    textEmail.Text = value["Email"].ToString();
                    mkCEP.Text = value["CEP"].ToString();
                    comboUF.Text = value["Estado"].ToString();
                    comboCidade.Text = value["CIDADE"].ToString();
                    tbLogradouro.Text = value["Logradouro"].ToString();
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
                    if (dateFimAtividade.Text == "") { }
                    else
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
                List<string> notValidar = new();
                notValidar.Add(tbComplemento.Name);
                notValidar.Add(mkTelefone.Name);
                notValidar.Add(dateFimAtividade.Name);
                if (Type.Contains("Cadastro") && Validation.Validar(contentTerceiros, notValidar) && Validation.validarTelefone(mkTelefone))
                {
                    string SQL;
                    SQL = "Insert Into tbTerceiros (CPF, Nome , Email, Telefone," +
                        " Celular, CEP, Endereco, Numero, Complemento, Bairro, Cidade," +
                        " Estado, NumeroCNH, CategoriaCNH, VencimentoCNH, NumeroRNTRC, VencimentoRNTRC" +
                        ", TipoVeiculo, CursoMOPP, TipoContrato, Situacao, DataInicioAtividades," +
                        " DataFimAtividades, Genero, Data_de_Nascimento, Logradouro) Values ";
                    SQL += $"('{mkCPF.Text}', '{tbNome.Text}', '{textEmail.Text}', '{mkTelefone.Text}', '{mkCelular.Text}'" +
                        $", '{mkCEP.Text}', '{tbLogradouro.Text}', '{tbNumCasa.Text}', '{tbComplemento.Text}', '{tbBairro.Text}'" +
                        $", '{comboCidade.Text}', '{comboUF.Text}', '{mkCNH.Text}', '{comboCategoriaCNH.Text}','{dateVencimentoCNH.Text}', '{mkRNTRC.Text}'" +
                        $", '{dateVencimentoRENTRC.Text}', '{comboTipoVeiculo.Text}', '{comboMOPP.Text}'" +
                        $", '{comboTipoContrato.Text}', '{comboSituacaoContrato.Text}', '{dateInicioAtividade.Text}', '{dateFimAtividade.Text}'," +
                        $"'{comboGenero.Text}', '{dateNascimento.Text}', '{tbLogradouro.Text}')";

                    ConnectDB connectDB = new ConnectDB();
                    connectDB.cadastrar(SQL);

                    limpar.CleanControl(contentTerceiros);
                    limpar.CleanControl(searchPanel);
                }

                if (Type.Contains("Update") && Validation.Validar(contentTerceiros, notValidar) && Validation.validarTelefone(mkTelefone))
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
            catch (System.Exception erro)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mkCEP.MaskCompleted)
            {
                ClientCEP clientCEP = new();
                var result = clientCEP.getCEP(mkCEP.Text);
                if (result.UF == null)
                {
                    return;
                }
                tbBairro.Text = result.Bairro;
                comboCidade.Text = result.Cidade;
                comboUF.Text = result.UF;
                tbLogradouro.Text = result.Logradouro;
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo CEP corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
