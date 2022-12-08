using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Properties;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Numerics;

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

                if (value != null)
                {
                    maskCpf.Text = value["CPF"].ToString();

                    mkCPF.Text = value["CPF"].ToString();
                    tbNome.Text = value["Nome"].ToString();
                    tbRg.Text = value["RG"].ToString();
                    dateNascimento.Text = value["Data_nascimento"].ToString();
                    comboGenero.Text = value["Genero"].ToString();
                    mkCelular.Text = value["Celular"].ToString();
                    mkTelefone.Text = value["Telefone"].ToString();
                    tbEmail.Text = value["Email"].ToString();
                    mkCEP.Text = value["CEP"].ToString();
                    comboUF.Text = value["UF"].ToString();
                    tbBairro.Text = value["Bairro"].ToString();
                    comboCidade.Text = value["Cidade"].ToString();
                    tbLogradouro.Text = value["Logradouro"].ToString();
                    tbComplemento.Text = value["Complemento_endereco"].ToString();
                    tbNumCasa.Text = value["Numero_endereco"].ToString();
                    mkCNH.Text = value["Numero_CNH"].ToString();
                    comboCategoriaCNH.Text = value["Categoria_CNH"].ToString();
                    dateVencimentoCNH.Text = value["Vencimento_CNH"].ToString();
                    comboMOPP.Text = value["Curso_MOPP"].ToString();

                    comboVeiculoProprio.Text = value["Veiculo_proprio"].ToString();
                    tbPlaca.Text = value["Placa"].ToString();
                    comboMarca.Text = value["Marca"].ToString();
                    comboTipoVeiculo.Text = value["Tipo_veiculo"].ToString();
                    comboModelo.Text = value["Modelo"].ToString();
                    mkAno.Text = value["Ano_fabricao"].ToString();
                    mkRNTRC.Text = value["Cod_RNTRC"].ToString();
                    dateVencimentoRENTRC.Text = value["Vencimento_RNTRC"].ToString();
                    mkRenavam.Text = value["Cod_RENAVAM"].ToString();
                    mkCodigoCIOT.Text = value["Cod_CIOT"].ToString();
                    tbPesoVeiculo.Text = value["Massa_modelo"].ToString();
                    tbQuantEixos.Text = value["Eixo_modelo"].ToString();
                    tbCapacidadePesoMax.Text = value["Capacidade_KG"].ToString();
                    comboTipoCarroceria.Text = value["Carroceria"].ToString();
                    tbCapacidadeVolumetrica.Text = value["Capacidade_volumetrica"].ToString();
                    tbPesoCarroceria.Text = value["Massa_carroceria"].ToString();

                    comboTipoContrato.Text = value["Tipo_contrato"].ToString();
                    comboSituacaoContrato.Text = value["Situacao_contrato"].ToString();
                    dateInicioAtividade.Text = value["Inicio_contrato"].ToString();
                    dateFimAtividade.Text = value["Fim_contrato"].ToString();
                }
            }
        }

        public CadastroTerceiros()
        {
            InitializeComponent();
            disableFieldsVeiculo(false);

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
                if (comboVeiculoProprio.SelectedIndex == 0)
                {
                    notValidar.Add(tbPlaca.Name);
                    notValidar.Add(mkAno.Name);
                    notValidar.Add(mkRNTRC.Name);
                    notValidar.Add(dateVencimentoRENTRC.Name);
                    notValidar.Add(panelTipoVeiculo.Name);
                    notValidar.Add(mkRenavam.Name);
                    notValidar.Add(mkCodigoCIOT.Name);
                    notValidar.Add(comboMarca.Name);
                    notValidar.Add(comboModelo.Name);
                    notValidar.Add(comboTipoCarroceria.Name);
                    notValidar.Add(tbPesoVeiculo.Name);
                    notValidar.Add(tbQuantEixos.Name);
                    notValidar.Add(tbQuantiEixosCarroceria.Name);
                    notValidar.Add(tbCapacidadePesoMax.Name);
                    notValidar.Add(tbCapacidadeVolumetrica.Name);
                }
                else if (comboTipoCarroceria.Items.Count == 0)
                {
                    notValidar.Add(tbCapacidadeVolumetrica.Name);
                    notValidar.Add(tbQuantiEixosCarroceria.Name);
                    notValidar.Add(comboTipoCarroceria.Name);
                    notValidar.Add(tbPesoCarroceria.Name);
                }
                if (Type.Contains("Cadastro") && Validation.Validar(contentTerceiros, notValidar) && Validation.validarTelefone(mkTelefone))
                {

                    TMSContext db = new();
                    MotoristaTerceiro terceiro = new();
                    int lastID = 0;
                    if (db.MotoristaTerceiro.Count() > 0)
                    {
                        lastID = db.MotoristaTerceiro.Max(id => id.ID_motorista_terceiro) + 1;
                    }

                    terceiro.ID_motorista_terceiro = lastID;
                    terceiro.CPF = mkCPF.Text;
                    terceiro.Nome = tbNome.Text;
                    terceiro.RG = tbRg.Text;
                    terceiro.Data_nascimento = dateNascimento.convertDateOnly();
                    terceiro.Genero = comboGenero.Text;
                    terceiro.CEP = mkCEP.Text;
                    terceiro.UF = comboUF.Text;
                    terceiro.Bairro = tbBairro.Text;
                    terceiro.Cidade = comboCidade.Text;
                    terceiro.Logradouro = tbLogradouro.Text;
                    terceiro.Complemento_endereco = tbComplemento.Text;
                    terceiro.Numero_endereco = tbNumCasa.Text;
                    terceiro.Numero_CNH = mkCNH.Text;
                    terceiro.Categoria_CNH = comboCategoriaCNH.Text;
                    terceiro.Vencimento_CNH = dateVencimentoCNH.convertDateOnly();
                    terceiro.Curso_MOPP = comboMOPP.Text;

                    CelularMotoristaTerceiro celular = new CelularMotoristaTerceiro
                    {
                        Celular = mkCelular.Text,
                        ID_for_motorista = lastID
                    };

                    TelefoneMotoristaTerceiro telefone = new TelefoneMotoristaTerceiro
                    {
                        Telefone = mkTelefone.Text,
                        ID_for_motorista = lastID
                    };


                    ContratoMotoristaTerceiro contrato = new ContratoMotoristaTerceiro
                    {
                        ID_for_motorista = lastID,
                        Tipo_contrato = comboTipoContrato.Text,
                        Inicio_contrato = dateInicioAtividade.convertDateOnly(),
                        Situacao_contrato = comboSituacaoContrato.Text,
                        Veiculo_proprio = comboVeiculoProprio.Text,
                    };

                    if (dateFimAtividade.Text.Length > 0)
                    {
                        contrato.Fim_contrato = dateFimAtividade.convertDateOnly();
                    }
                    if (comboVeiculoProprio.SelectedIndex == 1)
                    {
                        VeiculoTerceiro veiculo = new VeiculoTerceiro
                        {
                            //possibilidade de revisão
                            ID_for_motorista = lastID,
                            //ID_veiculo_terceiro = lastID,
                            Ano_fabricao = Convert.ToInt16(mkAno.Text),
                            Capacidade_KG = tbCapacidadePesoMax.returnValue(),


                            Cod_CIOT = mkCodigoCIOT.Text,
                            Cod_RENAVAM = mkRenavam.Text,
                            Cod_RNTRC = mkRNTRC.Text,

                            Eixo_modelo = sbyte.Parse(tbQuantEixos.Text),
                            Marca = comboMarca.Text,
                            Tipo_veiculo = comboTipoVeiculo.Text,
                            Massa_modelo = tbPesoVeiculo.returnValue(),
                            Placa = tbPlaca.Text,
                            Modelo = comboModelo.Text,
                            Vencimento_RNTRC = dateVencimentoRENTRC.convertDateOnly()
                        };
                        if (comboTipoCarroceria.Text != "" && comboTipoCarroceria.Enabled == true)
                        {
                            veiculo.Eixo_carroceria = sbyte.Parse(tbQuantiEixosCarroceria.Text);
                            veiculo.Massa_carroceria = tbPesoCarroceria.returnValue();
                            veiculo.Carroceria = comboTipoCarroceria.Text;
                            veiculo.Capacidade_volumetrica = tbCapacidadeVolumetrica.returnValue();
                        }
                        terceiro.VeiculoTerceiro.Add(veiculo);
                    }
                    EmailMotoristaTerceiro email = new EmailMotoristaTerceiro
                    {
                        Email = tbEmail.Text,
                        ID_for_motorista = lastID
                    };
                    terceiro.CelularMotoristaTerceiro.Add(celular);
                    terceiro.TelefoneMotoristaTerceiro.Add(telefone);
                    terceiro.ContratoMotoristaTerceiro.Add(contrato);
                    terceiro.EmailMotoristaTerceiro.Add(email);


                    db.MotoristaTerceiro.Add(terceiro);
                    db.SaveChanges();



                    limpar.CleanControl(contentTerceiros);
                    limpar.CleanControl(searchPanel);
                }

                if (Type.Contains("Update") && Validation.Validar(contentTerceiros, notValidar) && Validation.validarTelefone(mkTelefone))
                {
                    TMSContext db = new();
                    var terceiro = db.MotoristaTerceiro.
                    Include(a => a.CelularMotoristaTerceiro).
                    Include(a => a.ContratoMotoristaTerceiro).
                    Include(a => a.TelefoneMotoristaTerceiro).
                    Include(a => a.EmailMotoristaTerceiro).
                    Include(a => a.VeiculoTerceiro)
                    .FirstOrDefault(a => a.CPF == maskCpf.Text);

                    terceiro.CPF = mkCPF.Text;
                    terceiro.Nome = tbNome.Text;
                    terceiro.RG = tbRg.Text;
                    terceiro.Data_nascimento = dateNascimento.convertDateOnly();
                    terceiro.Genero = comboGenero.Text;
                    terceiro.CEP = mkCEP.Text;
                    terceiro.UF = comboUF.Text;
                    terceiro.Bairro = tbBairro.Text;
                    terceiro.Cidade = comboCidade.Text;
                    terceiro.Logradouro = tbLogradouro.Text;
                    terceiro.Complemento_endereco = tbComplemento.Text;
                    terceiro.Numero_endereco = tbNumCasa.Text;
                    terceiro.Numero_CNH = mkCNH.Text;
                    terceiro.Categoria_CNH = comboCategoriaCNH.Text;
                    terceiro.Vencimento_CNH = dateVencimentoCNH.convertDateOnly();
                    terceiro.Curso_MOPP = comboMOPP.Text;

                    terceiro.CelularMotoristaTerceiro.First().Celular = mkCelular.Text;
                    terceiro.TelefoneMotoristaTerceiro.First().Telefone = mkTelefone.Text;

                    terceiro.ContratoMotoristaTerceiro.First().Tipo_contrato = comboTipoContrato.Text;
                    terceiro.ContratoMotoristaTerceiro.First().Inicio_contrato = dateInicioAtividade.convertDateOnly();
                    terceiro.ContratoMotoristaTerceiro.First().Situacao_contrato = comboSituacaoContrato.Text;
                    terceiro.ContratoMotoristaTerceiro.First().Veiculo_proprio = comboVeiculoProprio.Text;
                    if (dateFimAtividade.Text.Length > 0)
                    {
                        terceiro.ContratoMotoristaTerceiro.First().Fim_contrato = dateFimAtividade.convertDateOnly();
                    }
                    terceiro.EmailMotoristaTerceiro.First().Email = tbEmail.Text;
                    //caso um terceiro não dirija mais o seu veiculo proprio
                    if (comboVeiculoProprio.SelectedIndex == 0)
                    {
                        db.VeiculoTerceiro.Remove(terceiro.VeiculoTerceiro.First());
                    }
                    //caso o terceiro não tenha um veiculo mas quer add um depois de já cadastrato
                    else if (terceiro.VeiculoTerceiro.Count == 0)
                    {
                        VeiculoTerceiro veiculo = new VeiculoTerceiro
                        {
                            ID_for_motorista = terceiro.ID_motorista_terceiro,
                            Ano_fabricao = Convert.ToInt16(mkAno.Text),
                            Capacidade_KG = tbCapacidadePesoMax.returnValue(),
                            Capacidade_volumetrica = tbCapacidadeVolumetrica.returnValue(),
                            Carroceria = comboTipoCarroceria.Text,
                            Cod_CIOT = mkCodigoCIOT.Text,
                            Cod_RENAVAM = mkRenavam.Text,
                            Cod_RNTRC = mkRNTRC.Text,
                            Eixo_carroceria = sbyte.Parse(tbQuantiEixosCarroceria.Text),
                            Eixo_modelo = sbyte.Parse(tbQuantEixos.Text),
                            Marca = comboMarca.Text,
                            Massa_carroceria = tbPesoCarroceria.returnValue(),
                            Massa_modelo = tbPesoVeiculo.returnValue(),
                            Placa = tbPlaca.Text,
                            Modelo = comboModelo.Text,
                            Vencimento_RNTRC = dateVencimentoRENTRC.convertDateOnly(),
                            Tipo_veiculo = comboTipoVeiculo.Text
                        };
                        terceiro.VeiculoTerceiro.Add(veiculo);
                    }
                    //caso o terceiro atualize alguma coisa do seu veiculo
                    else
                    {
                        terceiro.VeiculoTerceiro.First().Ano_fabricao = Convert.ToInt16(mkAno.Text);
                        terceiro.VeiculoTerceiro.First().Capacidade_KG = tbCapacidadePesoMax.returnValue();
                        terceiro.VeiculoTerceiro.First().Capacidade_volumetrica = tbCapacidadeVolumetrica.returnValue();
                        terceiro.VeiculoTerceiro.First().Carroceria = comboTipoCarroceria.Text;
                        terceiro.VeiculoTerceiro.First().Cod_CIOT = mkCodigoCIOT.Text;
                        terceiro.VeiculoTerceiro.First().Cod_RENAVAM = mkRenavam.Text;
                        terceiro.VeiculoTerceiro.First().Cod_RNTRC = mkRNTRC.Text;
                        terceiro.VeiculoTerceiro.First().Vencimento_RNTRC = dateVencimentoRENTRC.convertDateOnly();
                        terceiro.VeiculoTerceiro.First().Eixo_carroceria = sbyte.Parse(tbQuantiEixosCarroceria.Text);
                        terceiro.VeiculoTerceiro.First().Eixo_modelo = sbyte.Parse(tbQuantEixos.Text);
                        terceiro.VeiculoTerceiro.First().Marca = comboMarca.Text;
                        terceiro.VeiculoTerceiro.First().Massa_carroceria = tbPesoCarroceria.returnValue();
                        terceiro.VeiculoTerceiro.First().Massa_modelo = tbPesoVeiculo.returnValue();
                        terceiro.VeiculoTerceiro.First().Placa = tbPlaca.Text;
                        terceiro.VeiculoTerceiro.First().Modelo = comboModelo.Text;
                        terceiro.VeiculoTerceiro.First().Tipo_veiculo = comboTipoVeiculo.Text;
                    }


                    db.SaveChanges();



                    limpar.CleanControl(contentTerceiros);
                    limpar.CleanControl(searchPanel);
                }

            }
            catch (DbUpdateException erro)
            {
                if (typeof(MySqlException).IsInstanceOfType(erro.InnerException))
                {
                    MySqlException mySqlException = (MySqlException)erro.InnerException;
                    if (MySqlErrorCode.DuplicateKeyEntry == mySqlException.ErrorCode)
                    {
                        string campoDuplicado = mySqlException.Message.Split("'")[3];
                        string valorDoCampo = mySqlException.Message.Split("'")[1];
                        MessageBox.Show($"O valor {valorDoCampo} do campo {campoDuplicado} já cadastrado."
                            + "Adicione um valor que não estaja cadastrado");
                    }
                    else if (MySqlErrorCode.DatabaseAccessDenied == mySqlException.ErrorCode)
                    {
                        MessageBox.Show("Acesso Bloqueado");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void buscarCPF_Click(object sender, EventArgs e)
        {
            if (maskCpf.MaskCompleted)
            {
                TMSContext db = new TMSContext();

                var terceiro = db.MotoristaTerceiro.
                    Include(a => a.CelularMotoristaTerceiro).
                    Include(a => a.ContratoMotoristaTerceiro).
                    Include(a => a.TelefoneMotoristaTerceiro).
                    Include(a => a.EmailMotoristaTerceiro).
                    Include(a => a.VeiculoTerceiro)
                    .FirstOrDefault(a => a.CPF == maskCpf.Text);

                if (terceiro == null)
                {
                    MessageBox.Show("Motorista não encontrado");
                    return;
                }

                mkCelular.Text = terceiro.CelularMotoristaTerceiro.First().Celular;


                tbNome.Text = terceiro.Nome;
                tbRg.Text = terceiro.RG;
                dateNascimento.Text = terceiro.Data_nascimento.ToString();
                comboGenero.Text = terceiro.Genero;
                mkCelular.Text = terceiro.CelularMotoristaTerceiro.First().Celular;
                mkTelefone.Text = terceiro.TelefoneMotoristaTerceiro.First().Telefone.ToString();
                tbEmail.Text = terceiro.EmailMotoristaTerceiro.First().Email;
                mkCEP.Text = terceiro.CEP;
                comboUF.Text = terceiro.UF;
                comboCidade.Text = terceiro.Cidade;
                tbLogradouro.Text = terceiro.Logradouro;
                tbNumCasa.Text = terceiro.Numero_endereco;
                tbBairro.Text = terceiro.Bairro;
                tbComplemento.Text = terceiro.Complemento_endereco;

                mkCNH.Text = terceiro.Numero_CNH;
                comboCategoriaCNH.Text = terceiro.Categoria_CNH;
                comboMOPP.Text = terceiro.Curso_MOPP;
                dateVencimentoCNH.Text = terceiro.Vencimento_CNH.ToString();
                comboVeiculoProprio.Text = terceiro.ContratoMotoristaTerceiro.First().Veiculo_proprio;
                if (terceiro.VeiculoTerceiro.Count == 0)
                {
                }
                else
                {
                    tbPlaca.Text = terceiro.VeiculoTerceiro.First().Placa;
                    mkAno.Text = terceiro.VeiculoTerceiro.First().Ano_fabricao.ToString();
                    mkRNTRC.Text = terceiro.VeiculoTerceiro.First().Cod_RNTRC;
                    dateVencimentoRENTRC.Text = terceiro.VeiculoTerceiro.First().Vencimento_RNTRC.ToString();
                    mkRenavam.Text = terceiro.VeiculoTerceiro.First().Cod_RENAVAM;
                    mkCodigoCIOT.Text = terceiro.VeiculoTerceiro.First().Cod_CIOT;
                    comboMarca.Text = terceiro.VeiculoTerceiro.First().Marca;
                    foreach (var item in comboTipoVeiculo.Items)
                    {
                        if (item.ToString() == terceiro.VeiculoTerceiro.First().Tipo_veiculo)
                            comboTipoVeiculo.Text = terceiro.VeiculoTerceiro.First().Tipo_veiculo;
                    }
                    comboTipoVeiculo.Text = terceiro.VeiculoTerceiro.First().Carroceria;
                    comboModelo.Text = terceiro.VeiculoTerceiro.First().Modelo;
                    tbPesoVeiculo.Text = terceiro.VeiculoTerceiro.First().Massa_modelo.ToString() + " Kg";
                    tbQuantEixos.Text = terceiro.VeiculoTerceiro.First().Eixo_modelo.ToString();
                    tbCapacidadePesoMax.Text = terceiro.VeiculoTerceiro.First().Capacidade_KG.ToString() + " Kg";
                    tbPesoVeiculo.Text = terceiro.VeiculoTerceiro.First().Massa_modelo.ToString() + " Kg";
                    if (terceiro.VeiculoTerceiro.First().Carroceria != "")
                    {
                        comboTipoCarroceria.Text = terceiro.VeiculoTerceiro.First().Carroceria;

                        tbPesoCarroceria.Text = terceiro.VeiculoTerceiro.First().Massa_carroceria.ToString() + " Kg";
                        tbQuantiEixosCarroceria.Text = terceiro.VeiculoTerceiro.First().Eixo_carroceria.ToString();
                        tbCapacidadeVolumetrica.Text = terceiro.VeiculoTerceiro.First().Capacidade_volumetrica.ToString() + " m³";

                    }
                    else
                    {
                        comboTipoCarroceria.Text = "";
                        tbPesoCarroceria.Text = "";
                        tbQuantiEixosCarroceria.Text = "";
                        tbCapacidadeVolumetrica.Text = "";
                    }
                }

                comboTipoContrato.Text = terceiro.ContratoMotoristaTerceiro.First().Tipo_contrato.ToString();
                comboSituacaoContrato.Text = terceiro.ContratoMotoristaTerceiro.First().Situacao_contrato;
                dateInicioAtividade.Text = terceiro.ContratoMotoristaTerceiro.First().Inicio_contrato.ToString();
                dateFimAtividade.Text = terceiro.ContratoMotoristaTerceiro.First().Fim_contrato.ToString();



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

        private void textBoxOnlyNum_Letters3_TextChanged(object sender, EventArgs e)
        {

        }

        async private void comboVeiculoProprio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVeiculoProprio.SelectedIndex == -1 || comboVeiculoProprio.SelectedIndex == 0)
            {
                disableFieldsVeiculo(false);
                tableInfoVeiculo.Controls.Remove(panelVeiculoProprio);
                limpar.CleanControl(tableInfoVeiculo);
                tableInfoVeiculo.Controls.Add(panelVeiculoProprio, 0, 0);
                tableContrato.Focus();
            }
            else
            {
                disableFieldsVeiculo(true);
                TMSContext db = new();

                List<Marca> marcas = await db.Marca.ToListAsync();

                comboMarca.Items.Clear();
                foreach (var nomeMarca in marcas)
                {
                    comboMarca.Items.Add(nomeMarca.Nome_marca);
                }

                List<TipoVeiculo> tipoVeiculos = await db.TipoVeiculo.ToListAsync();

                comboTipoVeiculo.Items.Clear();
                foreach (var tipoVeiculo in tipoVeiculos)
                {
                    comboTipoVeiculo.Items.Add(tipoVeiculo.Descricao);
                }
                comboMarca.SelectedIndex = -1;
                comboTipoVeiculo.SelectedIndex = -1;
            }
        }

        private void disableFieldsVeiculo(bool action)
        {
            tbPlaca.Enabled = action;
            mkAno.Enabled = action;
            mkRNTRC.Enabled = action;
            dateVencimentoRENTRC.Enabled = action;
            panelTipoVeiculo.Enabled = action;
            mkRenavam.Enabled = action;
            mkCodigoCIOT.Enabled = action;
            comboMarca.Enabled = action;
            comboModelo.Enabled = action;
            comboTipoCarroceria.Enabled = action;
            panelTipoVeiculo.Enabled = action;

        }

        async private Task UpdateModelosAndCarroceria()
        {

            if (comboTipoVeiculo.Text == "")
            {
                return;
            }
            TMSContext db = new();



            TipoVeiculo tipoVeiculo = await db.TipoVeiculo.Include(a => a.ID_for_carroceria).FirstAsync(a => a.Descricao == comboTipoVeiculo.Text);
            if (db.Modelo.Count(a => a.ID_for_tipo_veiculo == tipoVeiculo.ID_tipo_veiculo) > 0)
            {
                comboModelo.Items.Clear();
                List<Modelo> modelos = await db.Modelo.Where(a => a.ID_for_tipo_veiculo == tipoVeiculo.ID_tipo_veiculo && a.ID_for_marcaNavigation.Nome_marca == comboMarca.Text).ToListAsync();

                foreach (var modelo in modelos)
                {
                    comboModelo.Items.Add(modelo.Nome);
                }
            }
            if (comboModelo.Items.Count > 0)
            {
                comboModelo.SelectedIndex = 0;
            }

            if (tipoVeiculo != null)
            {

                if (tipoVeiculo.Possui_carroceria == 1)
                {
                    comboTipoCarroceria.Items.Clear();
                    comboTipoCarroceria.Enabled = true;
                    foreach (var item in tipoVeiculo.ID_for_carroceria.ToList())
                    {
                        comboTipoCarroceria.Items.Add(item.Descricao_carroceira);
                    }
                }
                else
                {
                    comboTipoCarroceria.Enabled = false;
                    comboTipoCarroceria.Text = "";
                    tbPesoCarroceria.Text = "";
                    tbQuantiEixosCarroceria.Text = "";
                    tbCapacidadeVolumetrica.Text = "";
                }
            }
            else
            {
                comboTipoCarroceria.Items.Clear();
            }


        }

        async private void comboTipoCarroceria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoCarroceria.SelectedIndex > -1)
            {
                Carroceria carroceria = await getInfoCarroceria(comboTipoCarroceria.Text);
                tbPesoCarroceria.Text = carroceria.Massa_carroceria.ToString() + " Kg";
                tbQuantiEixosCarroceria.Text = carroceria.Eixo_carroceria.ToString();
                tbCapacidadeVolumetrica.Text = carroceria.Capacidade_volumetrica.ToString() + " m³";
            }
        }

        async private void comboTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateModelosAndCarroceria();

        }

        async private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateModelosAndCarroceria();
        }

        async Task<Modelo> getInfoModelo(string nomeModelo)
        {
            TMSContext db = new();
            Modelo modelo = db.Modelo.FirstOrDefault(a => a.Nome == nomeModelo);
            if (modelo == null)
            {
                return null;
            }
            return modelo;
        }
        async Task<Carroceria> getInfoCarroceria(string tipoCarroceria)
        {
            TMSContext db = new();
            Carroceria carroceria = db.Carroceria.FirstOrDefault(a => a.Descricao_carroceira == tipoCarroceria);
            if (carroceria == null)
                return null;
            return carroceria;
        }

        async private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModelo.SelectedIndex > -1)
            {
                Modelo modelo = await getInfoModelo(comboModelo.Text);
                tbCapacidadePesoMax.Text = modelo.Capacidade_KG.ToString() + " Kg";
                tbQuantEixos.Text = modelo.Eixo_modelo.ToString();
                tbPesoVeiculo.Text = modelo.Massa_modelo.ToString() + " Kg";

            }
        }
    }
}
