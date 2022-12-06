using Interface.ControlValidationAuxiliary;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;

namespace Interface.InterfaceComponents
{
    public partial class ProcessoManutencao : UserControl
    {
        readonly Utilidades utils = new();

        private string Type = "";
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
        public ProcessoManutencao()
        {
            InitializeComponent();
        }

        private void cadastrarManutencao_Click(object sender, EventArgs e)
        {
            TMSContext db = new();
            if (Type.Contains("Cadastro") && Validation.Validar(contentManutencao))
            {

                Manutencao manutencao = new();

                manutencao.ID_for_processo_manutencao = db.ProcessoManutencao.First(a => a.Descricao == comboVeiculo.Text).ID_processo_manutencao;
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

            }
            else if (Type.Contains("Update") && Validation.Validar(contentManutencao))
            {

                Manutencao manutencao = db.Manutencao.Include(a => a.ID_for_processo_manutencao)
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
                    manutencao.ID_for_processo_manutencao = db.ProcessoManutencao.First(a => a.Descricao == comboVeiculo.Text).ID_processo_manutencao;
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
                }
            }
        }

        private void buscarManutencao_Click(object sender, EventArgs e)
        {
            TMSContext db = new();
            Manutencao manutencao = db.Manutencao.Include(a => a.ID_for_processo_manutencao)
                    .Include(a => a.ID_for_empresaNavigation)
                    .Include(a => a.ID_for_veiculoNavigation)
                    .FirstOrDefault(a => a.ID_for_veiculoNavigation.Placa == comboVeiculo.Text);

            if (manutencao == null)
            {
                MessageBox.Show("Erro ao Buscar");
                return;
            }

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
    }
}
