using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroVeiculos : UserControl
    {
        readonly Utilidades utils = new();

        LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                cadastrarVeiculo.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentVeiculos.Location = new Point(0, 0);

                    mkPlaca.ReadOnly = false;
                    mkPlaca.Cursor = Cursors.IBeam;
                    buscarPlaca.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentVeiculos.Location = new Point(0, 62);

                    mkPlaca.ReadOnly = true;
                    mkPlaca.Cursor = Cursors.No;
                    buscarPlaca.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                maskPlaca.Text = value["Placa"].ToString();

                if (value != null)
                {
                    mkPlaca.Text = value["Placa"].ToString();
                    tbMarca.Text = value["Marca"].ToString();
                    tbModelo.Text = value["Modelo"].ToString();
                    comboTipoVeiculo.Text = value["TipoVeiculo"].ToString();
                    comboTipoCarroceria.Text = value["TipoCarroceria"].ToString();
                    tbEixo.Text = value["QuantidadeEixo"].ToString();
                    mkAnoFabricacao.Text = value["AnoFabricacao"].ToString();
                    tbCor.Text = value["Cor"].ToString();
                    comboUF.Text = value["UF"].ToString();
                    comboCidade.Text = value["CIDADE"].ToString();
                    tbCapacidadeKG.Text = value["PesoCapacidade"].ToString();
                    tbTara.Text = value["PesoTara"].ToString();
                    tbCapacidadeM3.Text = value["CapacidadeM3"].ToString();
                    mkRNTRC.Text = value["RNTRC"].ToString();

                    mkRenavam.Text = value["Renavam"].ToString();
                    tbCIOT.Text = value["CIOT"].ToString();
                    //tbMotorista.Text = value["VENCIMENTO_CNH"].ToString();
                    mkCPF.Text = value["CPF"].ToString();
                    tbValorPagoKM.Text = value["ValorKM"].ToString();
                    //tbPgot.Text = value["MOPP"].ToString();
                    tbValorPagoHora.Text = value["ValorHora"].ToString();
                    tbAdiconalCarroceria.Text = value["AdicionaisCarroceria"].ToString();
                    tbAdicionalMotorista.Text = value["AdicionaisVeiculo"].ToString();
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
        private void buscarPlaca_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarPlaca);
        }

        private void cadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && validar())
            {
                string SQL = "Insert Into tbVeiculos (Placa, Marca, Modelo, TipoVeiculo, TipoCarroceria, QuantidadeEixo, AnoFabricacao," +
                    " Cor, PesoCapacidade, PesoTara, CapacidadeM3, Renavam, RNTRC, CIOT, Nome, CPF, UF, Cidade, ValorHora, ValorKM, FranquiaKm," +
                    " AdicionaisCarroceria, AdicionaisVeiculo) Values";
                SQL += "('" + mkPlaca.Text + "' , '" + tbMarca.Text + "' ," +
                    " '" + tbModelo.Text + "','" + comboTipoVeiculo.Text + "','" + comboTipoCarroceria.Text + "'" +
                    ", '" + tbEixo.Text + "','" + mkAnoFabricacao.Text + "', '" + tbCor.Text + "','" + tbCapacidadeKG.Text + "'," +
                    " '" + tbTara.Text + "','" + tbCapacidadeM3.Text + "','" + mkRenavam.Text + "','"
                    + mkRNTRC.Text + "','" + tbCIOT.Text + "','" + tbMotorista.Text + "','" + mkCPF.Text + "'," +
                    "'" + comboUF.Text + "','" + comboCidade.Text + "','" + tbValorPagoHora.Text + "','" + tbValorPagoKM.Text + "" +
                    "','" + tbPgot.Text + "','" + tbAdiconalCarroceria.Text + "','" + tbAdicionalMotorista.Text + "')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentVeiculos);
                limpar.CleanControl(searchPanel);
            }

            if (Type.Contains("Update") && validar())
            {
                string SQLUp = $"UPDATE tbVeiculos SET " +
                $"Marca= '{tbMarca.Text}', " +
                $"Modelo= '{tbModelo.Text}', " +
                $"TipoVeiculo= '{comboTipoVeiculo.Text}', " +
                $"TipoCarroceria= '{comboTipoCarroceria.Text}', " +
                $"QuantidadeEixo= '{tbEixo.Text}', " +
                $"AnoFabricacao= '{mkAnoFabricacao.Text}', " +
                $"Cor= '{tbCor.Text}', " +
                $"UF= '{comboUF.Text}', " +
                $"CIDADE= '{comboCidade.Text}', " +
                $"PesoCapacidade= '{tbCapacidadeKG.Text}', " +
                $"PesoTara= '{tbTara.Text}', " +
                $"CapacidadeM3= '{tbCapacidadeM3.Text}', " +
                $"RNTRC= '{mkRNTRC.Text}', " +

                $"Renavam= '{mkRenavam.Text}', " +
                $"CIOT= '{tbCIOT.Text}', " +
                //$"Motorista= '{tbMotorista.Text}', " +
                $"CPF= '{mkCPF.Text}', " +
                $"ValorKM= '{tbValorPagoKM.Text}', " +
                //$"Pgot= '{tbPgot.Text}', " +
                $"ValorHora= '{tbValorPagoHora.Text}', " +
                $"AdicionaisCarroceria= '{tbAdiconalCarroceria.Text}', " +
                $"AdicionaisVeiculo= '{tbAdicionalMotorista.Text}' " +
                $"WHERE Placa = '{maskPlaca.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentVeiculos);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarPlaca_Click(object sender, EventArgs e)
        {
            if (maskPlaca.MaskCompleted)
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM tbVeiculos WHERE Placa = '{maskPlaca.Text}'", contentVeiculos)!;

                if (dados != null)
                {
                    maskPlaca.Text = dados["Placa"].ToString();

                    tbMarca.Text = dados["Marca"].ToString();
                    tbModelo.Text = dados["Modelo"].ToString();
                    comboTipoVeiculo.Text = dados["TipoVeiculo"].ToString();
                    comboTipoCarroceria.Text = dados["TipoCarroceria"].ToString();
                    tbEixo.Text = dados["QuantidadeEixo"].ToString();
                    mkAnoFabricacao.Text = dados["AnoFabricacao"].ToString();
                    tbCor.Text = dados["Cor"].ToString();
                    comboUF.Text = dados["UF"].ToString();
                    comboCidade.Text = dados["CIDADE"].ToString();
                    tbCapacidadeKG.Text = dados["PesoCapacidade"].ToString();
                    tbTara.Text = dados["PesoTara"].ToString();
                    tbCapacidadeM3.Text = dados["CapacidadeM3"].ToString();
                    mkRNTRC.Text = dados["RNTRC"].ToString();

                    mkRenavam.Text = dados["Renavam"].ToString();
                    tbCIOT.Text = dados["CIOT"].ToString();
                    //tbMotorista.Text = dados["VENCIMENTO_CNH"].ToString();
                    mkCPF.Text = dados["CPF"].ToString();
                    tbValorPagoKM.Text = dados["ValorKM"].ToString();
                    //tbPgot.Text = dados["MOPP"].ToString();
                    tbValorPagoHora.Text = dados["ValorHora"].ToString();
                    tbAdiconalCarroceria.Text = dados["AdicionaisCarroceria"].ToString();
                    tbAdicionalMotorista.Text = dados["AdicionaisVeiculo"].ToString();
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
            maskPlaca.Focus();
        }

        private void maskPlaca_TextChanged(object sender, EventArgs e)
        {
            mkPlaca.Text = maskPlaca.Text;

            utils.feedbackColorInput(maskPlaca, typeData);
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

            if (mkAnoFabricacao.MaskCompleted == false)
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
    }
}
