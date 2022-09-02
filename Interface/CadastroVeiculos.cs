using Interface.Properties;
using System.Data.Entity.Infrastructure;

namespace Interface
{
    public partial class CadastroVeiculos : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                cadastrarVeiculo.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentVeiculos.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentVeiculos.Location = new Point(0, 62);
                }
            }
        }

        public CadastroVeiculos()
        {
            InitializeComponent();
        }

        private void CadastroVeiculos_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelPlaca, panelAno, panelCapacidade, panelRNTRC, panelMotorista, panelValor);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarVeiculo_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarVeiculo);
        }
        private bool validar()
        {
            if (mkPlaca.MaskCompleted == false)
            {
                MessageBox.Show("O campo Placa é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkPlaca.Focus();
                return false;
            }

            if (comboUF.Text == "")
            {
                MessageBox.Show("O campo UF é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboUF.Focus();
                return false;
            }

            if (comboCidade.Text == "")
            {
                MessageBox.Show("O campo Cidade é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCidade.Focus();
                return false;
            }

            if (tbMarca.Text == "")
            {
                MessageBox.Show("O campo Marca é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMarca.Focus();
                return false;
            }

            if (tbModelo.Text == "")
            {
                MessageBox.Show("O campo Modelo é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbModelo.Focus();
                return false;
            }

            if (mkAnoFabricacao.MaskCompleted==false)
            {
                MessageBox.Show("O campo Ano de Fabricação é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkAnoFabricacao.Focus();
                return false;
            }


            if (mkRenavam.MaskCompleted == false)
            {
                MessageBox.Show("O campo Código Renavam é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkRenavam.Focus();
                return false;
            }

            if (mkRNTRC.MaskCompleted == false)
            {
                MessageBox.Show("O campo RNTRC é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkRNTRC.Focus();
                return false;
            }

            if (tbCapacidadeKG.Text == string.Empty)
            {
                MessageBox.Show("O campo Capacidade(Kg) é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCapacidadeKG.Focus();
                return false;
            }

            if (tbCapacidadeM3.Text == string.Empty)
            {
                MessageBox.Show("O campo Capacidade(m³) é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCapacidadeM3.Focus();
                return false;
            }

            if (tbEixo.Text == string.Empty)
            {
                MessageBox.Show("O campo Eixo é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEixo.Focus();
                return false;
            }

            if (tbMotorista.Text == string.Empty)
            {
                MessageBox.Show("O campo Motorista é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMotorista.Focus();
                return false;
            }

            if (mkCPF.MaskCompleted == false)
            {
                MessageBox.Show("Necessário preencher o campo CPF corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
                return false;
            }

            if (tbCIOT.Text.Length > 1 && tbCIOT.TextLength < 16)
            {
                MessageBox.Show("Necessário preencher o campo CIOT corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCIOT.Focus();
                return false;
            }
            if (tbValorPagoHora.Text == string.Empty)
            {
                MessageBox.Show("Necessário preencher o campo Valor pago por hora!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbValorPagoHora.Focus();
                return false;
            }
            if (tbValorPagoKM.Text == string.Empty)
            {
                MessageBox.Show("Necessário preencher o campo Valor pago por Km!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbValorPagoKM.Focus();
                return false;
            }
            if (tbCor.Text == string.Empty)
            {
                MessageBox.Show("Necessário preencher o campo Cor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCor.Focus();
                return false;
            }
            if (tbTara.Text == string.Empty)
            {
                MessageBox.Show("Necessário preencher o campo Tara(Kg)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTara.Focus();
                return false;
            }
            if (comboTipoVeiculo.Text == string.Empty)
            {
                MessageBox.Show("Necessário preencher o campo Tipo Veículo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTara.Focus();
                return false;
            }
            if (comboTipoCarroceria.Text == string.Empty)
            {
                MessageBox.Show("Necessário preencher o campo Tipo Carroceria!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboTipoCarroceria.Focus();
                return false;
            }

            return true;
        }

        private void cadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            string SQL = "Insert Into tbVeiculos (Placa, Marca, Modelo, TipoVeiculo, TipoCarroceria, QuantidadeEixo, AnoFabricacao," +
                " Cor, PesoCapacidade, PesoTara, CapacidadeM3, Renavam, RNTRC, CIOT, Nome, CPF, UF, Cidade, ValorHora, ValorKM, FranquiaKm," +
                " AdicionaisCarroceria, AdicionaisVeiculo) Values";
            SQL += "('" + mkPlaca.Text + "' , '" + tbMarca.Text + "' ," +
                " '" + tbModelo.Text + "','" + comboTipoVeiculo.Text + "','" + comboTipoCarroceria.Text + "'" +
                ", '" + tbEixo.Text + "','" + mkAnoFabricacao.Text + "', '" + tbCor.Text + "','" + tbCapacidadeKG.Text + "'," +
                " '" + tbTara.Text + "','" + tbCapacidadeM3.Text + "','" + mkRenavam.Text + "','"
                + mkRNTRC.Text + "','" + tbCIOT.Text + "','" + tbMotorista.Text + "','" + mkCPF.Text + "'," +
                "'" + comboUF.Text + "','" + comboCidade.Text + "','" + tbValorPagoHora.Text + "','" + tbValorPagoKM.Text + "" +
                "','" + tbPgot.Text + "','" + tbAdiconalCarroceria.Text+ "','" + tbAdicionalMotorista.Text + "')";
            ConnectDB connectDB = new ConnectDB();
            connectDB.cadastrar(SQL);
            LimparFormularios limpar = new();
            limpar.CleanControl(contentVeiculos);
        }
    }
}
