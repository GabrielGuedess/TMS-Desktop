using Interface.ControlValidationAuxiliary;
using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
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
                if (value != null)
                {
                    searchPlaca.Text = value["Placa"].ToString();
                    mkPlaca.Text = value["Placa"].ToString();
                    comboMarca.Text = value["Nome_marca"].ToString();
                    comboTipoVeiculo.Text = value["Descricao"].ToString();
                    comboModelo.Text = value["Nome"].ToString();
                    mkAnoFabricacao.Text = value["Ano_fabricacao"].ToString();
                    tbCor.Text = value["Cor"].ToString();
                    mkRenavam.Text = value["Cod_RENAVAM"].ToString();
                    mkRNTRC.Text = value["Cod_RNTRC"].ToString();
                    mkVencimentoRNTRC.Text = value["Vencimento_RNTRC"].ToString();
                    tbCIOT.Text = value["Cod_CIOT"].ToString();
                    tbPesoVeiculo.Text = value["Massa_modelo"].ToString();
                    tbQuantEixo.Text = value["Eixo_modelo"].ToString();
                    comboPossuiEixo.Text = value["Possui_carroceria"].ToString();
                    comboTipoCarroceria.Text = value["Descricao_carroceira"].ToString();
                    tbQuantEixo.Text = value["Descricao_carroceira"].ToString();
                    comboTipoCarroceria.Text = value["Eixo_carroceria"].ToString();
                    tbPesoCarroceria.Text = value["Massa_carroceria"].ToString();
                    tbCapacidadeVolumetrica.Text = value["Capacidade_volumetrica"].ToString();
                    tbCapacidadePeso.Text = value["Capacidade_KG"].ToString();
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
            utils.expansivePanels(10, subpanelPlaca, panelAno, panelRNTRC);
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
            List<string> notValidar = new();
            notValidar.Add(tableCarroceria.Name);
            try
            {
                if (Type.Contains("Cadastro") && Validation.Validar(tableVeiculo, notValidar) == true)
                {
                    TMSContext db = new();
                    int idMarca = db.Marca.First(a => a.Nome_marca == comboMarca.Text).ID_marca;
                    int idModelo = db.Modelo.First(a => a.Nome == comboModelo.Text).ID_modelo;
                    TipoVeiculo tipoVeiculo = db.TipoVeiculo.First(a => a.Descricao == comboTipoVeiculo.Text);

                    int lastID = 0;
                    if (db.Veiculo.Count() > 1)
                    {
                        lastID = db.Veiculo.Max(a => a.ID_veiculo) + 1;
                    }

                    Veiculo veiculo = new();
                    veiculo.ID_for_marca = idMarca;
                    veiculo.ID_veiculo = lastID;
                    veiculo.ID_for_modelo = idModelo;
                    veiculo.ID_for_tipo_veiculo = tipoVeiculo.ID_tipo_veiculo;
                    if (tipoVeiculo.Possui_carroceria == 1)
                    {
                        if (Validation.Validar(tableCarroceria))
                        {
                            Carroceria carroceriaVeiculo = db.Carroceria.First(a => a.Descricao_carroceira == comboTipoCarroceria.Text);
                            veiculo.ID_for_carroceria.Add(carroceriaVeiculo);
                        }
                        else
                        {
                            return;
                        }
                    }

                    veiculo.Placa = mkPlaca.Text;
                    veiculo.Ano_fabricacao = Int16.Parse(mkAnoFabricacao.Text);
                    veiculo.Cor = tbCor.Text;
                    veiculo.Cod_RENAVAM = mkRenavam.Text;
                    veiculo.Cod_RNTRC = mkRNTRC.Text;
                    veiculo.Vencimento_RNTRC = mkVencimentoRNTRC.convertDateOnly();
                    veiculo.Cod_CIOT = tbCIOT.Text;

                    db.Veiculo.Add(veiculo);


                    db.SaveChanges();
                    limpar.CleanControl(contentVeiculos);
                    limpar.CleanControl(searchPanel);

                }

                if (Type.Contains("Update") && Validation.Validar(tableVeiculo, notValidar))
                {
                    TMSContext db = new();
                    Veiculo veiculoUpdate = db.Veiculo.Include(a => a.ID_for_carroceria).
                        FirstOrDefault(a => a.Placa == mkPlaca.Text);

                    veiculoUpdate.Placa = mkPlaca.Text;
                    veiculoUpdate.ID_for_marca = db.Marca.First(a => a.Nome_marca == comboMarca.Text).ID_marca;
                    veiculoUpdate.ID_for_modelo = getInfoModelo(comboModelo.Text).Result.ID_modelo;
                    veiculoUpdate.ID_for_tipo_veiculo = db.TipoVeiculo.FirstOrDefault(a => a.Descricao == comboTipoVeiculo.Text).ID_tipo_veiculo;
                    veiculoUpdate.Ano_fabricacao = Int16.Parse(mkAnoFabricacao.Text);
                    veiculoUpdate.Cor = tbCor.Text;
                    veiculoUpdate.Cod_RENAVAM = mkRenavam.Text;
                    veiculoUpdate.Cod_RNTRC = mkRNTRC.Text;
                    veiculoUpdate.Vencimento_RNTRC = mkVencimentoRNTRC.convertDateOnly();
                    veiculoUpdate.Cod_CIOT = tbCIOT.Text;

                    if (comboPossuiEixo.Text == "Sim")
                    {
                        bool validou = Validation.Validar(tableCarroceria);
                        if (validou == true)
                        {
                            if (veiculoUpdate.ID_for_carroceria.Count > 0)
                            {
                                Carroceria carroceria = getInfoCarroceria(comboTipoCarroceria.Text).Result;
                                veiculoUpdate.ID_for_carroceria.FirstOrDefault().ID_carroceria = carroceria.ID_carroceria;
                                veiculoUpdate.ID_for_carroceria.FirstOrDefault().Descricao_carroceira = carroceria.Descricao_carroceira;
                                veiculoUpdate.ID_for_carroceria.FirstOrDefault().Eixo_carroceria = carroceria.Eixo_carroceria;
                                veiculoUpdate.ID_for_carroceria.FirstOrDefault().Massa_carroceria = carroceria.Massa_carroceria;
                                veiculoUpdate.ID_for_carroceria.FirstOrDefault().Capacidade_volumetrica = carroceria.Massa_carroceria;
                            }
                            else
                            {
                                veiculoUpdate.ID_for_carroceria.Add(getInfoCarroceria(comboTipoCarroceria.Text).Result);
                            }
                        }
                    }
                    db.SaveChanges();
                    limpar.CleanControl(contentVeiculos);
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

            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }

        }

        private async void buscarPlaca_Click(object sender, EventArgs e)
        {
            if (searchPlaca.MaskCompleted)
            {
                TMSContext db = new();
                Veiculo veiculo = db.Veiculo.Include(a => a.ID_for_marcaNavigation)
                    .Include(a => a.ID_for_tipo_veiculoNavigation).
                    Include(a => a.ID_for_modeloNavigation).Include(a => a.ID_for_carroceria).FirstOrDefault(a => a.Placa == searchPlaca.Text);



                if (veiculo == null)
                {
                    MessageBox.Show("Veiculo não encontrado");
                    return;
                }
                mkPlaca.Text = veiculo.Placa;
                comboMarca.Text = veiculo.ID_for_marcaNavigation.Nome_marca;
                comboTipoVeiculo.Text = veiculo.ID_for_tipo_veiculoNavigation.Descricao;
                mkAnoFabricacao.Text = veiculo.Ano_fabricacao.ToString();
                tbCor.Text = veiculo.Cor;
                mkRenavam.Text = veiculo.Cod_RENAVAM;
                mkRNTRC.Text = veiculo.Cod_RNTRC;
                mkVencimentoRNTRC.Text = veiculo.Vencimento_RNTRC.ToString();
                tbCIOT.Text = veiculo.Cod_CIOT;
                tbPesoVeiculo.Text = veiculo.ID_for_modeloNavigation.Massa_modelo.ToString();
                tbQuantEixo.Text = veiculo.ID_for_modeloNavigation.Eixo_modelo.ToString();
                tbCapacidadePeso.Text = veiculo.ID_for_modeloNavigation.Capacidade_KG.ToString();


                if (veiculo.ID_for_tipo_veiculoNavigation.Possui_carroceria == 1)
                {
                    comboPossuiEixo.SelectedIndex = 0;
                    List<string> listaNomesCarrocerias = new List<string>();
                    var tipoVeiculos = db.TipoVeiculo.Include(a => a.ID_for_carroceria)
                        .ToList();
                    foreach (var item in tipoVeiculos)
                    {
                        if (item.Descricao == comboTipoVeiculo.Text)
                            foreach (var tiposCarroceria in item.ID_for_carroceria)
                            {
                                listaNomesCarrocerias.Add(tiposCarroceria.Descricao_carroceira);
                                if (tiposCarroceria.Descricao_carroceira == veiculo.ID_for_tipo_veiculoNavigation.Descricao)
                                    comboTipoCarroceria.Items.Add(tiposCarroceria);
                            }
                    }
                    comboTipoCarroceria.Text = veiculo.ID_for_tipo_veiculoNavigation.Descricao;
                    tbQuantEixoCarroceria.Text = veiculo.ID_for_carroceria.First().Eixo_carroceria.ToString();
                    tbPesoCarroceria.Text = veiculo.ID_for_carroceria.First().Massa_carroceria.ToString();
                    tbCapacidadeVolumetrica.Text = veiculo.ID_for_carroceria.First().Capacidade_volumetrica.ToString();
                    tbCapacidadePeso.Text = veiculo.ID_for_modeloNavigation.Capacidade_KG.ToString();

                }
                else
                    comboPossuiEixo.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            searchPlaca.Focus();
        }

        private void maskPlaca_TextChanged(object sender, EventArgs e)
        {
            mkPlaca.Text = searchPlaca.Text;

            utils.feedbackColorInput(searchPlaca, typeData);
        }


        async private void CadastroVeiculos_Enter(object sender, EventArgs e)
        {
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

        async private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateModelosAndCarroceria();
        }



        async private void comboModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Modelo modelo = await getInfoModelo(comboModelo.Text);
            if (modelo == null)
            {
                return;
            }
            tbQuantEixo.Text = modelo.Eixo_modelo.ToString();
            tbPesoVeiculo.Text = modelo.Massa_modelo.ToString();
            tbCapacidadePeso.Text = modelo.Capacidade_KG.ToString();
        }

        private void comboPossuiEixo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPossuiEixo.SelectedIndex == 1)
            {
                enableCamposCarroceria(false);
            }
            else
            {
                enableCamposCarroceria(true);
            }
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
                List<Modelo> modelos = await db.Modelo.Where(a => a.ID_for_tipo_veiculo == tipoVeiculo.ID_tipo_veiculo && a.ID_for_marcaNavigation.Nome_marca == comboMarca.Text).ToListAsync();
                comboModelo.Items.Clear();
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
                    foreach (var item in tipoVeiculo.ID_for_carroceria.ToList())
                    {
                        comboTipoCarroceria.Items.Add(item.Descricao_carroceira);
                    }

                }
            }


            comboTipoCarroceria.SelectedIndex = -1;
            if (tipoVeiculo.Possui_carroceria == 0)
            {
                comboPossuiEixo.SelectedIndex = 1;
                enableCamposCarroceria(false);
                comboPossuiEixo.Enabled = false;
            }
            else
            {
                enableCamposCarroceria(true);
                comboPossuiEixo.SelectedIndex = 0;
            }
        }

        private void enableCamposCarroceria(bool action)
        {
            if (action == false)
            {
                comboPossuiEixo.Text = "Não";
                comboTipoCarroceria.Enabled = false;
            }
            else
            {
                comboPossuiEixo.Enabled = true;
                comboTipoCarroceria.Enabled = true;
            }
        }



        async private void comboTipoCarroceria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Carroceria carroceria = await getInfoCarroceria(comboTipoCarroceria.Text);
            if (carroceria != null)
            {
                tbQuantEixoCarroceria.Text = carroceria.Eixo_carroceria.ToString();
                tbPesoCarroceria.Text = carroceria.Massa_carroceria.ToString();
                tbCapacidadeVolumetrica.Text = carroceria.Capacidade_volumetrica.ToString();

            }
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




        async private void comboTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UpdateModelosAndCarroceria();
        }


    }
}
