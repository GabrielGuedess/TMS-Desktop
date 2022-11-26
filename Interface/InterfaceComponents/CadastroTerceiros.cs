using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Properties;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;
using System.Linq;

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
                    
                   /* mkCPF.Text = value["CPF"].ToString();
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
                        dateFimAtividade.Text = value["DataFimAtividades"].ToString();*/
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

                    TMSContext db = new();
                    MotoristaTerceiro terceiro = new();
                    int lastID=0;
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
                    terceiro.Disponibilidade = "ad";

                    CelularMotoristaTerceiro celular = new CelularMotoristaTerceiro { Celular = mkCelular.Text,
                        ID_for_motorista = lastID };

                    TelefoneMotoristaTerceiro telefone = new TelefoneMotoristaTerceiro { Telefone = mkTelefone.Text, 
                        ID_for_motorista = lastID };


                    ContratoMotoristaTerceiro contrato = new ContratoMotoristaTerceiro
                    {
                        ID_for_motorista = lastID,
                        Tipo_contrato = comboTipoContrato.Text,
                        Inicio_contrato = dateInicioAtividade.convertDateOnly(),
                        Situacao_contrato = comboSituacaoContrato.Text,
                        Veiculo_proprio = comboVeiculoProprio.Text,
                    };

                    if(dateFimAtividade.Text.Length > 0)
                    {
                        contrato.Fim_contrato = dateFimAtividade.convertDateOnly();
                    }

                    VeiculoTerceiro veiculo = new VeiculoTerceiro {
                        //possibilidade de revisão
                        ID_for_motorista = lastID,
                        ID_veiculo_terceiro = lastID,
                        Ano_fabricao = short.Parse(mkAno.Text),
                        Capacidade_KG = tbCapacidadePesoMax.returnValue(),
                        Capacidade_volumetrican = tbCapacidadeVolumetrica.returnValue(),
                        Carroceria = comboTipoCarroceria.Text,
                        Cod_CIOT = mkCodigoCIOT.Text,
                        Cod_RENAVAM = mkRenavam.Text,
                        Cod_RNTRC = mkRNTRC.Text,
                        Eixo_carroceria = int.Parse(tbQuantiEixosCarroceria.Text),
                        Eixo_modelo = int.Parse(tbQuantEixos.Text),
                        Marca = tbMarca.Text,
                        Massa_carroceria = tbPesoCarroceria.returnValue(),
                        Massa_modelo = tbPesoVeiculo.returnValue(),
                        Placa = tbPlaca.Text,
                        Modelo = tbModelo.Text,
                        Vencimento_RNTRC = dateVencimentoRENTRC.convertDateOnly()
                        
                    };

                    EmailMotoristaTerceiro email = new EmailMotoristaTerceiro
                    {
                        Email = tbEmail.Text,
                        ID_for_motorista = lastID
                    };
                    terceiro.CelularMotoristaTerceiro.Add(celular);
                    terceiro.TelefoneMotoristaTerceiro.Add(telefone);
                    terceiro.ContratoMotoristaTerceiro.Add(contrato);
                    terceiro.EmailMotoristaTerceiro.Add(email);
                    terceiro.VeiculoTerceiro.Add(veiculo);

                    db.MotoristaTerceiro.Add(terceiro);
                    db.SaveChanges();



                    /*limpar.CleanControl(contentTerceiros);
                    limpar.CleanControl(searchPanel);*/
                }

                if (Type.Contains("Update") && Validation.Validar(contentTerceiros, notValidar) && Validation.validarTelefone(mkTelefone))
                {
                   /* string SQLUp = $"UPDATE tbTerceiros SET " +
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
                    limpar.CleanControl(searchPanel);*/
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
                TMSContext db = new TMSContext();

                //esse AsNoTracking faz a consulta ser mais rapida 
                //porém só pode user usado para casos em que só vai 
                //ler os dados e não vai manipulalos
                var terceiro = db.MotoristaTerceiro.AsNoTracking().
                    Include(a=> a.CelularMotoristaTerceiro).
                    Include(a=>a.ContratoMotoristaTerceiro).
                    Include(a=>a.TelefoneMotoristaTerceiro).
                    Include(a=> a.EmailMotoristaTerceiro).
                    Include(a=>a.VeiculoTerceiro)
                    .FirstOrDefault(a=>a.CPF == maskCpf.Text);

               
                mkCelular.Text = terceiro.CelularMotoristaTerceiro.First().Celular;
                

                tbNome.Text = terceiro.Nome;
                tbRg.Text = terceiro.RG;
                dateNascimento.Text = terceiro.Data_nascimento.ToString();
                comboGenero.Text = terceiro.Genero;
                mkCelular.Text = terceiro.CelularMotoristaTerceiro.First().Celular;
                mkTelefone.Text = terceiro.TelefoneMotoristaTerceiro.First().Telefone.ToString();
                //tbEmail.Text = terceiro.Emailmotoristaterceiro.First().Email;
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
                tbPlaca.Text = terceiro.VeiculoTerceiro.First().Placa;
                mkAno.Text = terceiro.VeiculoTerceiro.First().Ano_fabricao.ToString();
                mkRNTRC.Text = terceiro.VeiculoTerceiro.First().Cod_RNTRC;
                dateVencimentoRENTRC.Text = terceiro.VeiculoTerceiro.First().Vencimento_RNTRC.ToString();
                comboTipoVeiculo.Text = terceiro.VeiculoTerceiro.First().Carroceria;
                mkRenavam.Text = terceiro.VeiculoTerceiro.First().Cod_RENAVAM;
                mkCodigoCIOT.Text = terceiro.VeiculoTerceiro.First().Cod_CIOT;
                tbMarca.Text = terceiro.VeiculoTerceiro.First().Marca;
                tbModelo.Text = terceiro.VeiculoTerceiro.First().Modelo;
                comboTipoCarroceria.Text = terceiro.VeiculoTerceiro.First().Carroceria;
                tbPesoVeiculo.Text =terceiro.VeiculoTerceiro.First().Massa_modelo.ToString() +" Kg";
                tbQuantEixos.Text = terceiro.VeiculoTerceiro.First().Eixo_modelo.ToString();
                tbPesoCarroceria.Text = terceiro.VeiculoTerceiro.First().Massa_carroceria.ToString() +" Kg";
                tbQuantiEixosCarroceria.Text = terceiro.VeiculoTerceiro.First().Eixo_carroceria.ToString();
                tbCapacidadeVolumetrica.Text = terceiro.VeiculoTerceiro.First().Capacidade_volumetrican.ToString() + " m³";
                tbCapacidadePesoMax.Text = terceiro.VeiculoTerceiro.First().Capacidade_KG.ToString() + " Kg";
                comboTipoContrato.Text = terceiro.ContratoMotoristaTerceiro.First().Tipo_contrato;
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
    }
}
