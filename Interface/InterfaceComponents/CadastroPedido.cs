using Interface.ControlValidationAuxiliary;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Properties;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace Interface.InterfaceComponents
{
    public partial class CadastroPedido : UserControl
    {
        readonly Utilidades utils = new();

        LimparFormularios limpar = new();

        private string Type = "";

        private readonly TMSContext db = new();

        private List<Mercadoria> mercadorias = new List<Mercadoria>();


        public string TypeControl
        {
            get { return Type; }

            set
            {
                Type = value;

                cadastrarPedido.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentPedido.Location = new Point(0, 0);

                    mkPedido.ReadOnly = false;
                    mkPedido.Cursor = Cursors.IBeam;
                    buscarPedido.Visible = false;
                }

                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentPedido.Location = new Point(0, 62);

                    mkPedido.ReadOnly = true;
                    mkPedido.Cursor = Cursors.No;
                    buscarPedido.Visible = true;
                }
            }
        }

        public CadastroPedido()
        {
            InitializeComponent();
        }

        private ClienteFisico GetClienteFisico(string CPF)
        {
            var clienteFisico = db.ClienteFisico.First(a => a.CPF == CPF);
            return clienteFisico;
        }

        private ClienteJuridico GetClienteJuridico(string CNPJ)
        {
            var clienteJuridico = db.ClienteJuridico.FirstOrDefault(a => a.CNPJ == CNPJ);
            return clienteJuridico;
        }

        private void cadastrarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> notValidar = new();
                notValidar.Add(comboMercadoriasAdd.Name);
                notValidar.Add(tbComplemento.Name);
                if (Type.Contains("Cadastro") && Validation.Validar(tableInfoPedido, notValidar))
                {
                    PedidoCliente pedido = new();

                    pedido.ID_pedido = int.Parse(mkPedido.Text);

                    if (comboTipoCliente.SelectedIndex == 0)
                    {
                        pedido.ID_for_cliente = GetClienteFisico(comboCPForCNPJCliente.Text).ID_for_cliente;
                    }
                    else if (comboTipoCliente.SelectedIndex == 1)
                    {
                        pedido.ID_for_cliente = GetClienteJuridico(comboCPForCNPJCliente.Text).ID_for_cliente;
                    }

                    pedido.CEP_destino = mkCEP.Text;
                    pedido.UF_destino = comboUF.Text;
                    pedido.Cidade_destino = comboCidade.Text;
                    pedido.Logradouro_destino = tbLogradouro.Text;
                    pedido.Numero_destino = tbNumCasa.Text;
                    pedido.Bairro_destino = tbBairro.Text;
                    pedido.Complemento_endereco = tbComplemento.Text;

                    if (mercadorias.Count > 0)
                    {
                        foreach (var mercadoria in mercadorias)
                        {
                            pedido.Mercadoria.Add(mercadoria);
                        }
                    }

                    else
                    {
                        MessageBox.Show("É necessário cadastrar ao menos uma mercadoria");
                        return;
                    }

                    db.PedidoCliente.Add(pedido);
                    db.SaveChanges();
                    limpar.CleanControl(contentPedido);
                    mercadorias.Clear();
                }
                else if (Type.Contains("Update") && Validation.Validar(contentPedido))
                {
                    PedidoCliente pedido = db.PedidoCliente.FirstOrDefault(a => a.ID_pedido == int.Parse(mkPedido.Text));

                    if (pedido == null)
                    {
                        MessageBox.Show("Erro no Update");
                        return;
                    }

                    pedido.ID_pedido = int.Parse(mkPedido.Text);

                    if (comboTipoCliente.SelectedIndex == 0)
                    {
                        pedido.ID_for_cliente = GetClienteFisico(comboCPForCNPJCliente.Text).ID_for_cliente;
                    }
                    else if (comboTipoCliente.SelectedIndex == 1)
                    {
                        pedido.ID_for_cliente = GetClienteJuridico(comboCPForCNPJCliente.Text).ID_for_cliente;
                    }

                    pedido.CEP_destino = mkCEP.Text;
                    pedido.UF_destino = comboUF.Text;
                    pedido.Cidade_destino = comboCidade.Text;
                    pedido.Logradouro_destino = tbLogradouro.Text;
                    pedido.Numero_destino = tbNumCasa.Text;
                    pedido.Bairro_destino = tbBairro.Text;
                    pedido.Complemento_endereco = tbComplemento.Text;

                    if (mercadorias.Count > 0)
                    {
                        foreach (var mercadoria in mercadorias)
                        {
                            pedido.Mercadoria.Add(mercadoria);
                        }
                    }

                    else
                    {
                        MessageBox.Show("É necessário cadastrar ao menos uma mercadoria");
                        return;
                    }

                    db.SaveChanges();

                    limpar.CleanControl(contentPedido);
                    mercadorias.Clear();
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

        private void buscarPedido_Click(object sender, EventArgs e)
        {
            PedidoCliente pedido = db.PedidoCliente
                .Include(a=> a.ID_for_clienteNavigation)
                .Include(a => a.ID_for_clienteNavigation.ClienteFisico)
                .Include(a => a.ID_for_clienteNavigation.ClienteJuridico)
                .Include(a=> a.Mercadoria)
                .FirstOrDefault(a => a.ID_pedido == int.Parse(mkSearchPedido.Text));

            if (pedido == null)
            {
                MessageBox.Show("Erro ao buscar");
                return;
            }
            mkPedido.Text = pedido.ID_pedido.ToString();
            if(pedido.ID_for_clienteNavigation.Tipo_cliente == "J")
            {
                comboTipoCliente.SelectedIndex = 1;
                comboCPForCNPJCliente.Text = pedido.ID_for_clienteNavigation.ClienteJuridico.CNPJ;
            }
            else
            {
                comboTipoCliente.SelectedIndex = 0;
                comboCPForCNPJCliente.Text = pedido.ID_for_clienteNavigation.ClienteFisico.CPF;
            }
            mkCEP.Text = pedido.CEP_destino;
            comboUF.Text = pedido.UF_destino;
            comboCidade.Text = pedido.Cidade_destino;
            tbLogradouro.Text = pedido.Logradouro_destino;
            tbNumCasa.Text = pedido.Numero_destino;
            tbBairro.Text = pedido.Bairro_destino;
            tbComplemento.Text = pedido.Complemento_endereco;
            comboMercadoriasAdd.Items.Clear();
            foreach(var item in pedido.Mercadoria)
            {
                comboMercadoriasAdd.Items.Add(item.Descricao);
            }
            mercadorias.Clear();
            mercadorias = pedido.Mercadoria.ToList();
        }

        async private void comboMercadoriasAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMercadoriasAdd.Items.Count > 0)
            {
                Mercadoria mercadoria = mercadorias.FirstOrDefault(a => a.Descricao == comboMercadoriasAdd.Text);
                tbDescricao.Text = mercadoria.Descricao;
                tbValor.Text = "R$" + mercadoria.Valor.ToString();
                tbValor.Text = "R$" + mercadoria.Valor.ToString();
                tbVolume.Text = mercadoria.Volume.ToString();
                tbPeso.Text = mercadoria.Massa.ToString();
  
            }
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void buscarPedido_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarPedido);
        }

        private void cadastrarPedido_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarPedido);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (comboMercadoriasAdd.Items.Count > 0 && comboMercadoriasAdd.SelectedIndex > -1)
            {
                Mercadoria mercadoria = mercadorias.FirstOrDefault(a => a.Descricao == comboMercadoriasAdd.Text);
                if (mercadoria != null)
                {
                    
                    mercadorias.Remove(mercadoria);
                    comboMercadoriasAdd.Items.Remove(comboMercadoriasAdd.SelectedItem);
                    
                    limpar.CleanControl(tableInfoMercadoria);
                }
                else
                    MessageBox.Show("Erro ao deletar Mercadoria");
            }
            else
            {
                MessageBox.Show($"Add ao menos uma mercadoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        async private void comboTipoCliente_TextChanged(object sender, EventArgs e)
        {
            if(comboTipoCliente.SelectedIndex == 0)
            {
                labelNomeTipoCliente.Text = "CPF do Cliente";
                comboCPForCNPJCliente.Items.Clear();
                List<ClienteFisico> listClient = await db.ClienteFisico.ToListAsync();
                foreach(var clienteFisico in listClient)
                {  
                    comboCPForCNPJCliente.Items.Add(clienteFisico.CPF);
                }
            }
            else if( comboTipoCliente.SelectedIndex == 1)
            {
                labelNomeTipoCliente.Text = "CNPF do Cliente";
                comboCPForCNPJCliente.Items.Clear();
                List<ClienteJuridico> listClient = await db.ClienteJuridico.ToListAsync();
                foreach (var clienteJuridico in listClient)
                {
                    comboCPForCNPJCliente.Items.Add(clienteJuridico.CNPJ);
                }
            }
        }

        private void buttonAddMercadoria_Click(object sender, EventArgs e)
        {
            Mercadoria mercadoria = new();
            int lastPedidoID = 0;
            int lastClient = 0;
            if (db.PedidoCliente.Count() > 0)
            {
                lastPedidoID = db.PedidoCliente.Max(id => id.ID_pedido);
            }
            int lastClientID = 0;
            if (comboTipoCliente.SelectedIndex == 0)
            {
                lastClientID = GetClienteFisico(comboCPForCNPJCliente.Text).ID_for_cliente;
            }
            else if(comboTipoCliente.SelectedIndex == 1)
            {
                lastClientID = GetClienteJuridico(comboCPForCNPJCliente.Text).ID_for_cliente;
            }
            else
            {
                MessageBox.Show("Preencha as informaçoes sobre o Pedido Primeiro");
            }

            mercadoria.Descricao = tbDescricao.Text;
            mercadoria.ID_for_cliente = lastClientID;
            mercadoria.ID_for_pedido = lastPedidoID;
            mercadoria.Valor = tbValor.returnValue();
            mercadoria.Volume = tbVolume.returnValue();
            mercadoria.Massa = tbPeso.returnValue();
            mercadorias.Add(mercadoria);
            comboMercadoriasAdd.Items.Add(mercadoria.Descricao);
            limpar.CleanControl(tableInfoMercadoria);

        }

        private void comboMercadoriasAdd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Mercadoria mercadoria = mercadorias.FirstOrDefault(a => a.Descricao == comboMercadoriasAdd.Text);
            if(mercadoria == null)
            {
                return;
            }

            tbDescricao.Text = mercadoria.Descricao;
            tbValor.Text = "R$ " + mercadoria.Valor.ToString();
            tbPeso.Text = mercadoria.Massa + " Kg";
            tbVolume.Text = mercadoria.Volume + " m³";

        }

        private void btnAtualizarMercadoria_Click(object sender, EventArgs e)
        {
            Mercadoria mercadoria = mercadorias.FirstOrDefault(a => a.Descricao == comboMercadoriasAdd.Text);

            if (mercadoria == null)
            {
                MessageBox.Show("Erro ao atualizar mercadoria");
                return;
            }
            comboMercadoriasAdd.Items.Remove(mercadoria.Descricao);
            mercadoria.Descricao = tbDescricao.Text;
            mercadoria.Valor = tbValor.returnValue();
            mercadoria.Volume = tbVolume.returnValue();
            mercadoria.Massa = tbPeso.returnValue();
            comboMercadoriasAdd.Items.Add(mercadoria.Descricao);

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
