using Interface.ControlValidationAuxiliary;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;

namespace Interface.InterfaceComponents
{
    public partial class TelaProcessoManutencao : UserControl
    {
        readonly Utilidades utils = new();

        private string Type = "";

        LimparFormularios limpar = new();

        public string TypeControl
        {
            set
            {

                Type = value;

                cadastrarManutencao.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchManutencao.Visible = false;
                    contentManutencao.Location = new Point(0, 0);


                    buscarManutencao.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchManutencao.Visible = true;
                    contentManutencao.Location = new Point(0, 62);

                    buscarManutencao.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                if (value != null)
                {
                    searchManutencao.Text = value["Placa"].ToString();
                    comboVeiculo.Text = value["Placa"].ToString();
                    comboTipo.Text = value["Tipo_manutencao"].ToString();
                    comboClassificacao.Text = value["Classificacao"].ToString();
                    comboProcesso.Text = value["Corretivo"].ToString() != string.Empty ? "Corretivo" : "Preventivo";
                    comboEmpresa.Text = value["Nome_fantasia"].ToString();
                    tbValor.Text = value["Valor_reais"].ToString();
                    tbDetalhamento.Text = value["Detalhamento"].ToString();
                    mkDateInicio.Text = value["Data_inicio"].ToString();
                    mkDateFim.Text = value["Data_fim"].ToString();
                }
            }
        }

        public TelaProcessoManutencao()
        {
            InitializeComponent();
        }

        private void cadastrarManutencao_Click(object sender, EventArgs e)
        {
            try
            {
                TMSContext db = new();
                if (Type.Contains("Cadastro") && Validation.Validar(contentManutencao))
                {

                    Manutencao manutencao = new();

                    manutencao.ID_for_processo_manutencao = db.ProcessoManutencao.First(a => a.Descricao == comboProcesso.Text).ID_processo_manutencao;
                    if (comboTipo.SelectedIndex == 0)
                        manutencao.Tipo_manutencao = "c";
                    else if (comboTipo.SelectedIndex == 1)
                        manutencao.Tipo_manutencao = "p";
                    manutencao.Detalhamento = tbDetalhamento.Text;
                    manutencao.Valor_reais = tbValor.returnValue();
                    manutencao.Data_fim = mkDateFim.convertDateOnly();
                    manutencao.Data_inicio = mkDateFim.convertDateOnly();
                    manutencao.ID_for_empresa = db.PessoaJuridica.First(a => a.Nome_fantasia == comboEmpresa.Text).ID_pessoa_juridica;
                    manutencao.ID_for_veiculo = db.Veiculo.First(a => a.Placa == comboVeiculo.Text).ID_veiculo;
                    db.Manutencao.Add(manutencao);
                    db.SaveChanges();

                    limpar.CleanControl(contentManutencao);
                    limpar.CleanControl(searchPanel);
                }
                else if (Type.Contains("Update") && Validation.Validar(contentManutencao))
                {

                    Manutencao manutencao = db.Manutencao.Include(a => a.ID_for_processo_manutencaoNavigation)
                        .Include(a => a.ID_for_empresaNavigation)
                        .Include(a => a.ID_for_veiculoNavigation)
                        .FirstOrDefault(a => a.ID_for_veiculoNavigation.Placa == comboVeiculo.Text);

                    if (manutencao == null)
                    {
                        MessageBox.Show("Erro ao atualizar");
                        return;
                    }
                    else
                    {
                        manutencao.ID_for_processo_manutencao = db.ProcessoManutencao.First(a => a.Descricao == comboProcesso.Text).ID_processo_manutencao;
                        if (comboTipo.SelectedIndex == 0)
                            manutencao.Tipo_manutencao = "C";
                        else if (comboTipo.SelectedIndex == 1)
                            manutencao.Tipo_manutencao = "P";
                        manutencao.Detalhamento = tbDetalhamento.Text;
                        manutencao.Valor_reais = tbValor.returnValue();
                        manutencao.Data_fim = mkDateFim.convertDateOnly();
                        manutencao.Data_inicio = mkDateFim.convertDateOnly();
                        manutencao.ID_for_empresa = db.PessoaJuridica.First(a => a.Nome_fantasia == comboEmpresa.Text).ID_pessoa_juridica;
                        manutencao.ID_for_veiculo = db.Veiculo.First(a => a.Placa == comboVeiculo.Text).ID_veiculo;
                        db.SaveChanges();
                        limpar.CleanControl(contentManutencao);
                        limpar.CleanControl(searchPanel);
                    }
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

        }

        private void buscarManutencao_Click(object sender, EventArgs e)
        {
            TMSContext db = new();
            Manutencao manutencao = db.Manutencao.Include(a => a.ID_for_processo_manutencaoNavigation)
                    .Include(a => a.ID_for_empresaNavigation)
                    .Include(a => a.ID_for_veiculoNavigation)
                    .FirstOrDefault(a => a.ID_for_veiculoNavigation.Placa== searchManutencao.Text);

            if (manutencao == null)
            {
                MessageBox.Show("Erro ao Buscar");
                return;
            }

            comboVeiculo.Text = manutencao.ID_for_veiculoNavigation.Placa;
            if (manutencao.Tipo_manutencao == "C")
                comboTipo.SelectedIndex = 0;
            else
                comboTipo.SelectedIndex = 1;
            comboClassificacao.Text =  manutencao.ID_for_processo_manutencaoNavigation.Classificacao;
            comboProcesso.Items.Clear();
            comboProcesso.Items.Add(manutencao.ID_for_processo_manutencaoNavigation.Descricao);
            comboProcesso.SelectedIndex = 0;
            comboEmpresa.Text = manutencao.ID_for_empresaNavigation.Nome_fantasia;
            tbValor.Text = manutencao.Valor_reais.ToString();
            tbDetalhamento.Text = manutencao.Detalhamento;
            mkDateInicio.Text = manutencao.Data_inicio.ToString();
            mkDateFim.Text = manutencao.Data_fim.ToString();


        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void buscarManutencao_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarManutencao);
        }

        private void cadastrarManutencao_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarManutencao);
        }



        async private void ProcessoManutencao_Enter(object sender, EventArgs e)
        {
            comboVeiculo.Items.Clear();
            TMSContext db = new TMSContext();
            List<Veiculo> veiculos = await db.Veiculo.ToListAsync();
            foreach (var item in veiculos)
            {
                comboVeiculo.Items.Add(item.Placa);
            }

            comboEmpresa.Items.Clear();
            List<PessoaJuridica> empresas = await db.PessoaJuridica.ToListAsync();
            foreach (var item in empresas)
            {
                comboEmpresa.Items.Add(item.Nome_fantasia);
            }

            List<ProcessoManutencao> processos = db.ProcessoManutencao.ToList();
            foreach (var item in processos.DistinctBy(a => a.Classificacao))
                comboClassificacao.Items.Add(item.Classificacao);
        }

        async private void comboClassificacao_Leave(object sender, EventArgs e)
        {
            TMSContext db = new TMSContext();
            if (comboTipo.SelectedIndex == 0)
            {
                comboProcesso.Items.Clear();
                List<ProcessoManutencao> processos = await db.ProcessoManutencao.ToListAsync();
                foreach (var item in processos)
                {
                    if (item.Corretivo == 1 && item.Classificacao == comboClassificacao.Text)
                        comboProcesso.Items.Add(item.Descricao);
                }
                comboProcesso.MaxDropDownItems = 5;
            }
            else if (comboTipo.SelectedIndex == 1)
            {
                comboProcesso.Items.Clear();
                List<ProcessoManutencao> processos = await db.ProcessoManutencao.ToListAsync();
                foreach (var item in processos)
                {
                    if (item.Preventivo == 1 && item.Classificacao == comboClassificacao.Text)
                        comboProcesso.Items.Add(item.Descricao);
                }
            }
        }
    }
}
