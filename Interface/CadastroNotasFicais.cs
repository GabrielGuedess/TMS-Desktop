using Interface.Properties;

namespace Interface
{
    public partial class CadastroNotasFicais : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                cadastrarNota.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentNotas.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentNotas.Location = new Point(0, 62);
                }
            }
        }

        public CadastroNotasFicais()
        {
            InitializeComponent();
            atualizarIDNota();
        }

        private void CadastroNotasFicais_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelID, panelTipo);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarNota_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarNota);
        }

        private bool validar()
        {
            if (tbChaveAcesso.Text.Length < 44)
            {
                MessageBox.Show("Chave de Acesso digitada é inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if(tbNumero.Text == "")
            {
                MessageBox.Show("Digite o Numero da nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbTipoNota.Text == "")
            {
                MessageBox.Show("Escolha o tipo de nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbSerieNota.Text == "")
            {
                MessageBox.Show("Digite a série da nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbDescricaoNota.Text == "")
            {
                MessageBox.Show("Digite uma descrição para nota fiscal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;

        }
        private void atualizarIDNota()
        {
            ConnectDB connectDB = new ConnectDB();
            string SQL = "SELECT MAX (NUM_ID) FROM C_Nota_Fiscal";
            var dados = connectDB.pesquisar(SQL);
            string data = (string)dados.Rows[0][0];
            string IdNota = data.Replace("F","");
            int numID = int.Parse(IdNota);
            numID++;
            string numIDsg = numID.ToString();
            if (numIDsg.Length == 1)
            {
                numIDsg = numIDsg.Insert(numIDsg.Length - 1, "00");
            }
            else if (numIDsg.Length == 2)
                numIDsg = numIDsg.Insert(numIDsg.Length - 2, "0");
            tbIDNotaFiscal.Text = "F" + numIDsg;
        }

        private void cadastrarNota_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                

                string SQL = "Insert Into C_Nota_Fiscal (NUM_ID, CHAVE_ACESSO,NUMERO,TIPO,SERIE,DESCRICAO) Values";
                SQL += $"('{tbIDNotaFiscal.Text.TrimStart()} ','{tbChaveAcesso.Text}','{tbNumero.Text}', '{tbTipoNota.Text}', '{tbSerieNota.Text}', '{tbDescricaoNota.Text}')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentNotas);
                atualizarIDNota();
            }
        }
    }
}
